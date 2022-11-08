namespace vpy2x
{
    partial class Audio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_audiotracks = new System.Windows.Forms.DataGridView();
            this.encode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightclick_tracklist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_cli = new System.Windows.Forms.TextBox();
            this.l_file = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_pl_audio_source = new System.Windows.Forms.Button();
            this.b_pl_audio_id = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.b_pl_audio_output = new System.Windows.Forms.Button();
            this.ll_pl_help = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_audiotracks)).BeginInit();
            this.rightclick_tracklist.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_audiotracks);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio tracks";
            // 
            // DGV_audiotracks
            // 
            this.DGV_audiotracks.AllowUserToAddRows = false;
            this.DGV_audiotracks.AllowUserToDeleteRows = false;
            this.DGV_audiotracks.AllowUserToResizeColumns = false;
            this.DGV_audiotracks.AllowUserToResizeRows = false;
            this.DGV_audiotracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_audiotracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.encode,
            this.id,
            this.codec,
            this.lang,
            this.cli});
            this.DGV_audiotracks.ContextMenuStrip = this.rightclick_tracklist;
            this.DGV_audiotracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_audiotracks.Location = new System.Drawing.Point(3, 16);
            this.DGV_audiotracks.Name = "DGV_audiotracks";
            this.DGV_audiotracks.RowHeadersWidth = 30;
            this.DGV_audiotracks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_audiotracks.Size = new System.Drawing.Size(702, 263);
            this.DGV_audiotracks.TabIndex = 0;
            this.DGV_audiotracks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_audiotracks_RowHeaderMouseClick);
            this.DGV_audiotracks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_audiotracks_MouseClick);
            // 
            // encode
            // 
            this.encode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.encode.HeaderText = "Encode";
            this.encode.Items.AddRange(new object[] {
            "Yes",
            "Copy",
            "No"});
            this.encode.Name = "encode";
            this.encode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.encode.Width = 50;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 24;
            // 
            // codec
            // 
            this.codec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codec.HeaderText = "Codec";
            this.codec.Name = "codec";
            this.codec.ReadOnly = true;
            this.codec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codec.Width = 44;
            // 
            // lang
            // 
            this.lang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lang.HeaderText = "Language";
            this.lang.Name = "lang";
            this.lang.ReadOnly = true;
            this.lang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lang.Width = 61;
            // 
            // cli
            // 
            this.cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cli.HeaderText = "CLI";
            this.cli.Name = "cli";
            this.cli.ReadOnly = true;
            this.cli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cli.Width = 29;
            // 
            // rightclick_tracklist
            // 
            this.rightclick_tracklist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCLIToolStripMenuItem,
            this.pasteCLIToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectToolStripMenuItem});
            this.rightclick_tracklist.Name = "rightclick_tracklist";
            this.rightclick_tracklist.Size = new System.Drawing.Size(123, 76);
            // 
            // copyCLIToolStripMenuItem
            // 
            this.copyCLIToolStripMenuItem.Name = "copyCLIToolStripMenuItem";
            this.copyCLIToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyCLIToolStripMenuItem.Text = "Copy CLI";
            // 
            // pasteCLIToolStripMenuItem
            // 
            this.pasteCLIToolStripMenuItem.Name = "pasteCLIToolStripMenuItem";
            this.pasteCLIToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteCLIToolStripMenuItem.Text = "Paste CLI";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.noneToolStripMenuItem,
            this.reverseSelectionToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // reverseSelectionToolStripMenuItem
            // 
            this.reverseSelectionToolStripMenuItem.Name = "reverseSelectionToolStripMenuItem";
            this.reverseSelectionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reverseSelectionToolStripMenuItem.Text = "Reverse selection";
            // 
            // tb_cli
            // 
            this.tb_cli.Location = new System.Drawing.Point(12, 354);
            this.tb_cli.Multiline = true;
            this.tb_cli.Name = "tb_cli";
            this.tb_cli.Size = new System.Drawing.Size(546, 124);
            this.tb_cli.TabIndex = 3;
            this.tb_cli.TextChanged += new System.EventHandler(this.tb_cli_TextChanged);
            // 
            // l_file
            // 
            this.l_file.AutoSize = true;
            this.l_file.Location = new System.Drawing.Point(12, 9);
            this.l_file.Name = "l_file";
            this.l_file.Size = new System.Drawing.Size(35, 13);
            this.l_file.TabIndex = 4;
            this.l_file.Text = "label1";
            // 
            // b_cancel
            // 
            this.b_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(645, 484);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 26;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_done
            // 
            this.b_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_done.Location = new System.Drawing.Point(564, 484);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(75, 23);
            this.b_done.TabIndex = 25;
            this.b_done.Text = "Done";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Command line";
            // 
            // b_pl_audio_source
            // 
            this.b_pl_audio_source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pl_audio_source.Location = new System.Drawing.Point(564, 370);
            this.b_pl_audio_source.Name = "b_pl_audio_source";
            this.b_pl_audio_source.Size = new System.Drawing.Size(156, 23);
            this.b_pl_audio_source.TabIndex = 28;
            this.b_pl_audio_source.Text = "Audio input";
            this.b_pl_audio_source.UseVisualStyleBackColor = true;
            this.b_pl_audio_source.Click += new System.EventHandler(this.b_pl_audio_source_Click);
            // 
            // b_pl_audio_id
            // 
            this.b_pl_audio_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pl_audio_id.Location = new System.Drawing.Point(564, 399);
            this.b_pl_audio_id.Name = "b_pl_audio_id";
            this.b_pl_audio_id.Size = new System.Drawing.Size(156, 23);
            this.b_pl_audio_id.TabIndex = 29;
            this.b_pl_audio_id.Text = "Audio track ID";
            this.b_pl_audio_id.UseVisualStyleBackColor = true;
            this.b_pl_audio_id.Click += new System.EventHandler(this.b_pl_audio_id_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Placeholders";
            // 
            // b_pl_audio_output
            // 
            this.b_pl_audio_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pl_audio_output.Location = new System.Drawing.Point(564, 428);
            this.b_pl_audio_output.Name = "b_pl_audio_output";
            this.b_pl_audio_output.Size = new System.Drawing.Size(156, 23);
            this.b_pl_audio_output.TabIndex = 31;
            this.b_pl_audio_output.Text = "Audio output";
            this.b_pl_audio_output.UseVisualStyleBackColor = true;
            this.b_pl_audio_output.Click += new System.EventHandler(this.b_pl_audio_output_Click);
            // 
            // ll_pl_help
            // 
            this.ll_pl_help.AutoSize = true;
            this.ll_pl_help.Location = new System.Drawing.Point(691, 354);
            this.ll_pl_help.Name = "ll_pl_help";
            this.ll_pl_help.Size = new System.Drawing.Size(29, 13);
            this.ll_pl_help.TabIndex = 32;
            this.ll_pl_help.TabStop = true;
            this.ll_pl_help.Text = "Help";
            this.ll_pl_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_pl_help_LinkClicked);
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 519);
            this.Controls.Add(this.ll_pl_help);
            this.Controls.Add(this.b_pl_audio_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_pl_audio_id);
            this.Controls.Add(this.b_pl_audio_source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_done);
            this.Controls.Add(this.l_file);
            this.Controls.Add(this.tb_cli);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Audio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audio";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_audiotracks)).EndInit();
            this.rightclick_tracklist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_audiotracks;
        private System.Windows.Forms.TextBox tb_cli;
        private System.Windows.Forms.ContextMenuStrip rightclick_tracklist;
        private System.Windows.Forms.ToolStripMenuItem copyCLIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCLIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseSelectionToolStripMenuItem;
        private System.Windows.Forms.Label l_file;
        private System.Windows.Forms.DataGridViewComboBoxColumn encode;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codec;
        private System.Windows.Forms.DataGridViewTextBoxColumn lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_pl_audio_source;
        private System.Windows.Forms.Button b_pl_audio_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_pl_audio_output;
        private System.Windows.Forms.LinkLabel ll_pl_help;
    }
}