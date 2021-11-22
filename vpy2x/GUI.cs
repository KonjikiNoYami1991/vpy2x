using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Management;

namespace vpy2x
{
    public partial class vpy2x : Form
    {
        readonly String PresetsFolder = Path.Combine(Application.StartupPath, "presets");
        readonly String SettingsFile = Path.Combine(Application.StartupPath, "settings.ini");
        public static String VSpipeEXE = String.Empty;
        public static Dictionary<String, String> JobTemp = new Dictionary<String, String>();
        public List<Job> JobList = new List<Job>();
        JobTask task;
        Int32 JobRunningIndex = -1;

        Thread t;
        ThreadStart ts;

        Process p;
        ProcessStartInfo psi;

        Int32 ProcessID = Int32.MinValue;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        public vpy2x()
        {
            InitializeComponent();

            toolStripComboBoxShutdown.Text = toolStripComboBoxShutdown.Items[0].ToString();

            if (Directory.Exists(PresetsFolder) == false)
            {
                Directory.CreateDirectory(PresetsFolder);
            }

            if (File.Exists(SettingsFile))
            {
                ReadSettings(new IniFile(SettingsFile));
            }
            else
            {
                MessageBox.Show("Set the path of vspipe.exe file first.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void SuspendProcess(int pid)
        {
            var process = System.Diagnostics.Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (System.Diagnostics.ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }

        public static void ResumeProcess(int pid)
        {
            var process = System.Diagnostics.Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (System.Diagnostics.ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }

        void ReadSettings(IniFile ini)
        {
            if (ini.KeyExists("vspipe_exe"))
            {
                if (String.IsNullOrWhiteSpace(ini.Read("vspipe_exe")) == false)
                    VSpipeEXE = ini.Read("vspipe_exe");
                else
                    MessageBox.Show("The path of vspipe.exe file isn't set.\nSet it before using this program.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void setVSpipeexePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "EXE files|*.exe;*.EXE";
            o.Title = "Set the path of vspipe.exe file";
            o.InitialDirectory = Application.StartupPath;
            o.DefaultExt = "exe";
            o.Multiselect = false;
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                VSpipeEXE = o.FileName;
                IniFile ini = new IniFile(SettingsFile);
                ini.Write("vspipe_exe", o.FileName);
            }
            else
            {
                MessageBox.Show("Set the path of vspipe.exe file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editPresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPresets edit = new EditPresets(PresetsFolder);
            edit.StartPosition = FormStartPosition.CenterParent;
            edit.ShowDialog();
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            LoadScript load = new LoadScript(PresetsFolder, false, String.Empty, new LoadScript.Preset());
            load.StartPosition = FormStartPosition.CenterParent;
            if (load.ShowDialog() == DialogResult.OK)
            {
                Job job = new Job(JobTemp);
                JobList.Add(job);
                DGV_jobs.Rows.Add(job.VPY, job.Subject, "Ready", "0");
            }
        }

        public class Job
        {
            public String VPY { get; set; } = String.Empty;
            public String EncoderEXE { get; set; } = String.Empty;
            public String EncoderDir { get; set; } = String.Empty;
            public String Subject { get; set; } = String.Empty;
            public String Header { get; set; } = String.Empty;
            public String Start { get; set; } = String.Empty;
            public String End { get; set; } = String.Empty;

            public Job(Dictionary<String, String> JobTemp)
            {
                VPY = JobTemp["VPY"];
                Subject = JobTemp["Subject"];
                EncoderEXE = Path.GetFileName(JobTemp["Encoder"]);
                EncoderDir = Path.GetDirectoryName(JobTemp["Encoder"]);
                Header = JobTemp["Header"];
                Start = JobTemp["Start"];
                End = JobTemp["End"];
            }
        }

        public class JobTask
        {
            public String CommandLine { get; set; } = String.Empty;
            public String ErrorMessage { get; set; } = String.Empty;
            public Boolean HasErrors { get; set; } = false;
            public Job Job { get; set; }

            public JobTask(Job job)
            {
                this.Job = job;
                GenerateCLI(job);
            }

            void GenerateCLI(Job job)
            {
                VPYAnalize Analize = new VPYAnalize(job);
                if (Analize.HasErrors == false)
                {
                    CommandLine = "\"" + VSpipeEXE + "\"";
                    CommandLine += " --progress";
                    CommandLine += job.Start;
                    CommandLine += job.End;
                    CommandLine += " \"" + job.VPY + "\"";
                    CommandLine += " - ";
                    CommandLine += job.Header;
                    CommandLine += " | ";
                    CommandLine += job.EncoderEXE;
                    CommandLine += " " + ReplacePlaceholders(job.Subject, Analize, job);
                    //MessageBox.Show(CommandLine);
                }
                else
                {
                    ErrorMessage = Analize.ErrorMessage;
                    HasErrors = Analize.HasErrors;
                }
            }

            String ReplacePlaceholders(String Subject, VPYAnalize Analize, Job job)
            {
                String Temp = Subject;

                Temp = Temp.Replace("{fpsn}", Analize.FramerateNumerator);
                Temp = Temp.Replace("{fpsd}", Analize.FramerateDenominator);
                Temp = Temp.Replace("{fps}", Analize.FramerateAsFraction);
                Temp = Temp.Replace("{ss}", Analize.FormatName.ToLower());
                Temp = Temp.Replace("{bits}", Analize.Bits);
                Temp = Temp.Replace("{f}", Analize.Frames);
                Temp = Temp.Replace("{bits}", Analize.Bits);
                Temp = Temp.Replace("{w}", Analize.Width);
                Temp = Temp.Replace("{h}", Analize.Height);
                Temp = Temp.Replace("{sd}", Path.GetDirectoryName(job.VPY));
                Temp = Temp.Replace("{sn}", Path.GetFileNameWithoutExtension(job.VPY));

                return Temp;
            }

            public class VPYAnalize
            {
                public String Width { get; set; } = String.Empty;
                public String Height { get; set; } = String.Empty;
                public String Frames { get; set; } = String.Empty;
                public String FPS { get; set; } = String.Empty;
                public String FramerateNumerator { get; set; } = String.Empty;
                public String FramerateDenominator { get; set; } = String.Empty;
                public String FramerateAsFraction { get; set; } = String.Empty;
                public String FormatName { get; set; } = String.Empty;
                public String ColorFamily { get; set; } = String.Empty;
                public String Alpha { get; set; } = String.Empty;
                public String SampleType { get; set; } = String.Empty;
                public String Bits { get; set; } = String.Empty;
                public String SubSamplingW { get; set; } = String.Empty;
                public String SubSamplingH { get; set; } = String.Empty;
                public String ErrorMessage { get; set; } = String.Empty;
                public Boolean HasErrors { get; set; } = false;

                public VPYAnalize(Job job)
                {
                    var p = new Process();
                    var psi = new ProcessStartInfo();
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.Arguments = " --info \"" + job.VPY + "\"";
                    psi.ErrorDialog = true;
                    psi.FileName = "\"" + VSpipeEXE + "\"";
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo = psi;
                    p.Start();                    
                    p.WaitForExit();
                    MessageBox.Show(p.ExitCode.ToString());
                    switch (p.ExitCode)
                    {
                        case 0:
                            String[] temp = p.StandardOutput.ReadToEnd().Trim().Split(new String[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                            var ScriptInfo = new Dictionary<String, String>();

                            foreach (String s in temp)
                            {
                                ScriptInfo.Add(s.Split(':')[0].Trim(), s.Split(':')[1].Trim());
                            }

                            if (ScriptInfo.ContainsKey("Width"))
                            {
                                Width = ScriptInfo["Width"];
                            }
                            if (ScriptInfo.ContainsKey("Height"))
                            {
                                Height = ScriptInfo["Height"];
                            }
                            if (ScriptInfo.ContainsKey("Frames"))
                            {
                                Frames = ScriptInfo["Frames"];
                            }
                            if (ScriptInfo.ContainsKey("FPS"))
                            {
                                if (ScriptInfo["FPS"].ToLower().StartsWith("var") == false)
                                {
                                    FPS = ScriptInfo["FPS"].Split(' ')[0];
                                    FramerateAsFraction = ScriptInfo["FPS"].Substring(ScriptInfo["FPS"].IndexOf('('), ScriptInfo["FPS"].IndexOf(' ')).Trim();
                                    FramerateNumerator = FPS.Split(' ')[0].Split('/')[0];
                                    FramerateDenominator = FPS.Split(' ')[0].Split('/')[1];
                                }
                                else
                                {
                                    FPS = ScriptInfo["FPS"];
                                }
                            }
                            if (ScriptInfo.ContainsKey("Format Name"))
                            {
                                FormatName = ScriptInfo["Format Name"];
                            }
                            if (ScriptInfo.ContainsKey("Color Family"))
                            {
                                ColorFamily = ScriptInfo["Color Family"];
                            }
                            if (ScriptInfo.ContainsKey("Alpha"))
                            {
                                Alpha = ScriptInfo["Alpha"];
                            }
                            if (ScriptInfo.ContainsKey("Sample Type"))
                            {
                                SampleType = ScriptInfo["Sample Type"];
                            }
                            if (ScriptInfo.ContainsKey("Bits"))
                            {
                                Bits = ScriptInfo["Bits"];
                            }
                            if (ScriptInfo.ContainsKey("SubSampling W"))
                            {
                                SubSamplingW = ScriptInfo["SubSampling W"];
                            }
                            if (ScriptInfo.ContainsKey("SubSampling H"))
                            {
                                SubSamplingH = ScriptInfo["SubSampling H"];
                            }
                            break;
                        default:
                            ErrorMessage = p.StandardError.ReadToEnd();
                            HasErrors = true;
                            break;
                    }
                }
            }
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            for (Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
            {
                if (DGV_jobs.Rows[i].Selected == true)
                {
                    DGV_jobs.Rows.RemoveAt(i);
                    JobList.RemoveAt(i);
                }
            }
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            for (Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
            {
                if (DGV_jobs.Rows[i].Selected == true)
                {
                    DGV_jobs.Rows[i].SetValues(DGV_jobs.Rows[i].Cells["subject"].Value.ToString(), "Ready", "0");
                }
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.SelectedRows.Count > 0)
            {
                LoadScript.Preset TempPreset = new LoadScript.Preset();
                TempPreset.exe = Path.Combine(JobList[DGV_jobs.SelectedRows[0].Index].EncoderDir, JobList[DGV_jobs.SelectedRows[0].Index].EncoderEXE);
                TempPreset.args = JobList[DGV_jobs.SelectedRows[0].Index].Subject;
                TempPreset.header = JobList[DGV_jobs.SelectedRows[0].Index].Header;
                LoadScript load = new LoadScript(PresetsFolder, true, JobList[DGV_jobs.SelectedRows[0].Index].VPY, TempPreset);
                load.StartPosition = FormStartPosition.CenterParent;
                if (load.ShowDialog() == DialogResult.OK)
                {
                    Job job = new Job(JobTemp);
                    JobList.RemoveAt(DGV_jobs.SelectedRows[0].Index);
                    JobList.Insert(DGV_jobs.SelectedRows[0].Index, job);
                    DGV_jobs.Rows[DGV_jobs.SelectedRows[0].Index].SetValues(job.VPY, job.Subject, "Ready", "0");
                }
            }
        }

        private void b_move_up_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.SelectedRows.Count > 0)
            {
                if (DGV_jobs.SelectedRows[0].Index > 0)
                {
                    for (Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
                    {
                        if (DGV_jobs.Rows[i].Selected == true)
                        {
                            DataGridViewRow r = DGV_jobs.Rows[i];
                            Job temp = JobList[i];
                            JobList.RemoveAt(i);
                            DGV_jobs.Rows.RemoveAt(i);
                            JobList.Insert(i - 1, temp);
                            DGV_jobs.Rows.Insert(i - 1, r);
                        }
                    }
                }
            }
        }

        private void b_move_down_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.SelectedRows.Count > 0)
            {
                if (DGV_jobs.SelectedRows[0].Index < DGV_jobs.Rows.Count - 1)
                {
                    for (Int32 i = 0; i < DGV_jobs.Rows.Count; i++)
                    {
                        if (DGV_jobs.Rows[i].Selected == true)
                        {
                            DataGridViewRow r = DGV_jobs.Rows[i];
                            Job temp = JobList[i];
                            JobList.RemoveAt(i);
                            DGV_jobs.Rows.RemoveAt(i);
                            JobList.Insert(i + 1, temp);
                            DGV_jobs.Rows.Insert(i + 1, r);
                        }
                    }
                }
            }
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < JobList.Count; i++)
            {
                task = new JobTask(JobList[i]);
                JobRunningIndex = i;
                if (task.HasErrors == false)
                {
                    rtb_log.AppendText("---------------------------------------------------------------------------------------\n");
                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", "0");
                    ts = new ThreadStart(Encode);
                    t = new Thread(ts);
                    t.Start();
                }
                else
                {
                    rtb_log.AppendText("---------------------------------------------------------------------------------------\n");
                    rtb_log.AppendText(task.ErrorMessage);
                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Error(s)", "0");
                }
            }
        }

        void Encode()
        {
            Environment.CurrentDirectory = task.Job.EncoderDir;
            psi = new ProcessStartInfo();
            psi.FileName = @"cmd.exe";
            
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            p = new Process();
            p.StartInfo = psi;
            p.OutputDataReceived += P_OutputDataReceived;
            p.ErrorDataReceived += P_ErrorDataReceived;

            p.Start();

            ProcessID = p.Id;
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            var Input = p.StandardInput;
            Input.WriteLine(task.CommandLine);
            Input.WriteLine("exit");

            p.WaitForExit();

            switch (p.ExitCode)
            {
                case 0:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Done", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                    });
                    break;
                case -1:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Aborted", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                    });
                    break;
                default:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Error(s)", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                    });
                    break;
            }
            p.CancelErrorRead();
            p.CancelOutputRead();
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.Data) == false)
            {
                if (e.Data.Trim().StartsWith("Frame:"))
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        String Progress = e.Data.Substring(e.Data.IndexOf(" ")).Trim();
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", Progress);
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        rtb_log.AppendText(e.Data + "\n");
                    });
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    rtb_log.SelectionStart = rtb_log.TextLength;
                    rtb_log.ScrollToCaret();
                });
            }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.Data) == false)
            {
                if (e.Data.Trim().StartsWith("Frame:"))
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        String Progress = e.Data.Substring(e.Data.IndexOf(" ")).Trim();
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", Progress);
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        rtb_log.AppendText(e.Data + "\n");
                    });
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    rtb_log.SelectionStart = rtb_log.TextLength;
                    rtb_log.ScrollToCaret();
                });
            }
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                try
                {
                    KillProcessAndChildren(ProcessID);
                }
                catch { }
                t = null;
                JobRunningIndex = -1;
            }
        }

        public void KillProcessAndChildren(Int32 pid)
        {
            using (var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    var proc = Process.GetProcessById(pid);
                    proc.Kill();
                }
                catch (Exception e)
                {
                    // Process already exited.
                }
            }
        }

        private void b_pause_resume_Click(object sender, EventArgs e)
        {
            if (JobRunningIndex != -1)
            {
                if (DGV_jobs.Rows[JobRunningIndex].Cells["status"].Value.ToString().ToLower().Contains("running"))
                {
                    SuspendProcess(ProcessID);
                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Paused", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                }
                else
                {
                    if (DGV_jobs.Rows[JobRunningIndex].Cells["status"].Value.ToString().ToLower().Contains("paused"))
                    {
                        ResumeProcess(ProcessID);
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                    }
                }
            }
        }

        private void vpy2x_DragEnter(object sender, DragEventArgs e)
        {
            foreach(String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if(Path.GetExtension(s).ToLower() == ".vpy")
                {
                    e.Effect = DragDropEffects.Copy;
                    break;
                }
            }
        }

        private void vpy2x_DragDrop(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy")
                {
                    LoadScript load = new LoadScript(PresetsFolder, false, s, new LoadScript.Preset());
                    load.ShowDialog();
                    if (load.DialogResult == DialogResult.OK)
                    {
                        Job job = new Job(JobTemp);
                        JobList.Add(job);
                        DGV_jobs.Rows.Add(job.VPY, job.Subject, "Ready", "0"); }
                    else
                    {
                        if(load.DialogResult == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }

    class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

    }
}
