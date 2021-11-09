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
                        cmb_presets.Items.Add(Path.GetFileNameWithoutExtension(s));
                }
                if (cmb_presets.Items.Count > 0)
                {
                    cmb_presets.Text = cmb_presets.Items[0].ToString();
                    ReadPreset(Path.Combine(PresetFolder, cmb_presets.Text + ".json"));
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
            if (String.IsNullOrWhiteSpace(cmb_presets.Text) == false)
            {
                WritePreset(Path.Combine(PresetFolder, cmb_presets.Text + ".json"));
                if (cmb_presets.Items.Contains(cmb_presets.Text))
                    cmb_presets.Items.Add(cmb_presets.Text);
            }
            else
                MessageBox.Show("Preset must have a name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (File.Exists(Path.Combine(PresetFolder, cmb_presets.Text + ".json")))
            {
                ReadPreset(Path.Combine(PresetFolder, cmb_presets.Text + ".json"));
            }
        }

        private void b_del_edit_presets_Click(object sender, EventArgs e)
        {
            cmb_presets.Items.RemoveAt(cmb_presets.SelectedIndex);
            cmb_presets.Update();
            File.Delete(Path.Combine(PresetFolder, cmb_presets.Text + ".json"));
        }

        struct Preset
        {
            public String exe { get; set; }
            public String args { get; set; }
            public String header { get; set; }
        }
    }
}
