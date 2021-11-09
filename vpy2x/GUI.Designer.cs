﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVSpipeexePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.editPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setVSpipeexePathToolStripMenuItem,
            this.editPresetsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setVSpipeexePathToolStripMenuItem
            // 
            this.setVSpipeexePathToolStripMenuItem.Name = "setVSpipeexePathToolStripMenuItem";
            this.setVSpipeexePathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setVSpipeexePathToolStripMenuItem.Text = "Set VSpipe.exe path";
            this.setVSpipeexePathToolStripMenuItem.Click += new System.EventHandler(this.setVSpipeexePathToolStripMenuItem_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(932, 571);
            this.splitContainer1.SplitterDistance = 425;
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
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(932, 425);
            this.splitContainer2.SplitterDistance = 756;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.subject,
            this.state,
            this.fps});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 425);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.Width = 530;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.Width = 101;
            // 
            // fps
            // 
            this.fps.Text = "FPS";
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
            this.groupBox1.Size = new System.Drawing.Size(172, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // b_stop
            // 
            this.b_stop.Location = new System.Drawing.Point(6, 336);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(154, 23);
            this.b_stop.TabIndex = 8;
            this.b_stop.Text = "Abort";
            this.b_stop.UseVisualStyleBackColor = true;
            // 
            // b_pause_resume
            // 
            this.b_pause_resume.Location = new System.Drawing.Point(6, 307);
            this.b_pause_resume.Name = "b_pause_resume";
            this.b_pause_resume.Size = new System.Drawing.Size(154, 23);
            this.b_pause_resume.TabIndex = 7;
            this.b_pause_resume.Text = "Pause/Resume";
            this.b_pause_resume.UseVisualStyleBackColor = true;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(6, 278);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(154, 23);
            this.b_start.TabIndex = 6;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(6, 106);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(154, 23);
            this.b_reset.TabIndex = 3;
            this.b_reset.Text = "Reset state";
            this.b_reset.UseVisualStyleBackColor = true;
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(6, 77);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(154, 23);
            this.b_del.TabIndex = 2;
            this.b_del.Text = "Delete";
            this.b_del.UseVisualStyleBackColor = true;
            // 
            // b_move_down
            // 
            this.b_move_down.Location = new System.Drawing.Point(6, 212);
            this.b_move_down.Name = "b_move_down";
            this.b_move_down.Size = new System.Drawing.Size(154, 23);
            this.b_move_down.TabIndex = 5;
            this.b_move_down.Text = "Move down";
            this.b_move_down.UseVisualStyleBackColor = true;
            // 
            // b_move_up
            // 
            this.b_move_up.Location = new System.Drawing.Point(6, 183);
            this.b_move_up.Name = "b_move_up";
            this.b_move_up.Size = new System.Drawing.Size(154, 23);
            this.b_move_up.TabIndex = 4;
            this.b_move_up.Text = "Move up";
            this.b_move_up.UseVisualStyleBackColor = true;
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(6, 48);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(154, 23);
            this.b_edit.TabIndex = 1;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            // 
            // b_new
            // 
            this.b_new.Location = new System.Drawing.Point(6, 19);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(154, 23);
            this.b_new.TabIndex = 0;
            this.b_new.Text = "New";
            this.b_new.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 142);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LOG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editPresetsToolStripMenuItem
            // 
            this.editPresetsToolStripMenuItem.Name = "editPresetsToolStripMenuItem";
            this.editPresetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editPresetsToolStripMenuItem.Text = "Edit presets";
            this.editPresetsToolStripMenuItem.Click += new System.EventHandler(this.editPresetsToolStripMenuItem_Click);
            // 
            // vpy2x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "vpy2x";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vpy2x";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_move_down;
        private System.Windows.Forms.Button b_move_up;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader fps;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button b_pause_resume;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVSpipeexePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPresetsToolStripMenuItem;
    }
}

