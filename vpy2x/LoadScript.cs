using MediaInfoDotNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace vpy2x
{
    public partial class LoadScript : Form
    {
        IniFile iniFile;
        String PresetFolder = String.Empty;
        List<String> PresetSections = new List<String>();
        Process p;
        ProcessStartInfo psi;
        Preset TempPreset;
        Boolean Edit = false;
        String TempVPY = String.Empty;
        String TempVPY4Scenes = String.Empty;

        Boolean NodeClick = false;

        public static readonly String[] AudioEXT = { ".aac", ".m4a", ".flac", ".mp3", ".wav", ".ogg", ".opus", ".tta", ".mka", ".mp2", ".ac3", ".dts", ".thd", ".mkv", ".mp4", ".m2ts", ".ts", ".avi", ".vob", ".mpg", ".mpeg", ".flv", ".mov", ".wmv" };

        public Dictionary<String, String> ScriptInfo = new Dictionary<String, String>();

        public LoadScript(String PresetFolder, Boolean Edit, String TempVPY, Preset TempPreset, String TempVPY4Scenes, List<TreeNode> AudioTracks)
        {
            InitializeComponent();

            num_end_frame.Maximum = Int32.MaxValue;
            num_start_frame.Maximum = Int32.MaxValue;

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            tb_args_load_script.MaxLength = Int32.MaxValue;

            this.TempPreset = TempPreset;

            this.PresetFolder = PresetFolder;

            this.TempVPY4Scenes = TempVPY4Scenes;

            iniFile = new IniFile(vpy2x.SettingsFile);

            cmb_header_load_script.Text = cmb_header_load_script.Items[0].ToString();
            if (Edit == true)
            {
                this.Edit = Edit;
                cmb_presets_load_script.Items.Add(String.Empty);
                tb_args_load_script.Text = TempPreset.args;
                tb_exe_load_script.Text = TempPreset.exe;
                tb_vpy.Text = this.TempVPY = TempVPY;
                tb_vpy_av.Text = this.TempVPY4Scenes = TempVPY4Scenes;
                if (String.IsNullOrWhiteSpace(TempPreset.header) == false)
                    cmb_header_load_script.Text = TempPreset.header.ToUpper().Replace("--", String.Empty).Trim();
                else
                    cmb_header_load_script.Text = cmb_header_load_script.Items[0].ToString();
                tv_audiotracks.Nodes.Clear();
                foreach (TreeNode t in AudioTracks)
                {
                    tv_audiotracks.Nodes.Remove(t);
                    tv_audiotracks.Nodes.Add(t);
                }
            }
            if (String.IsNullOrWhiteSpace(TempVPY) == false)
            {
                tb_vpy.Text = TempVPY;
                if (Edit == false)
                    b_skip.Visible = true;
            }
            if (Directory.Exists(this.PresetFolder))
            {
                foreach (String s in Directory.GetFiles(PresetFolder))
                {
                    if (Path.GetExtension(s).ToLower() == ".json")
                        cmb_presets_load_script.Items.Add(Path.GetFileNameWithoutExtension(s));
                }
                if (cmb_presets_load_script.Items.Count > 0 && Edit == false)
                {
                    cmb_presets_load_script.Sorted = true;
                    cmb_presets_load_script.Text = cmb_presets_load_script.Items[0].ToString();
                    ReadPreset(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
                    if (iniFile.KeyExists("DefaultPreset", "Main"))
                    {
                        if (cmb_presets_load_script.Items.Contains(iniFile.Read("DefaultPreset", "Main")))
                        {
                            cmb_presets_load_script.Text = iniFile.Read("DefaultPreset", "Main");
                        }
                        else
                        {
                            cmb_presets_load_script.Text = cmb_presets_load_script.Items[0].ToString();
                        }
                    }
                    else
                    {
                        cmb_presets_load_script.Text = cmb_presets_load_script.Items[0].ToString();
                    }
                }
            }
        }

        void ReadPreset(String File)
        {
            if (System.IO.File.Exists(File))
            {
                Preset p = JsonConvert.DeserializeObject<Preset>(System.IO.File.ReadAllText(File));
                tb_args_load_script.Text = p.args;
                tb_exe_load_script.Text = p.exe;
                cmb_header_load_script.Text = p.header;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(File))
                {
                    tb_args_load_script.Text = TempPreset.args;
                    tb_exe_load_script.Text = TempPreset.exe;
                    cmb_header_load_script.Text = TempPreset.header;
                }
            }
        }
        public struct Preset
        {
            public String exe { get; set; }
            public String args { get; set; }
            public String header { get; set; }
        }

        private void b_save_load_script_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmb_presets_load_script.Text) == false && cmb_presets_load_script.Text.IndexOfAny(Path.GetInvalidPathChars()) == -1)
            {
                WritePreset(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
                if (cmb_presets_load_script.Items.Contains(cmb_presets_load_script.Text) == false)
                    cmb_presets_load_script.Items.Add(cmb_presets_load_script.Text);
            }
            else
                MessageBox.Show("Preset must have a valid name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void WritePreset(String JsonFile)
        {
            Preset p = new Preset();
            p.args = tb_args_load_script.Text;
            p.exe = tb_exe_load_script.Text;
            p.header = cmb_header_load_script.Text;
            File.WriteAllText(JsonFile, JsonConvert.SerializeObject(p, Formatting.Indented));
        }

        private void b_exe_load_script_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "EXE files|*.exe;*.EXE";
            o.Title = "Set the path for the encoder's executable file";
            o.InitialDirectory = Application.StartupPath;
            o.DefaultExt = "exe";
            o.Multiselect = false;
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_exe_load_script.Text = o.FileName;
            }
        }

        private void cmb_presets_load_script_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json")))
            {
                ReadPreset(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
            }
            else
            {
                tb_args_load_script.Text = TempPreset.args;
                tb_exe_load_script.Text = TempPreset.exe;
                tb_vpy.Text = TempVPY;
                if (String.IsNullOrWhiteSpace(TempPreset.header) == false)
                    cmb_header_load_script.Text = TempPreset.header.ToUpper().Replace("--", String.Empty).Trim();
                else
                    cmb_header_load_script.Text = cmb_header_load_script.Items[0].ToString();
            }
        }

        private void b_del_load_script_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
            cmb_presets_load_script.Items.RemoveAt(cmb_presets_load_script.SelectedIndex);
            if (cmb_presets_load_script.Items.Count > 0)
            {
                cmb_presets_load_script.Text = cmb_presets_load_script.Items[0].ToString();
                ReadPreset(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
            }
        }

        private void b_grab_num_frames_Click(object sender, EventArgs e)
        {
            p = new Process();
            psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.Arguments = " --info \"" + tb_vpy.Text + "\" -";
            psi.ErrorDialog = true;
            psi.FileName = Path.GetFileNameWithoutExtension(vpy2x.VSpipeEXE);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
            switch (p.ExitCode)
            {
                case 0:
                    //MessageBox.Show(p.StandardOutput.ReadToEnd(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String[] temp = p.StandardOutput.ReadToEnd().Trim().Split(new String[] { "\r", "\n" }, StringSplitOptions.None);

                    ScriptInfo = new Dictionary<string, string>();
                    foreach (String s in temp)
                    {
                        ScriptInfo.Add(s.Split(':')[0].Trim(), s.Split(':')[1].Trim());
                    }
                    num_end_frame.Maximum = Convert.ToInt32(ScriptInfo["Frames"]) - 1;
                    num_end_frame.Value = num_end_frame.Maximum;
                    num_start_frame.Maximum = num_end_frame.Maximum - 1;

                    break;
                default:
                    MessageBox.Show(p.StandardError.ReadToEnd(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void b_load_script_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "VPY files|*.vpy;*.VPY";
            o.Title = "Set the VPY file.";
            o.DefaultExt = "vpy";
            o.Multiselect = false;
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_vpy.Text = o.FileName;
            }
        }

        private void b_framerate_num_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{fpsn}");
        }

        private void b_framerate_denom_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{fpsd}");
        }

        private void b_bitdepth_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{bits}");
        }

        private void b_framerate_fraction_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{fps}");
        }

        private void b_dir_script_path_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{sd}");
        }

        private void b_script_name_no_ext_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{sn}");
        }

        private void b_subsampling_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{ss}");
        }

        private void b_width_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{w}");
        }

        private void b_height_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{h}");
        }

        private void b_num_frames_load_script_Click(object sender, EventArgs e)
        {
            tb_args_load_script.Paste("{f}");
        }

        private void b_done_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_vpy.Text) == false && String.IsNullOrWhiteSpace(tb_exe_load_script.Text) == false && String.IsNullOrWhiteSpace(tb_args_load_script.Text) == false)
            {
                vpy2x.JobTemp = new Dictionary<String, String>();
                vpy2x.JobTemp.Add("VPY", tb_vpy.Text);
                vpy2x.JobTemp.Add("Subject", tb_args_load_script.Text);
                vpy2x.JobTemp.Add("Encoder", tb_exe_load_script.Text);
                if (cmb_header_load_script.SelectedItem.ToString().ToLower().StartsWith("no") == false)
                    vpy2x.JobTemp.Add("Header", " --" + cmb_header_load_script.Text.Trim().ToLower());
                else
                    vpy2x.JobTemp.Add("Header", String.Empty);
                if (num_end_frame.Value > 0)
                {
                    vpy2x.JobTemp.Add("End", " --end " + num_end_frame.Value.ToString());
                }
                else
                    vpy2x.JobTemp.Add("End", String.Empty);
                if (num_start_frame.Value > 0)
                {
                    vpy2x.JobTemp.Add("Start", " --start " + num_start_frame.Value.ToString());
                }
                else
                    vpy2x.JobTemp.Add("Start", String.Empty);
                if (String.IsNullOrWhiteSpace(tb_vpy_av.Text) == false)
                    vpy2x.JobTemp.Add("Scene detection", tb_vpy_av.Text);
                else
                    vpy2x.JobTemp.Add("Scene detection", String.Empty);
                foreach (TreeNode t in tv_audiotracks.Nodes)
                {
                    vpy2x.AudioTracks.Add(t);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Script, arguments and encoder's executable must be set.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ll_help_placeholders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String Help = "{fpsn} -> Framerate numerator.\n";
            Help += "{fpsd} -> Framerate denominator.\n";
            Help += "{bits} -> Color bitdepth.\n";
            Help += "{fps} -> Framerate as fraction.\n";
            Help += "{sd} -> Script directory.\n";
            Help += "{sn} -> Script filename without extension.\n";
            Help += "{ss} -> Subsampling string (ex. \"yuv420p\").\n";
            Help += "{w} -> Width.\n";
            Help += "{h} -> Height.\n";
            Help += "{f} -> Total number of frames.";
            MessageBox.Show(Help, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void b_skip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void tb_vpy_DragEnter(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy")
                {
                    e.Effect = DragDropEffects.Copy;
                    break;
                }
            }
        }

        private void tb_vpy_DragDrop(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy")
                {
                    tb_vpy.Text = s;
                }
            }
        }

        private void b_load_script_av_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "VPY files|*.vpy;*.VPY|Text file|*.txt;*.TXT";
            o.Title = "Set the VPY file for scenes detection only.";
            o.Multiselect = false;
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_vpy_av.Text = o.FileName;
            }
        }

        private void tb_vpy_av_DragEnter(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy" || Path.GetExtension(s).ToLower() == ".txt")
                {
                    e.Effect = DragDropEffects.Copy;
                    break;
                }
            }
        }

        private void tb_vpy_av_DragDrop(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])(e.Data.GetData(DataFormats.FileDrop)))
            {
                if (Path.GetExtension(s).ToLower() == ".vpy" || Path.GetExtension(s).ToLower() == ".txt")
                {
                    tb_vpy_av.Text = s;
                    break;
                }
            }
        }

        private void b_audio_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.FilterIndex = 1;
            o.Multiselect = true;
            o.RestoreDirectory = true;
            o.Filter = "All supported files|";
            foreach (String s in LoadScript.AudioEXT)
            {
                o.Filter += "*" + s.ToLower() + ";*" + s.ToUpper() + ";";
            }
            foreach (String s in LoadScript.AudioEXT)
            {
                o.Filter += "|" + s.ToUpper().Replace(".", String.Empty) + " file|*" + s.ToLower() + ";*" + s.ToUpper();
            }
            o.Filter += "|All files|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                foreach (String s in o.FileNames)
                    GetAudioTracks(s);
            }
        }

        private void tv_audio_DragDrop(object sender, DragEventArgs e)
        {
            foreach (String s in (String[])e.Data.GetData(DataFormats.FileDrop))
            {
                GetAudioTracks(s);
            }
        }

        void GetAudioTracks(String File)
        {
            MediaFile m = new MediaFile(File);
            if (m.HasStreams == true)
            {
                Int32 i = 0;
                TreeNode tnf = new TreeNode(File);
                tnf.Name = "Source " + i.ToString();
                foreach (MediaInfoDotNet.Models.AudioStream audio in m.Audio)
                {
                    tnf.Nodes.Add("Audio track " + (i + 1).ToString());
                    tnf.Nodes[i].Nodes.Add("Encode: Copy");
                    if (m.Video.Count > 0)
                    {
                        tnf.Nodes[i].Nodes.Add(("ID: " + (audio.ID - 1).ToString()).Trim());
                    }
                    else
                    {
                        if (Path.GetExtension(m.filePath).ToLower() == ".mka")
                        {
                            tnf.Nodes[i].Nodes.Add(("ID: " + audio.ID.ToString().Trim()));
                        }
                        else
                        {
                            tnf.Nodes[i].Nodes.Add(("ID: " + i.ToString().Trim()));
                        }
                    }
                    tnf.Nodes[i].Nodes.Add(("Codec: " + audio.Format).Trim());
                    tnf.Nodes[i].Nodes.Add(("Language: " + audio.Language).Trim());
                    tnf.Nodes[i].Nodes.Add(("CLI: " + String.Empty).Trim());
                    i++;
                }

                tv_audiotracks.Nodes.Add(tnf);
            }
        }

        private void tv_audio_DragEnter(object sender, DragEventArgs e)
        {
            var Data = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (String s in Data)
            {
                if (LoadScript.AudioEXT.Contains(Path.GetExtension(s).ToLower()))
                {
                    e.Effect = DragDropEffects.Copy;
                    break;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void tv_audiotracks_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Parent == null)
                {
                    Audio a = new Audio(e.Node);
                    if (a.ShowDialog() == DialogResult.OK)
                    {
                        tv_audiotracks.Nodes.RemoveAt(e.Node.Index);
                        tv_audiotracks.Nodes.Insert(e.Node.Index, a.AudioTracks);
                    }
                }
            }
        }

        private void b_expand_tv_Click(object sender, EventArgs e)
        {
            tv_audiotracks.ExpandAll();
        }

        private void b_collapse_tv_Click(object sender, EventArgs e)
        {
            tv_audiotracks.CollapseAll();
        }

        private void b_remove_audiosource_Click(object sender, EventArgs e)
        {
            foreach (TreeNode t in tv_audiotracks.Nodes)
            {
                if (t.IsSelected)
                {
                    tv_audiotracks.Nodes.Remove(t);
                }
            }
            for (Int32 i = 0; i < tv_audiotracks.Nodes.Count; i++)
            {
                tv_audiotracks.Nodes[i].Name = "Source " + i.ToString();
            }
        }
    }
}
