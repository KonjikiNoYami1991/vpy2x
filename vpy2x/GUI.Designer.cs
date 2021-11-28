
namespace vpy2x
{
    partial class vpy2x
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVSpipeexePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whenFinishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxShutdown = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DGV_jobs = new System.Windows.Forms.DataGridView();
            this.script = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_pause_resume = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_del = new System.Windows.Forms.Button();
            this.b_move_down = new System.Windows.Forms.Button();
            this.b_move_up = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_new = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.cms_log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveLOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearLOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jobs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cms_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(964, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setVSpipeexePathToolStripMenuItem,
            this.editPresetsToolStripMenuItem,
            this.whenFinishedToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setVSpipeexePathToolStripMenuItem
            // 
            this.setVSpipeexePathToolStripMenuItem.Name = "setVSpipeexePathToolStripMenuItem";
            this.setVSpipeexePathToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setVSpipeexePathToolStripMenuItem.Text = "Set VSpipe.exe path";
            this.setVSpipeexePathToolStripMenuItem.Click += new System.EventHandler(this.setVSpipeexePathToolStripMenuItem_Click);
            // 
            // editPresetsToolStripMenuItem
            // 
            this.editPresetsToolStripMenuItem.Name = "editPresetsToolStripMenuItem";
            this.editPresetsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editPresetsToolStripMenuItem.Text = "Edit presets";
            this.editPresetsToolStripMenuItem.Click += new System.EventHandler(this.editPresetsToolStripMenuItem_Click);
            // 
            // whenFinishedToolStripMenuItem
            // 
            this.whenFinishedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxShutdown});
            this.whenFinishedToolStripMenuItem.Name = "whenFinishedToolStripMenuItem";
            this.whenFinishedToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.whenFinishedToolStripMenuItem.Text = "When finished";
            // 
            // toolStripComboBoxShutdown
            // 
            this.toolStripComboBoxShutdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxShutdown.Items.AddRange(new object[] {
            "Do nothing",
            "Stand-by",
            "Reboot",
            "Shutdown"});
            this.toolStripComboBoxShutdown.Name = "toolStripComboBoxShutdown";
            this.toolStripComboBoxShutdown.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxShutdown.Tag = "Do nothing";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(964, 577);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DGV_jobs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(964, 400);
            this.splitContainer2.SplitterDistance = 788;
            this.splitContainer2.TabIndex = 0;
            // 
            // DGV_jobs
            // 
            this.DGV_jobs.AllowUserToAddRows = false;
            this.DGV_jobs.AllowUserToResizeColumns = false;
            this.DGV_jobs.AllowUserToResizeRows = false;
            this.DGV_jobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_jobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.script,
            this.subject,
            this.status,
            this.fps});
            this.DGV_jobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_jobs.Location = new System.Drawing.Point(0, 0);
            this.DGV_jobs.Name = "DGV_jobs";
            this.DGV_jobs.RowHeadersVisible = false;
            this.DGV_jobs.RowHeadersWidth = 24;
            this.DGV_jobs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_jobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_jobs.Size = new System.Drawing.Size(788, 400);
            this.DGV_jobs.TabIndex = 0;
            // 
            // script
            // 
            this.script.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.script.HeaderText = "VPY";
            this.script.Name = "script";
            this.script.ReadOnly = true;
            this.script.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.script.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.script.Width = 34;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject.DefaultCellStyle = dataGridViewCellStyle3;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fps
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fps.DefaultCellStyle = dataGridViewCellStyle4;
            this.fps.HeaderText = "FPS";
            this.fps.Name = "fps";
            this.fps.ReadOnly = true;
            this.fps.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fps.Width = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_stop);
            this.groupBox1.Controls.Add(this.b_pause_resume);
            this.groupBox1.Controls.Add(this.b_start);
            this.groupBox1.Controls.Add(this.b_reset);
            this.groupBox1.Controls.Add(this.b_del);
            this.groupBox1.Controls.Add(this.b_move_down);
            this.groupBox1.Controls.Add(this.b_move_up);
            this.groupBox1.Controls.Add(this.b_edit);
            this.groupBox1.Controls.Add(this.b_new);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // b_stop
            // 
            this.b_stop.Enabled = false;
            this.b_stop.Location = new System.Drawing.Point(6, 336);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(154, 23);
            this.b_stop.TabIndex = 8;
            this.b_stop.Text = "Abort";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_pause_resume
            // 
            this.b_pause_resume.Enabled = false;
            this.b_pause_resume.Location = new System.Drawing.Point(6, 307);
            this.b_pause_resume.Name = "b_pause_resume";
            this.b_pause_resume.Size = new System.Drawing.Size(154, 23);
            this.b_pause_resume.TabIndex = 7;
            this.b_pause_resume.Text = "Pause/Resume";
            this.b_pause_resume.UseVisualStyleBackColor = true;
            this.b_pause_resume.Click += new System.EventHandler(this.b_pause_resume_Click);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(6, 278);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(154, 23);
            this.b_start.TabIndex = 6;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(6, 106);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(154, 23);
            this.b_reset.TabIndex = 3;
            this.b_reset.Text = "Reset status";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(6, 77);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(154, 23);
            this.b_del.TabIndex = 2;
            this.b_del.Text = "Delete";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // b_move_down
            // 
            this.b_move_down.Location = new System.Drawing.Point(6, 212);
            this.b_move_down.Name = "b_move_down";
            this.b_move_down.Size = new System.Drawing.Size(154, 23);
            this.b_move_down.TabIndex = 5;
            this.b_move_down.Text = "Move down";
            this.b_move_down.UseVisualStyleBackColor = true;
            this.b_move_down.Click += new System.EventHandler(this.b_move_down_Click);
            // 
            // b_move_up
            // 
            this.b_move_up.Location = new System.Drawing.Point(6, 183);
            this.b_move_up.Name = "b_move_up";
            this.b_move_up.Size = new System.Drawing.Size(154, 23);
            this.b_move_up.TabIndex = 4;
            this.b_move_up.Text = "Move up";
            this.b_move_up.UseVisualStyleBackColor = true;
            this.b_move_up.Click += new System.EventHandler(this.b_move_up_Click);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(6, 48);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(154, 23);
            this.b_edit.TabIndex = 1;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_new
            // 
            this.b_new.Location = new System.Drawing.Point(6, 19);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(154, 23);
            this.b_new.TabIndex = 0;
            this.b_new.Text = "New";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 173);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LOG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb_log
            // 
            this.rtb_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_log.ContextMenuStrip = this.cms_log;
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Location = new System.Drawing.Point(3, 3);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(950, 141);
            this.rtb_log.TabIndex = 0;
            this.rtb_log.Text = "";
            // 
            // cms_log
            // 
            this.cms_log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLOGToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearLOGToolStripMenuItem});
            this.cms_log.Name = "cms_log";
            this.cms_log.Size = new System.Drawing.Size(128, 54);
            // 
            // saveLOGToolStripMenuItem
            // 
            this.saveLOGToolStripMenuItem.Name = "saveLOGToolStripMenuItem";
            this.saveLOGToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveLOGToolStripMenuItem.Text = "Save LOG";
            this.saveLOGToolStripMenuItem.Click += new System.EventHandler(this.saveLOGToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // clearLOGToolStripMenuItem
            // 
            this.clearLOGToolStripMenuItem.Name = "clearLOGToolStripMenuItem";
            this.clearLOGToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearLOGToolStripMenuItem.Text = "Clear LOG";
            this.clearLOGToolStripMenuItem.Click += new System.EventHandler(this.clearLOGToolStripMenuItem_Click);
            // 
            // vpy2x
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(980, 640);
            this.Name = "vpy2x";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vpy2x v1.0.2 BETA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vpy2x_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.vpy2x_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.vpy2x_DragEnter);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jobs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cms_log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_move_down;
        private System.Windows.Forms.Button b_move_up;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button b_pause_resume;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVSpipeexePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPresetsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.DataGridView DGV_jobs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem whenFinishedToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxShutdown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn script;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn fps;
        private System.Windows.Forms.ContextMenuStrip cms_log;
        private System.Windows.Forms.ToolStripMenuItem saveLOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearLOGToolStripMenuItem;
    }
}

