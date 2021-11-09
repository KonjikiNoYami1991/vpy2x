using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using Newtonsoft.Json;

namespace vpy2x
{
    public partial class EditPresets : Form
    {

        String PresetFolder = String.Empty;
        List<String> PresetSections = new List<String>();

        public EditPresets(String PresetFolder)
        {
            InitializeComponent();

            tb_args_edit_presets.MaxLength = Int32.MaxValue;

            this.PresetFolder = PresetFolder;
            cmb_header_edit_presets.Text = cmb_header_edit_presets.Items[0].ToString();
            if (Directory.Exists(this.PresetFolder))
            {
                foreach (String s in Directory.GetFiles(PresetFolder))
                {
                    if (Path.GetExtension(s).ToLower() == ".json")
                        cmb_edit_presets.Items.Add(Path.GetFileNameWithoutExtension(s));
                }
                if (cmb_edit_presets.Items.Count > 0)
                {
                    cmb_edit_presets.Sorted = true;
                    cmb_edit_presets.Text = cmb_edit_presets.Items[0].ToString();
                    ReadPreset(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json"));
                }
            }
        }

        void ReadPreset(String File)
        {
            Preset p = JsonConvert.DeserializeObject<Preset>(System.IO.File.ReadAllText(File));
            tb_args_edit_presets.Text = p.args;
            tb_exe_edit_presets.Text = p.exe;
            cmb_header_edit_presets.Text = p.header;
        }

        private void b_save_edit_presets_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmb_edit_presets.Text) == false && cmb_edit_presets.Text.IndexOfAny(Path.GetInvalidPathChars()) == -1)
            {
                WritePreset(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json"));
                if (cmb_edit_presets.Items.Contains(cmb_edit_presets.Text) == false)
                    cmb_edit_presets.Items.Add(cmb_edit_presets.Text);
            }
            else
                MessageBox.Show("Preset must have a valid name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void WritePreset(String JsonFile)
        {
            Preset p = new Preset();
            p.args = tb_args_edit_presets.Text;
            p.exe = tb_exe_edit_presets.Text;
            p.header = cmb_header_edit_presets.Text;
            File.WriteAllText(JsonFile, JsonConvert.SerializeObject(p, Formatting.Indented));
        }

        private void b_browse_exe_edit_presets_Click(object sender, EventArgs e)
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
                tb_exe_edit_presets.Text = o.FileName;
            }
        }

        private void cmb_presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json")))
            {
                ReadPreset(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json"));
            }
        }

        private void b_del_edit_presets_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json"));
            cmb_edit_presets.Items.RemoveAt(cmb_edit_presets.SelectedIndex);
            if (cmb_edit_presets.Items.Count > 0)
            {
                cmb_edit_presets.Text = cmb_edit_presets.Items[0].ToString();
                ReadPreset(Path.Combine(PresetFolder, cmb_edit_presets.Text + ".json"));
            }
        }

        struct Preset
        {
            public String exe { get; set; }
            public String args { get; set; }
            public String header { get; set; }
        }

        private void b_fr_num_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{fpsn}");
        }

        private void b_fr_denom_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{fpsd}");
        }

        private void b_bitdepth_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{bits}");
        }

        private void b_fr_as_fraction_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{fps}");
        }

        private void b_dir_script_path_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{sd}");
        }

        private void b_script_name_no_ext_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{sn}");
        }

        private void b_subsampl_string_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{ss}");
        }

        private void b_width_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{w}");
        }

        private void b_height_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{h}");
        }

        private void b_num_frames_edit_presets_Click(object sender, EventArgs e)
        {
            tb_args_edit_presets.Paste("{f}");
        }
    }
}
