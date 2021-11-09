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
using System.Diagnostics;

namespace vpy2x
{
    public partial class LoadScript : Form
    {

        String PresetFolder = String.Empty;
        List<String> PresetSections = new List<String>();
        Process p;
        ProcessStartInfo psi;

        public LoadScript(String PresetFolder, String VSpipeEXE)
        {
            InitializeComponent();

            tb_args_load_script.MaxLength = Int32.MaxValue;

            this.PresetFolder = PresetFolder;
            cmb_header_load_script.Text = cmb_header_load_script.Items[0].ToString();
            if (Directory.Exists(this.PresetFolder))
            {
                foreach (String s in Directory.GetFiles(PresetFolder))
                {
                    if (Path.GetExtension(s).ToLower() == ".json")
                        cmb_presets_load_script.Items.Add(Path.GetFileNameWithoutExtension(s));
                }
                if (cmb_presets_load_script.Items.Count > 0)
                {
                    cmb_presets_load_script.Sorted = true;
                    cmb_presets_load_script.Text = cmb_presets_load_script.Items[0].ToString();
                    ReadPreset(Path.Combine(PresetFolder, cmb_presets_load_script.Text + ".json"));
                }
            }
        }
        void ReadPreset(String File)
        {
            Preset p = JsonConvert.DeserializeObject<Preset>(System.IO.File.ReadAllText(File));
            tb_args_load_script.Text = p.args;
            tb_exe_load_script.Text = p.exe;
            cmb_header_load_script.Text = p.header;
        }
        struct Preset
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

        }
    }
}
