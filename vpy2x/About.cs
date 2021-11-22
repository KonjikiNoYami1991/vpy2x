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
using System.Diagnostics;

namespace vpy2x
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            rtb_license.SelectionAlignment = HorizontalAlignment.Center;
            foreach (String s in Directory.GetFiles(Application.StartupPath, "*", SearchOption.AllDirectories))
            {
                if (Path.GetFileNameWithoutExtension(s).ToLower().Contains("license"))
                {
                    rtb_license.Lines = File.ReadAllLines(s);
                }
            }
            if (String.IsNullOrWhiteSpace(rtb_license.Text))
            {
                rtb_license.Text = "License file not found.";
            }
        }

        private void ll_source_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/KonjikiNoYami1991/vpy2x");
        }
    }
}
