using System;
using System.IO;
using System.Windows.Forms;

namespace vpy2x
{
    public partial class Preferences : Form
    {

        IniFile iniFile;

        public Preferences()
        {
            InitializeComponent();

            iniFile = new IniFile(vpy2x.SettingsFile);
            if (iniFile.KeyExists("FormWindowState", "Main"))
            {
                if (cmb_formstyle.Text.ToLower().Contains(iniFile.Read("FormWindowState", "Main").ToLower()))
                {
                    cmb_formstyle.Text = iniFile.Read("FormWindowState", "Main");
                }
                else
                {
                    cmb_formstyle.Text = cmb_formstyle.Items[0].ToString();
                }
            }
            else
            {
                cmb_formstyle.SelectedIndex = 0;
            }
            foreach (String s in Directory.GetFiles(vpy2x.PresetsFolder, "*.json*"))
            {
                cmb_default_preset.Items.Add(Path.GetFileNameWithoutExtension(s));
            }
            if (iniFile.KeyExists("DefaultPreset", "Main"))
            {
                if (cmb_default_preset.Items.Contains(iniFile.Read("DefaultPreset", "Main")))
                {
                    cmb_default_preset.Text = iniFile.Read("DefaultPreset", "Main");
                }
                else
                {
                    cmb_default_preset.Text = cmb_default_preset.Items[0].ToString();
                }
            }
            else
            {
                cmb_default_preset.Text = cmb_default_preset.Items[0].ToString();
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        void WriteNewSettings()
        {
            iniFile.Write("FormWindowState", cmb_formstyle.Text, "Main");
            iniFile.Write("DefaultPreset", cmb_default_preset.Text, "Main");
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteNewSettings();
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniFile.DeleteKey("FormWindowState", "Main");
            iniFile.DeleteKey("DefaultPreset", "Main");
        }

        private void applyAndCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteNewSettings();
            this.DialogResult = DialogResult.OK;
        }
    }
}
