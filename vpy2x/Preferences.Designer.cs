namespace vpy2x
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.cmb_default_preset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_formstyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.tp_main.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(443, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem,
            this.applyAndCloseToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.resetToDefaultToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(63, 20);
            this.toolStripSplitButton1.Text = "Actions";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // applyAndCloseToolStripMenuItem
            // 
            this.applyAndCloseToolStripMenuItem.Name = "applyAndCloseToolStripMenuItem";
            this.applyAndCloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applyAndCloseToolStripMenuItem.Text = "Apply and close";
            this.applyAndCloseToolStripMenuItem.Click += new System.EventHandler(this.applyAndCloseToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to default";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // tp_main
            // 
            this.tp_main.Controls.Add(this.cmb_default_preset);
            this.tp_main.Controls.Add(this.label2);
            this.tp_main.Controls.Add(this.cmb_formstyle);
            this.tp_main.Controls.Add(this.label1);
            this.tp_main.Location = new System.Drawing.Point(4, 22);
            this.tp_main.Name = "tp_main";
            this.tp_main.Padding = new System.Windows.Forms.Padding(3);
            this.tp_main.Size = new System.Drawing.Size(435, 302);
            this.tp_main.TabIndex = 0;
            this.tp_main.Text = "Main";
            this.tp_main.UseVisualStyleBackColor = true;
            // 
            // cmb_default_preset
            // 
            this.cmb_default_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_default_preset.FormattingEnabled = true;
            this.cmb_default_preset.Location = new System.Drawing.Point(107, 39);
            this.cmb_default_preset.Name = "cmb_default_preset";
            this.cmb_default_preset.Size = new System.Drawing.Size(322, 21);
            this.cmb_default_preset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Default preset";
            // 
            // cmb_formstyle
            // 
            this.cmb_formstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formstyle.FormattingEnabled = true;
            this.cmb_formstyle.Items.AddRange(new object[] {
            "Normal",
            "Maximized"});
            this.cmb_formstyle.Location = new System.Drawing.Point(107, 9);
            this.cmb_formstyle.Name = "cmb_formstyle";
            this.cmb_formstyle.Size = new System.Drawing.Size(121, 21);
            this.cmb_formstyle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form window state";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_main);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tp_main.ResumeLayout(false);
            this.tp_main.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyAndCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.ComboBox cmb_default_preset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_formstyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
    }
}