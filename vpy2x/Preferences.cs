using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace vpy2x
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void cb_mail_CheckedChanged(object sender, EventArgs e)
        {
            gb_parameters.Enabled = cb_mail.Checked;
        }

        private void ll_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://domar.com/pages/smtp_pop3_server");
        }

        private void applyAndSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
