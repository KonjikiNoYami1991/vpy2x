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

namespace vpy2x
{
    public partial class vpy2x : Form
    {

        readonly String PresetsFolder = Path.Combine(Application.StartupPath, "presets");
        readonly String SettingsFile = Path.Combine(Application.StartupPath, "settings.ini");
        String VSpipeEXE = String.Empty;

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
    }

    public struct Job
    {
        String EXE { get; set; }
        String Header { get; set; }
        String Args { get; set; }
        String VPY { get; set; }
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
