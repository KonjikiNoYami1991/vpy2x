using MediaInfoDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace vpy2x
{
    public partial class Audio : Form
    {

        public TreeNode AudioTracks = new TreeNode();

        public Audio(TreeNode AudioSource)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            l_file.Text = "File: \"" + AudioSource.Text + "\"";
            ReadNodes(AudioSource);
            AudioTracks = AudioSource;
        }

        private void DGV_audiotracks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Clipboard.ContainsText() == false)
                {
                    pasteCLIToolStripMenuItem.Enabled = false;
                }
                else
                {
                    pasteCLIToolStripMenuItem.Enabled = true;
                }
            }
        }

        void ReadNodes(TreeNode node)
        {
            for (Int32 i = 0; i < node.Nodes.Count; i++)
            {
                List<String> temp = new List<String>();
                for (Int32 j = 0; j < node.Nodes[i].Nodes.Count; j++)
                {
                    temp.Add(node.Nodes[i].Nodes[j].Text.Split(':')[1].Trim());
                }
                DGV_audiotracks.Rows.Add(temp.ToArray());
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void b_done_Click(object sender, EventArgs e)
        {
            AudioTracks = new TreeNode(l_file.Text.Split('"')[1].Trim());
            Int32 i = 0;
            foreach (DataGridViewRow d in DGV_audiotracks.Rows)
            {
                AudioTracks.Nodes.Add("Audio track " + i.ToString());
                AudioTracks.Nodes[i].Nodes.Add("Encode: " + d.Cells["encode"].Value.ToString());
                AudioTracks.Nodes[i].Nodes.Add("ID: " + d.Cells["id"].Value.ToString().Trim());
                AudioTracks.Nodes[i].Nodes.Add("Codec: " + d.Cells["codec"].Value.ToString().Trim());
                AudioTracks.Nodes[i].Nodes.Add("Language: " + d.Cells["lang"].Value.ToString().Trim());
                AudioTracks.Nodes[i].Nodes.Add("CLI: " + d.Cells["cli"].Value.ToString().Trim());
                i++;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void tb_cli_TextChanged(object sender, EventArgs e)
        {
            if (DGV_audiotracks.SelectedRows.Count > 0)
            {
                DGV_audiotracks.SelectedRows[0].Cells["cli"].Value = tb_cli.Text;
            }
        }

        private void DGV_audiotracks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(DGV_audiotracks.Rows[e.RowIndex].Cells["cli"].Value.ToString()))
            {
                tb_cli.Clear();
                DGV_audiotracks.Rows[e.RowIndex].Cells["cli"].Value = String.Empty;
            }
            else
            {
                tb_cli.Text = DGV_audiotracks.Rows[e.RowIndex].Cells["cli"].Value.ToString();
            }
        }

        private void b_pl_audio_source_Click(object sender, EventArgs e)
        {
            tb_cli.Text = tb_cli.Text.Insert(tb_cli.SelectionStart, "%%input%%");
        }

        private void b_pl_audio_id_Click(object sender, EventArgs e)
        {
            tb_cli.Text = tb_cli.Text.Insert(tb_cli.SelectionStart, "%%id%%");
        }

        private void b_pl_audio_output_Click(object sender, EventArgs e)
        {
            tb_cli.Text = tb_cli.Text.Insert(tb_cli.SelectionStart, "%%output%%");
        }

        private void ll_pl_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Audio input -> %%input%% (input file path including extension)\rAudio track ID -> %%id%% (ID of selected audio track)\rAudio output -> %%output%% (the same path of input file without extension)", "Placeholders' help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
