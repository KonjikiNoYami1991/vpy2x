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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.cmb_default_preset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_formstyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_notifications = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_parameters = new System.Windows.Forms.GroupBox();
            this.cb_full_log = new System.Windows.Forms.CheckBox();
            this.cb_single_log = new System.Windows.Forms.CheckBox();
            this.tb_to_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_port = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_from_address = new System.Windows.Forms.TextBox();
            this.tb_pswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_mail = new System.Windows.Forms.CheckBox();
            this.tb_smtp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ll_help = new System.Windows.Forms.LinkLabel();
            this.cb_ssl = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_main.SuspendLayout();
            this.tp_notifications.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_main);
            this.tabControl1.Controls.Add(this.tp_notifications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 328);
            this.tabControl1.TabIndex = 0;
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
            this.cmb_default_preset.Location = new System.Drawing.Point(96, 44);
            this.cmb_default_preset.Name = "cmb_default_preset";
            this.cmb_default_preset.Size = new System.Drawing.Size(204, 21);
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
            "Minimized",
            "Normal",
            "Maximized"});
            this.cmb_formstyle.Location = new System.Drawing.Point(96, 9);
            this.cmb_formstyle.Name = "cmb_formstyle";
            this.cmb_formstyle.Size = new System.Drawing.Size(121, 21);
            this.cmb_formstyle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start program as";
            // 
            // tp_notifications
            // 
            this.tp_notifications.Controls.Add(this.tabControl2);
            this.tp_notifications.Location = new System.Drawing.Point(4, 22);
            this.tp_notifications.Name = "tp_notifications";
            this.tp_notifications.Padding = new System.Windows.Forms.Padding(3);
            this.tp_notifications.Size = new System.Drawing.Size(435, 302);
            this.tp_notifications.TabIndex = 1;
            this.tp_notifications.Text = "Notifications";
            this.tp_notifications.UseVisualStyleBackColor = true;
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
            this.applyAndSaveToolStripMenuItem,
            this.cancelToolStripMenuItem});
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
            // 
            // applyAndSaveToolStripMenuItem
            // 
            this.applyAndSaveToolStripMenuItem.Name = "applyAndSaveToolStripMenuItem";
            this.applyAndSaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applyAndSaveToolStripMenuItem.Text = "Apply and save";
            this.applyAndSaveToolStripMenuItem.Click += new System.EventHandler(this.applyAndSaveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(429, 296);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_parameters);
            this.tabPage1.Controls.Add(this.cb_mail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_parameters
            // 
            this.gb_parameters.Controls.Add(this.button1);
            this.gb_parameters.Controls.Add(this.ll_help);
            this.gb_parameters.Controls.Add(this.tb_smtp);
            this.gb_parameters.Controls.Add(this.label7);
            this.gb_parameters.Controls.Add(this.cb_full_log);
            this.gb_parameters.Controls.Add(this.cb_single_log);
            this.gb_parameters.Controls.Add(this.tb_to_address);
            this.gb_parameters.Controls.Add(this.label8);
            this.gb_parameters.Controls.Add(this.tb_subject);
            this.gb_parameters.Controls.Add(this.label6);
            this.gb_parameters.Controls.Add(this.num_port);
            this.gb_parameters.Controls.Add(this.label5);
            this.gb_parameters.Controls.Add(this.cb_ssl);
            this.gb_parameters.Controls.Add(this.tb_from_address);
            this.gb_parameters.Controls.Add(this.tb_pswd);
            this.gb_parameters.Controls.Add(this.label4);
            this.gb_parameters.Controls.Add(this.label3);
            this.gb_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_parameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_parameters.Location = new System.Drawing.Point(3, 20);
            this.gb_parameters.Name = "gb_parameters";
            this.gb_parameters.Size = new System.Drawing.Size(415, 247);
            this.gb_parameters.TabIndex = 3;
            this.gb_parameters.TabStop = false;
            this.gb_parameters.Text = "Parameters";
            // 
            // cb_full_log
            // 
            this.cb_full_log.AutoSize = true;
            this.cb_full_log.Location = new System.Drawing.Point(9, 204);
            this.cb_full_log.Name = "cb_full_log";
            this.cb_full_log.Size = new System.Drawing.Size(198, 17);
            this.cb_full_log.TabIndex = 14;
            this.cb_full_log.Text = "Include full LOG when jobs are done";
            this.cb_full_log.UseVisualStyleBackColor = true;
            // 
            // cb_single_log
            // 
            this.cb_single_log.AutoSize = true;
            this.cb_single_log.Location = new System.Drawing.Point(9, 181);
            this.cb_single_log.Name = "cb_single_log";
            this.cb_single_log.Size = new System.Drawing.Size(170, 17);
            this.cb_single_log.TabIndex = 13;
            this.cb_single_log.Text = "Include LOG for single encode";
            this.cb_single_log.UseVisualStyleBackColor = true;
            // 
            // tb_to_address
            // 
            this.tb_to_address.Location = new System.Drawing.Point(65, 119);
            this.tb_to_address.Name = "tb_to_address";
            this.tb_to_address.Size = new System.Drawing.Size(340, 20);
            this.tb_to_address.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Send to";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(65, 145);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(340, 20);
            this.tb_subject.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Subject";
            // 
            // num_port
            // 
            this.num_port.Location = new System.Drawing.Point(346, 50);
            this.num_port.Name = "num_port";
            this.num_port.Size = new System.Drawing.Size(59, 20);
            this.num_port.TabIndex = 6;
            this.num_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port number";
            // 
            // tb_from_address
            // 
            this.tb_from_address.Location = new System.Drawing.Point(65, 23);
            this.tb_from_address.Name = "tb_from_address";
            this.tb_from_address.Size = new System.Drawing.Size(208, 20);
            this.tb_from_address.TabIndex = 3;
            // 
            // tb_pswd
            // 
            this.tb_pswd.Location = new System.Drawing.Point(65, 49);
            this.tb_pswd.Name = "tb_pswd";
            this.tb_pswd.PasswordChar = '*';
            this.tb_pswd.Size = new System.Drawing.Size(208, 20);
            this.tb_pswd.TabIndex = 2;
            this.tb_pswd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Send from";
            // 
            // cb_mail
            // 
            this.cb_mail.AutoSize = true;
            this.cb_mail.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_mail.Location = new System.Drawing.Point(3, 3);
            this.cb_mail.Name = "cb_mail";
            this.cb_mail.Size = new System.Drawing.Size(415, 17);
            this.cb_mail.TabIndex = 2;
            this.cb_mail.Text = "Enable";
            this.cb_mail.UseVisualStyleBackColor = true;
            // 
            // tb_smtp
            // 
            this.tb_smtp.Location = new System.Drawing.Point(81, 75);
            this.tb_smtp.Name = "tb_smtp";
            this.tb_smtp.Size = new System.Drawing.Size(192, 20);
            this.tb_smtp.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SMTP server";
            // 
            // ll_help
            // 
            this.ll_help.AutoSize = true;
            this.ll_help.Location = new System.Drawing.Point(380, 16);
            this.ll_help.Name = "ll_help";
            this.ll_help.Size = new System.Drawing.Size(29, 13);
            this.ll_help.TabIndex = 17;
            this.ll_help.TabStop = true;
            this.ll_help.Text = "Help";
            this.ll_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_help_LinkClicked);
            // 
            // cb_ssl
            // 
            this.cb_ssl.AutoSize = true;
            this.cb_ssl.Location = new System.Drawing.Point(279, 25);
            this.cb_ssl.Name = "cb_ssl";
            this.cb_ssl.Size = new System.Drawing.Size(82, 17);
            this.cb_ssl.TabIndex = 4;
            this.cb_ssl.Text = "Enable SSL";
            this.cb_ssl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(308, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Send a test email";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tp_main.ResumeLayout(false);
            this.tp_main.PerformLayout();
            this.tp_notifications.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb_parameters.ResumeLayout(false);
            this.gb_parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.TabPage tp_notifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_formstyle;
        private System.Windows.Forms.ComboBox cmb_default_preset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gb_parameters;
        private System.Windows.Forms.CheckBox cb_full_log;
        private System.Windows.Forms.CheckBox cb_single_log;
        private System.Windows.Forms.TextBox tb_to_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_from_address;
        private System.Windows.Forms.TextBox tb_pswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_mail;
        private System.Windows.Forms.TextBox tb_smtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel ll_help;
        private System.Windows.Forms.CheckBox cb_ssl;
        private System.Windows.Forms.Button button1;
    }
}