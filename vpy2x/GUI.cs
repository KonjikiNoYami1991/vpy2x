using ChunksGenerator;
using FFmpeg_Output_Wrapper;
using Microsoft.WindowsAPICodePack.Taskbar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace vpy2x
{
    public partial class vpy2x : Form
    {
        public static readonly String PresetsFolder = Path.Combine(Application.StartupPath, "presets");
        public static readonly String LogsFolder = Path.Combine(Application.StartupPath, "logs");
        readonly String JobsFolder = Path.Combine(Application.StartupPath, "jobs");
        public static readonly String SettingsFile = Path.Combine(Application.StartupPath, "settings.ini");
        readonly String LOGFile = Path.Combine(Application.StartupPath, "LOG.txt");
        public static String VSpipeEXE = String.Empty;
        public static String av1anEXE = String.Empty;
        public static Dictionary<String, String> JobTemp = new Dictionary<String, String>();
        public static List<TreeNode> AudioTracks = new List<TreeNode>();
        public List<Job> JobList = new List<Job>();
        List<String> LOGLines = new List<String>();

        JobTask task;
        Int32 JobRunningIndex = -1;

        List<Dictionary<String, ProcessPriorityClass>> classes = new List<Dictionary<String, ProcessPriorityClass>>();

        TaskbarManager Taskbar = TaskbarManager.Instance;

        public static FormWindowState FWS;

        Boolean ForceClose = false;

        String Priority = String.Empty;

        Thread t;
        ThreadStart ts;

        Process p;
        ProcessStartInfo psi;

        public static Int32 ProcessID = Int32.MinValue;
        public static Int32 VSpipeID = Int32.MinValue;
        public static Int32 av1anID = Int32.MinValue;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = 0x0001,
            SUSPEND_RESUME = 0x0002,
            GET_CONTEXT = 0x0008,
            SET_CONTEXT = 0x0010,
            SET_INFORMATION = 0x0020,
            QUERY_INFORMATION = 0x0040,
            SET_THREAD_TOKEN = 0x0080,
            IMPERSONATE = 0x0100,
            DIRECT_IMPERSONATION = 0x0200
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

            if (Directory.Exists(JobsFolder) == false)
            {
                Directory.CreateDirectory(JobsFolder);
            }
            else
            {
                ReadSavedJobs();
            }

            if (Directory.Exists(LogsFolder) == false)
            {
                Directory.CreateDirectory(LogsFolder);
            }

            FWS = this.WindowState;

            cmb_priority.Text = cmb_priority.Items[0].ToString();

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);


            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            toolStripComboBoxShutdown.Text = toolStripComboBoxShutdown.Items[0].ToString();

            foreach (ProcessPriorityClass priority in (ProcessPriorityClass[])Enum.GetValues(typeof(ProcessPriorityClass)))
            {
                var Temp = new Dictionary<String, ProcessPriorityClass>();
                Temp.Add(priority.ToString().ToLower(), priority);
                classes.Add(Temp);
            }

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

        void ReadSavedJobs()
        {
            String[] Files = Directory.GetFiles(JobsFolder, "*.json", SearchOption.TopDirectoryOnly);
            for (Int32 i = 0; i < Files.Length; i++)
            {
                var SaveLoad = JsonConvert.DeserializeObject<SaveLoadJob>(File.ReadAllText(Files[i]));
                JobTemp = new Dictionary<String, String>();
                JobTemp.Add("VPY", SaveLoad.VPY);
                JobTemp.Add("Subject", SaveLoad.Subject);
                JobTemp.Add("Encoder", Path.Combine(SaveLoad.EncoderDir, SaveLoad.EncoderEXE));
                JobTemp.Add("Header", SaveLoad.Header);
                JobTemp.Add("End", SaveLoad.End);
                JobTemp.Add("Start", SaveLoad.Start);
                JobTemp.Add("Scene detection", SaveLoad.VPY4Scenes);
                JobTemp.Add("Audio", SaveLoad.Audio);
                if (String.IsNullOrWhiteSpace(SaveLoad.Audio) == false)
                {
                    using (Stream file = File.Open(SaveLoad.Audio, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        object obj = bf.Deserialize(file);

                        TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                        AudioTracks.AddRange(nodeList);
                    }
                }
                DGV_jobs.Rows.Add(SaveLoad.VPY, SaveLoad.Subject, SaveLoad.Status, SaveLoad.FPS);
                switch (SaveLoad.Colour)
                {
                    case "LightGreen":
                        DGV_jobs.Rows[i].Cells["status"].Style.BackColor = Color.LightGreen;
                        break;
                    case "LightGoldenrodYellow":
                        DGV_jobs.Rows[i].Cells["status"].Style.BackColor = Color.LightGoldenrodYellow;
                        break;
                    default:
                        DGV_jobs.Rows[i].Cells["status"].Style.BackColor = Color.White;
                        break;
                }
                DGV_jobs.Rows[i].Cells["status"].Style.SelectionBackColor = DGV_jobs.Rows[i].Cells["status"].Style.BackColor;
                JobList.Add(new Job(JobTemp));
                AudioTracks.Clear();
            }
        }

        private static void SuspendProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
            {
                return;
            }

            foreach (ProcessThread pT in process.Threads)
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
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
            {
                return;
            }

            foreach (ProcessThread pT in process.Threads)
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
            if (ini.KeyExists("vspipe_exe", "Main"))
            {
                if (String.IsNullOrWhiteSpace(ini.Read("vspipe_exe", "Main")) == false)
                {
                    VSpipeEXE = ini.Read("vspipe_exe", "Main");
                }
                else
                {
                    MessageBox.Show("Set the path of vspipe.exe file first.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("The path of vspipe.exe file isn't set.\nSet it before using this program.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (ini.KeyExists("priority", "Main"))
            {
                if (String.IsNullOrWhiteSpace(ini.Read("priority", "Main")) == false)
                {
                    Priority = ini.Read("priority", "Main");
                    SetPriority();
                    cmb_priority.Text = Priority;
                }
                else
                {
                    Priority = ProcessPriorityClass.Normal.ToString();
                    cmb_priority.Text = Priority;
                }
            }
            if (ini.KeyExists("FormWindowState", "Main"))
            {
                if (String.IsNullOrWhiteSpace(ini.Read("FormWindowState", "Main")) == false)
                {
                    switch (ini.Read("FormWindowState", "Main"))
                    {
                        case "Maximized":
                            this.WindowState = FormWindowState.Maximized;
                            break;
                        default:
                            this.WindowState = FormWindowState.Normal;
                            break;
                    }
                }
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
                ini.Write("vspipe_exe", o.FileName, "Main");
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
            LoadScript load = new LoadScript(PresetsFolder, false, String.Empty, new LoadScript.Preset(), String.Empty, AudioTracks);
            load.StartPosition = FormStartPosition.CenterParent;
            if (load.ShowDialog() == DialogResult.OK)
            {
                Job job = new Job(JobTemp);
                JobList.Add(job);
                DGV_jobs.Rows.Add(job.VPY, job.Subject, "Ready", "0");
                SaveJobsOnClosing();
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
            public String VPY4Scenes { get; set; } = String.Empty;
            public List<TreeNode> AudioTrackList { get; set; } = new List<TreeNode>();

            public Job(Dictionary<String, String> JobTemp)
            {
                VPY = JobTemp["VPY"];
                Subject = JobTemp["Subject"];
                EncoderEXE = Path.GetFileName(JobTemp["Encoder"]);
                EncoderDir = Path.GetDirectoryName(JobTemp["Encoder"]);
                Header = JobTemp["Header"];
                Start = JobTemp["Start"];
                End = JobTemp["End"];
                VPY4Scenes = JobTemp["Scene detection"];
                AudioTrackList.AddRange(AudioTracks);
                AudioTracks.Clear();
            }
        }

        public class JobTask
        {
            public String CommandLine { get; set; } = String.Empty;
            public String ErrorMessage { get; set; } = String.Empty;
            public Boolean HasErrors { get; set; } = false;
            public Job Job { get; set; }
            public VPYAnalize Analize { get; set; }

            String JsonScenes = String.Empty;

            vpy2x Gui;

            public JobTask(Job job, vpy2x Gui)
            {
                this.Job = job;
                this.Gui = Gui;
                GenerateCLI(job);
            }

            void GenerateCLI(Job job)
            {
                Analize = new VPYAnalize(job);
                if (Analize.HasErrors == false)
                {
                    if (job.EncoderEXE.ToLower().Contains("av1an"))
                    {
                        if (String.IsNullOrWhiteSpace(job.VPY4Scenes) == true)
                        {
                            CommandLine = " " + ReplacePlaceholders(job.Subject, Analize, job) + " -i \"" + job.VPY + "\"";
                        }
                        else
                        {
                            JsonScenes = Path.ChangeExtension(job.VPY4Scenes, ".json");
                            if (File.Exists(JsonScenes) == false)
                            {
                                ErrorMessage = SceneDetection();
                                if (String.IsNullOrWhiteSpace(ErrorMessage))
                                {
                                    HasErrors = false;
                                }
                                else
                                {
                                    HasErrors = true;
                                }
                            }
                            if (HasErrors == false)
                            {
                                ReadJsonScenes(JsonScenes);
                            }
                            CommandLine = " -s \"" + JsonScenes + "\" " + ReplacePlaceholders(job.Subject, Analize, job) + " -i \"" + job.VPY + "\"";
                        }
                    }
                    else
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
                }
                else
                {
                    ErrorMessage = Analize.ErrorMessage;
                    HasErrors = Analize.HasErrors;
                }
            }

            String SceneDetection()
            {
                var ps = new Process();
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.Arguments = " " + Path.GetFileName(VSpipeEXE) + " \"" + Job.VPY4Scenes + "\" --y4m - | ffmpeg.exe -i pipe:0 -hide_banner -f yuv4mpegpipe -pix_fmt yuv420p - | av-scenechange.exe -o \"" + JsonScenes + "\" - ";
                psi.ErrorDialog = true;
                psi.FileName = @"cmd.exe";
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                ps.StartInfo = psi;
                psi.RedirectStandardInput = true;
                ps.Start();
                ProcessID = ps.Id;
                ps.PriorityClass = ProcessPriorityClass.Idle;
                ps.BeginOutputReadLine();
                ps.BeginErrorReadLine();
                ps.OutputDataReceived += Ps_OutputDataReceived;
                ps.ErrorDataReceived += Ps_ErrorDataReceived;

                var Input = ps.StandardInput;
                Input.WriteLine("@echo off");
                Input.WriteLine(psi.Arguments);
                Input.WriteLine("exit");
                ps.WaitForExit();
                ps.CancelErrorRead();
                ps.CancelOutputRead();
                //MessageBox.Show(ps.ExitCode.ToString(), "Scene detection");
                if (ps.ExitCode == 0)
                {
                    ReadJsonScenes(JsonScenes);
                    return String.Empty;
                }
                else
                {
                    return ps.StandardError.ReadToEnd();
                }
            }

            private void Ps_ErrorDataReceived(object sender, DataReceivedEventArgs e)
            {
                ReportSceneDetection(e);
            }

            void ReadJsonScenes(String JsonScenes)
            {
                var Scenes = File.ReadAllText(JsonScenes);
                Scenes = Scenes.Replace("scene_changes", "scenes");
                Scenes = Scenes.Replace("frame_count", "frames");
                Scenes = Scenes.Replace("\n", "");
                Scenes = Scenes.Replace("\r", "");
                Scenes = Scenes.Replace(" ", "");
                Scenes = Scenes.Replace("[0,", "[");
                File.WriteAllText(JsonScenes, Scenes);
            }

            void ReportSceneDetection(DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    if (String.IsNullOrWhiteSpace(e.Data.Trim()) == false)
                    {
                        if (e.Data.Trim().ToLower().StartsWith("frame"))
                        {
                            FFmpegOutputWrapperNET ff = new FFmpegOutputWrapperNET(e.Data.Trim());
                            Gui.Invoke((MethodInvoker)delegate ()
                            {
                                Gui.DGV_jobs.Rows[Gui.JobRunningIndex].Cells["status"].Value = "Detecting scenes...";
                                Gui.DGV_jobs.Rows[Gui.JobRunningIndex].Cells["fps"].Value = ff.Frames + "/" + Analize.Frames;
                            });
                        }
                        else
                        {
                            Gui.Invoke((MethodInvoker)delegate ()
                            {
                                Gui.LOGLines.Add(e.Data);
                            });
                        }
                    }
                }
            }

            private void Ps_OutputDataReceived(object sender, DataReceivedEventArgs e)
            {
                ReportSceneDetection(e);
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
                    //MessageBox.Show(p.ExitCode.ToString());
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
            List<Int32> Selected = new List<Int32>();
            for (Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
            {
                if (DGV_jobs.Rows[i].Selected == true && DGV_jobs.Rows[i].Index != JobRunningIndex)
                {
                    Selected.Add(i);
                }
            }
            DGV_jobs.ClearSelection();
            foreach (Int32 i in Selected)
            {
                DGV_jobs.Rows.RemoveAt(i);
                JobList.RemoveAt(i);
            }
            if (b_start.Enabled == false)
            {
                foreach (DataGridViewRow d in DGV_jobs.Rows)
                {
                    if (d.Cells["status"].Value.ToString().ToLower().Contains("running"))
                    {
                        JobRunningIndex = d.Index;
                        break;
                    }
                }
            }
            SaveJobsOnClosing();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            for (Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
            {
                if (DGV_jobs.Rows[i].Selected == true && DGV_jobs.Rows[i].Index != JobRunningIndex)
                {
                    DGV_jobs.Rows[i].SetValues(DGV_jobs.Rows[i].Cells["script"].Value.ToString(), DGV_jobs.Rows[i].Cells["subject"].Value.ToString(), "Ready", "0");
                    DGV_jobs.Rows[i].Cells["status"].Style.BackColor = Color.Empty;
                    DGV_jobs.Rows[i].Cells["status"].Style.SelectionBackColor = Color.Empty;
                }
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.SelectedRows.Count > 0)
            {
                if (DGV_jobs.SelectedRows[0].Index != JobRunningIndex)
                {
                    LoadScript.Preset TempPreset = new LoadScript.Preset();
                    TempPreset.exe = Path.Combine(JobList[DGV_jobs.SelectedRows[0].Index].EncoderDir, JobList[DGV_jobs.SelectedRows[0].Index].EncoderEXE);
                    TempPreset.args = JobList[DGV_jobs.SelectedRows[0].Index].Subject;
                    TempPreset.header = JobList[DGV_jobs.SelectedRows[0].Index].Header;
                    LoadScript load = new LoadScript(PresetsFolder, true, JobList[DGV_jobs.SelectedRows[0].Index].VPY, TempPreset, JobList[DGV_jobs.SelectedRows[0].Index].VPY4Scenes, JobList[DGV_jobs.SelectedRows[0].Index].AudioTrackList);
                    load.StartPosition = FormStartPosition.CenterParent;
                    if (load.ShowDialog() == DialogResult.OK)
                    {
                        Job job = new Job(JobTemp);
                        JobList.RemoveAt(DGV_jobs.SelectedRows[0].Index);
                        JobList.Insert(DGV_jobs.SelectedRows[0].Index, job);
                        DGV_jobs.Rows[DGV_jobs.SelectedRows[0].Index].SetValues(job.VPY, job.Subject, "Ready", "0");
                        DGV_jobs.Rows[DGV_jobs.SelectedRows[0].Index].Cells["status"].Style.BackColor = Color.Empty;
                        DGV_jobs.Rows[DGV_jobs.SelectedRows[0].Index].Cells["status"].Style.SelectionBackColor = Color.Empty;
                    }
                    SaveJobsOnClosing();
                }
            }
        }

        private void b_move_up_Click(object sender, EventArgs e)
        {
            DataGridView dgv = DGV_jobs;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                {
                    return;
                }
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex - 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void b_move_down_Click(object sender, EventArgs e)
        {
            DataGridView dgv = DGV_jobs;
            try
            {
                Int32 totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                {
                    return;
                }
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.Rows.Count > 0)
            {
                JobRunningIndex = 0;
                ts = new ThreadStart(Encode);
                t = new Thread(ts);
                t.Start();
                b_start.Enabled = false;
                b_stop.Enabled = true;
                b_pause_resume.Enabled = b_stop.Enabled;
                setVSpipeexePathToolStripMenuItem.Enabled = b_start.Enabled;
            }
        }

        void Encode()
        {
            LOGLines.Clear();
            for (Int32 i = 0; i < JobList.Count; i++)
            {
                if (DGV_jobs.Rows[i].Cells["status"].Value.ToString().ToLower().Contains("ready"))
                {
                    JobRunningIndex = i;
                    task = new JobTask(JobList[JobRunningIndex], this);
                    Environment.CurrentDirectory = task.Job.EncoderDir;
                    if (task.HasErrors == false)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", "0");
                        });

                        psi = new ProcessStartInfo();
                        p = new Process();

                        psi.FileName = task.Job.EncoderEXE;
                        psi.Arguments = task.CommandLine;

                        psi.UseShellExecute = false;
                        psi.RedirectStandardOutput = true;
                        psi.RedirectStandardError = true;
                        psi.RedirectStandardInput = true;
                        psi.CreateNoWindow = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;

                        p = new Process();
                        p.EnableRaisingEvents = true;
                        p.StartInfo = psi;
                        p.OutputDataReceived += P_OutputDataReceived;
                        p.ErrorDataReceived += P_ErrorDataReceived;

                        p.Start();

                        ProcessID = p.Id;
                        p.PriorityClass = SetPriority();
                        p.BeginOutputReadLine();
                        p.BeginErrorReadLine();

                        if (task.Job.EncoderEXE.ToLower().Contains("av1an") == false)
                        {
                            var Input = p.StandardInput;
                            Input.WriteLine("@echo off");
                            Input.WriteLine(task.CommandLine);
                            Input.WriteLine("exit");
                            Input.Close();
                        }

                        this.Invoke((MethodInvoker)delegate ()
                        {
                            DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                            Taskbar.SetProgressValue(0, 100);
                        });

                        DateTime StartTime = DateTime.Now;

                        p.WaitForExit();

                        p.CancelErrorRead();
                        p.CancelOutputRead();

                        switch (p.ExitCode)
                        {
                            case 0:
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Done.\n\nStarted: " + StartTime.ToString() + "\n\nEnded: " + DateTime.Now.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString().Split(':')[0] + " 00:00:00");
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.BackColor = Color.LightGreen;
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.SelectionBackColor = Color.LightGreen;
                                    Taskbar.SetProgressValue(100, 100);
                                });
                                break;
                            case -1:
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Aborted.\n\nStarted: " + StartTime.ToString() + "\n\nEnded: " + DateTime.Now.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.BackColor = Color.LightGoldenrodYellow;
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.SelectionBackColor = Color.LightGoldenrodYellow;
                                });
                                break;
                            default:
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Error(s)", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.BackColor = Color.OrangeRed;
                                    DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.SelectionBackColor = Color.OrangeRed;
                                });
                                break;
                        }
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Error(s)", "0");
                            DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.BackColor = Color.OrangeRed;
                            DGV_jobs.Rows[JobRunningIndex].Cells["status"].Style.SelectionBackColor = Color.OrangeRed;
                        });
                    }
                    i = 0;
                    if (b_start.Enabled == true)
                    {
                        break;
                    }
                }
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                Taskbar.SetProgressValue(0, 100);
                Taskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
                b_start.Enabled = true;
                b_stop.Enabled = false;
                b_pause_resume.Enabled = b_stop.Enabled;
            });
            File.WriteAllLines(Path.Combine(LogsFolder, "JOB " + (JobRunningIndex + 1).ToString() + ".txt"), LOGLines.ToArray());
            JobRunningIndex = -1;
            switch (toolStripComboBoxShutdown.Text)
            {
                case "Shutdown":
                    ForceClose = true;
                    SaveJobsOnClosing();
                    Process.Start("shutdown", "/f /s /t 30").StartInfo = new ProcessStartInfo() { CreateNoWindow = true, UseShellExecute = false };
                    var Shutdown = MessageBox.Show("Your PC will shutdown in 30 seconds from now.\nPress Cancel button to cancel shutdown.", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (Shutdown != DialogResult.Cancel)
                    {
                        Process.Start("shutdown", "/a").StartInfo = new ProcessStartInfo() { CreateNoWindow = true, UseShellExecute = false };
                    }
                    break;
                case "Reboot":
                    ForceClose = true;
                    SaveJobsOnClosing();
                    Process.Start("shutdown", "/f /r /t 30").StartInfo = new ProcessStartInfo() { CreateNoWindow = true, UseShellExecute = false };
                    var Reboot = MessageBox.Show("Your PC will reboot in 30 seconds from now.\nPress Cancel button to cancel reboot.", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (Reboot == DialogResult.Cancel)
                    {
                        Process.Start("shutdown", "/a").StartInfo = new ProcessStartInfo() { CreateNoWindow = true, UseShellExecute = false };
                    }
                    break;
                case "Stand-by":
                    SaveJobsOnClosing();
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case "Close application":
                    ForceClose = true;
                    this.Close();
                    break;
            }
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.Data) == false)
            {
                if (JobList[JobRunningIndex].EncoderEXE.ToLower().Trim().Contains("av1an") == false)
                {

                    if (e.Data.Trim().StartsWith("Frame:"))
                    {
                        ReportStatusVSpipe(e.Data);
                    }
                    else
                    {
                        LOGLines.Add(e.Data);
                    }
                }
                else
                {
                    LOGLines.Add(e.Data);
                    //ReportStatusAV1AN(e.Data.Trim());
                }
            }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.Data) == false)
            {
                if (JobList[JobRunningIndex].EncoderEXE.ToLower().Trim().Contains("av1an") == false)
                {
                    if (e.Data.Trim().StartsWith("Frame:"))
                    {
                        ReportStatusVSpipe(e.Data);
                    }
                    else
                    {
                        LOGLines.Add(e.Data);
                    }
                }
                else
                {

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        LOGLines.Add(e.Data);
                    });

                    ReportStatusAV1AN(e.Data.Trim());
                }
            }
        }

        void ReportStatusAV1AN(String Data)
        {
            //if (Data.Contains("(") && Data.Contains(")") && Data.Contains("[") && Data.Contains("]") && Data.Contains("%") && Data.Contains("-") && Data.Contains(new JobTask(JobList[JobRunningIndex], this).Analize.Frames))
            //{
            //    String Info = Data.Substring(Data.IndexOf("%") + 1).Trim();
            //    Info = Info.Replace(" ", String.Empty);
            //    String Progress = Info.Split('(')[0];
            //    String ETA = Info.Split('(')[1];
            //    ETA = ETA.Split(',')[1].Replace("eta", "Remaining time:").Trim();
            //    this.Invoke((MethodInvoker)delegate ()
            //    {
            //        DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value = Progress + "\n" + ETA;
            //    });
            //}
            //else
            //{
            //    this.Invoke((MethodInvoker)delegate ()
            //    {
            //        rtb_log.Text += Data.TrimEnd() + "\n";
            //        rtb_log.SelectionStart = rtb_log.TextLength;
            //        rtb_log.ScrollToCaret();
            //    });
            //}
            //this.Invoke((MethodInvoker)delegate ()
            //{
            //    rtb_log.Text += Data.TrimEnd() + "\n";
            //    rtb_log.SelectionStart = rtb_log.TextLength;
            //    rtb_log.ScrollToCaret();
            //});
        }

        void ReportStatusVSpipe(String Data)
        {
            String Progress = Data.Substring(Data.IndexOf(" ")).Trim();
            String RemainigTime = String.Empty;
            if (Progress.Contains(" "))
            {
                String Percentage = Progress.Substring(0, Progress.IndexOf(" ")).Trim();
                Int32 NFrames = Convert.ToInt32(Percentage.Split('/')[1]);
                Int32 DFrames = Convert.ToInt32(Percentage.Split('/')[0]);
                this.Invoke((MethodInvoker)delegate ()
                {
                    Taskbar.SetProgressValue(DFrames, NFrames);
                });
                if (Progress.Contains("(") && Progress.Contains(")"))
                {
                    RemainigTime = Progress.Substring(Progress.LastIndexOf("(")).Trim();
                    RemainigTime = RemainigTime.Trim('(').Split(' ')[0].Trim();
                    RemainigTime = ((Convert.ToDouble(NFrames) - Convert.ToDouble(DFrames)) / Convert.ToDouble(RemainigTime)).ToString();
                    RemainigTime = TimeSpan.FromSeconds(Convert.ToDouble(RemainigTime)).ToString(@"hh\:mm\:ss");
                }
                RemainigTime = "\r\nRemaning: " + RemainigTime;
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["status"].Value.ToString(), Progress + RemainigTime);
            });
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                try
                {
                    KillProcessAndChildren(ProcessID);
                    KillProcessAndChildren(VSpipeID);
                }
                catch { }
                t = null;
                b_start.Enabled = true;
                b_stop.Enabled = false;
                b_pause_resume.Enabled = b_stop.Enabled;
                setVSpipeexePathToolStripMenuItem.Enabled = b_start.Enabled;
            }
        }

        public void SuspendOrResume(Boolean Suspend, Int32 PID)
        {
            using (var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + PID))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    SuspendOrResume(Suspend, Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    switch (Suspend)
                    {
                        case true:
                            SuspendProcess(PID);
                            break;
                        case false:
                            ResumeProcess(PID);
                            break;
                    }
                }
                catch
                {
                    // Process already exited.
                }
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
                catch
                {
                    // Process already exited.
                }
            }
        }

        public void SetPriorityProcessAndChildren(Int32 pid)
        {
            using (var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    SetPriorityProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    var proc = Process.GetProcessById(pid);
                    proc.PriorityClass = SetPriority();
                }
                catch
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
                    //SuspendProcess(ProcessID);
                    SuspendOrResume(true, ProcessID);
                    Taskbar.SetProgressState(TaskbarProgressBarState.Paused);
                    DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Paused", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                }
                else
                {
                    if (DGV_jobs.Rows[JobRunningIndex].Cells["status"].Value.ToString().ToLower().Contains("paused"))
                    {
                        //ResumeProcess(ProcessID);
                        SuspendOrResume(false, ProcessID);
                        Taskbar.SetProgressState(TaskbarProgressBarState.Normal);
                        DGV_jobs.Rows[JobRunningIndex].SetValues(DGV_jobs.Rows[JobRunningIndex].Cells["script"].Value.ToString(), DGV_jobs.Rows[JobRunningIndex].Cells["subject"].Value.ToString(), "Running", DGV_jobs.Rows[JobRunningIndex].Cells["fps"].Value.ToString());
                    }
                }
            }
        }

        private void vpy2x_DragEnter(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy")
                {
                    e.Effect = DragDropEffects.Copy;
                    break;
                }
            }
        }

        private void vpy2x_DragDrop(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy")
                {
                    LoadScript load = new LoadScript(PresetsFolder, false, s, new LoadScript.Preset(), String.Empty, AudioTracks);
                    load.ShowDialog();
                    if (load.DialogResult == DialogResult.OK)
                    {
                        Job job = new Job(JobTemp);
                        JobList.Add(job);
                        DGV_jobs.Rows.Add(job.VPY, job.Subject, "Ready", "0");
                    }
                    else
                    {
                        if (load.DialogResult == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }
                SaveJobsOnClosing();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_stop_Click(sender, e);
            Application.Exit();
        }

        private void vpy2x_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ForceClose == true)
            {
                b_stop_Click(sender, e);
                CloseApplication();
            }
            else
            {
                if (MessageBox.Show("Close this application?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    b_stop_Click(sender, e);
                    CloseApplication();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        void CloseApplication()
        {
            SaveJobsOnClosing();
            IniFile ini = new IniFile(SettingsFile);
            ini.Write("priority", cmb_priority.Text, "Main");
        }

        void SaveJobsOnClosing()
        {
            foreach (String s in Directory.GetFiles(JobsFolder))
            {
                File.Delete(s);
            }

            for (Int32 i = 0; i < JobList.Count; i++)
            {
                Job job = JobList[i];
                SaveLoadJob SaveLoad = new SaveLoadJob();
                SaveLoad.Subject = job.Subject;
                SaveLoad.EncoderEXE = job.EncoderEXE;
                SaveLoad.EncoderDir = job.EncoderDir;
                SaveLoad.End = job.End;
                SaveLoad.Start = job.Start;
                SaveLoad.VPY = job.VPY;
                SaveLoad.FPS = DGV_jobs.Rows[i].Cells["fps"].Value.ToString();
                SaveLoad.Status = DGV_jobs.Rows[i].Cells["status"].Value.ToString();
                SaveLoad.Header = job.Header;
                SaveLoad.Colour = DGV_jobs.Rows[i].Cells["status"].Style.BackColor.Name;
                SaveLoad.VPY4Scenes = job.VPY4Scenes;
                SaveLoad.Audio = String.Empty;
                if (job.AudioTrackList.Count > 0)
                {
                    SaveLoad.Audio = Path.Combine(JobsFolder, "Job " + (i + 1).ToString() + " Audio.vpy2x");
                    WriteAudioParameters(job.AudioTrackList, SaveLoad.Audio);
                }
                File.WriteAllText(Path.Combine(JobsFolder, "Job " + (i + 1).ToString() + ".json"), JsonConvert.SerializeObject(SaveLoad, Formatting.Indented));
            }
        }

        void WriteAudioParameters(List<TreeNode> Nodes, String FileName)
        {
            using (Stream file = File.Open(FileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Nodes);
            }
        }

        public struct SaveLoadJob
        {
            public String Subject { get; set; }
            public String EncoderEXE { get; set; }
            public String VPY { get; set; }
            public String Header { get; set; }
            public String EncoderDir { get; set; }
            public String Start { get; set; }
            public String End { get; set; }
            public String Status { get; set; }
            public String FPS { get; set; }
            public String Colour { get; set; }
            public String VPY4Scenes { get; set; }
            public String Audio { get; set; }
        }

        private void cmb_priority_SelectedValueChanged(object sender, EventArgs e)
        {
            Priority = cmb_priority.Text;
            if (p != null && p.HasExited == false)
            {
                p.PriorityClass = SetPriority();
                SetPriorityProcessAndChildren(ProcessID);
            }
        }

        public ProcessPriorityClass SetPriority()
        {
            switch (Priority)
            {
                case "Idle":
                    return ProcessPriorityClass.Idle;
                case "Below Normal":
                    return ProcessPriorityClass.BelowNormal;
                case "Above Normal":
                    return ProcessPriorityClass.AboveNormal;
                case "High":
                    return ProcessPriorityClass.High;
                default:
                    return ProcessPriorityClass.Normal;
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences p = new Preferences();
            p.ShowDialog();
        }

        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_jobs.ClearSelection();
        }

        private void openLOGForSelectedJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV_jobs.SelectedRows.Count > 0)
            {
                if (File.Exists(Path.Combine(LogsFolder, "JOB " + (DGV_jobs.SelectedRows[0].Index + 1).ToString() + ".txt")))
                {
                    Process.Start(Path.Combine(LogsFolder, "JOB " + (DGV_jobs.SelectedRows[0].Index + 1).ToString() + ".txt"));
                }
                else
                {
                    MessageBox.Show("No log exists for this job.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }

    public class IniFile
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
