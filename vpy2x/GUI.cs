using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace vpy2x
{
    public partial class vpy2x : Form
    {

        readonly String PresetsFolder = Path.Combine(Application.StartupPath, "presets");
        readonly String SettingsFile = Path.Combine(Application.StartupPath, "settings.ini");
        public static String VSpipeEXE = String.Empty;
        public static Dictionary<String,String> JobTemp = new Dictionary<String, String>();
        public List<Job> JobList = new List<Job>();

        Thread t;
        ThreadStart ts;

        public vpy2x()
        {
            InitializeComponent();

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
                if (job.HasErrors == false)
                {
                    JobList.Add(job);
                    DGV_jobs.Rows.Add(job.VPY, job.Subject, "Ready", "0");
                }
                else
                {
                    rtb_log.AppendText(job.ErrorMessage);
                    MessageBox.Show("There was one or multiple errors while analizing VPY file.\nTake a look to the log section.");
                }
            }
        }

        public class Job
        {
            public String VPY { get; set; } = String.Empty;
            public String Encoder { get; set; } = String.Empty;
            public String Subject { get; set; } = String.Empty;
            public String Header { get; set; } = String.Empty;
            public String Start { get; set; } = String.Empty;
            public String End { get; set; } = String.Empty;
            public String CommandLine { get; set; } = String.Empty;
            public String ErrorMessage { get; set; } = String.Empty;
            public Boolean HasErrors { get; set; } = false;

            public Job(Dictionary<String,String> JobTemp)
            {
                VPY = JobTemp["VPY"];
                Subject = JobTemp["Subject"];
                Encoder = JobTemp["Encoder"];
                Header = JobTemp["Header"];
                VPYAnalize Analize = new VPYAnalize(VPY);
                if (Analize.HasErrors == false)
                {
                    CommandLine = Path.GetFileName(VSpipeEXE);
                    CommandLine += " \"" + VPY + "\"";
                    CommandLine += JobTemp["Start"];
                    CommandLine += JobTemp["End"];
                    CommandLine += JobTemp["Header"];
                    CommandLine += " - | ";
                    CommandLine += " \"" + JobTemp["Encoder"] + "\"";
                    CommandLine += ReplacePlaceholders(JobTemp["Subject"],Analize);
                    //MessageBox.Show(CommandLine);
                }
                else
                {
                    ErrorMessage = Analize.ErrorMessage;
                    HasErrors = Analize.HasErrors;
                }
            }

            String ReplacePlaceholders(String Subject, VPYAnalize Analize)
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
                Temp = Temp.Replace("{sd}", Path.GetDirectoryName(VPY));
                Temp = Temp.Replace("{sn}", Path.GetFileNameWithoutExtension(VPY));

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

                public VPYAnalize(String VPY)
                {
                    var p = new Process();
                    var psi = new ProcessStartInfo();
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.Arguments = " --info \"" + VPY + "\"";
                    psi.ErrorDialog = true;
                    psi.FileName = Path.GetFileNameWithoutExtension(VSpipeEXE);
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo = psi;
                    p.Start();
                    p.WaitForExit();
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
            for(Int32 i = DGV_jobs.Rows.Count - 1; i >= 0; i--)
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
                TempPreset.exe = JobList[DGV_jobs.SelectedRows[0].Index].Encoder;
                TempPreset.args = JobList[DGV_jobs.SelectedRows[0].Index].Subject;
                TempPreset.header = JobList[DGV_jobs.SelectedRows[0].Index].Header;
                LoadScript load = new LoadScript(PresetsFolder, true, JobList[DGV_jobs.SelectedRows[0].Index].VPY, TempPreset);
                load.StartPosition = FormStartPosition.CenterParent;
                if (load.ShowDialog() == DialogResult.OK)
                {
                    Job job = new Job(JobTemp);
                    if (job.HasErrors == false)
                    {
                        JobList.RemoveAt(DGV_jobs.SelectedRows[0].Index);
                        JobList.Insert(DGV_jobs.SelectedRows[0].Index, job);
                        DGV_jobs.Rows[DGV_jobs.SelectedRows[0].Index].SetValues(job.VPY, job.Subject, "Ready", "0");
                    }
                    else
                    {
                        rtb_log.AppendText(job.ErrorMessage);
                        MessageBox.Show("There was one or multiple errors while analizing VPY file.\nTake a look to the log section.");
                    }
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
