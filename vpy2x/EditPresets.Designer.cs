
namespace vpy2x
{
    partial class EditPresets
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
            this.cmb_presets = new System.Windows.Forms.ComboBox();
            this.b_save_edit_presets = new System.Windows.Forms.Button();
            this.b_del_edit_presets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_exe_edit_presets = new System.Windows.Forms.TextBox();
            this.b_browse_exe_edit_presets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_header_edit_presets = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_args_edit_presets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_presets
            // 
            this.cmb_presets.FormattingEnabled = true;
            this.cmb_presets.Location = new System.Drawing.Point(93, 11);
            this.cmb_presets.Name = "cmb_presets";
            this.cmb_presets.Size = new System.Drawing.Size(551, 21);
            this.cmb_presets.TabIndex = 2;
            this.cmb_presets.SelectedIndexChanged += new System.EventHandler(this.cmb_presets_SelectedIndexChanged);
            // 
            // b_save_edit_presets
            // 
            this.b_save_edit_presets.Location = new System.Drawing.Point(650, 9);
            this.b_save_edit_presets.Name = "b_save_edit_presets";
            this.b_save_edit_presets.Size = new System.Drawing.Size(75, 23);
            this.b_save_edit_presets.TabIndex = 3;
            this.b_save_edit_presets.Text = "Save";
            this.b_save_edit_presets.UseVisualStyleBackColor = true;
            this.b_save_edit_presets.Click += new System.EventHandler(this.b_save_edit_presets_Click);
            // 
            // b_del_edit_presets
            // 
            this.b_del_edit_presets.Location = new System.Drawing.Point(731, 9);
            this.b_del_edit_presets.Name = "b_del_edit_presets";
            this.b_del_edit_presets.Size = new System.Drawing.Size(75, 23);
            this.b_del_edit_presets.TabIndex = 4;
            this.b_del_edit_presets.Text = "Delete";
            this.b_del_edit_presets.UseVisualStyleBackColor = true;
            this.b_del_edit_presets.Click += new System.EventHandler(this.b_del_edit_presets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preset";
            // 
            // tb_exe_edit_presets
            // 
            this.tb_exe_edit_presets.Location = new System.Drawing.Point(93, 41);
            this.tb_exe_edit_presets.Name = "tb_exe_edit_presets";
            this.tb_exe_edit_presets.Size = new System.Drawing.Size(551, 20);
            this.tb_exe_edit_presets.TabIndex = 7;
            // 
            // b_browse_exe_edit_presets
            // 
            this.b_browse_exe_edit_presets.Location = new System.Drawing.Point(12, 39);
            this.b_browse_exe_edit_presets.Name = "b_browse_exe_edit_presets";
            this.b_browse_exe_edit_presets.Size = new System.Drawing.Size(75, 23);
            this.b_browse_exe_edit_presets.TabIndex = 6;
            this.b_browse_exe_edit_presets.Text = "Browse EXE";
            this.b_browse_exe_edit_presets.UseVisualStyleBackColor = true;
            this.b_browse_exe_edit_presets.Click += new System.EventHandler(this.b_browse_exe_edit_presets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Header";
            // 
            // cmb_header_edit_presets
            // 
            this.cmb_header_edit_presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_header_edit_presets.FormattingEnabled = true;
            this.cmb_header_edit_presets.Items.AddRange(new object[] {
            "No header",
            "Y4M"});
            this.cmb_header_edit_presets.Location = new System.Drawing.Point(711, 40);
            this.cmb_header_edit_presets.Name = "cmb_header_edit_presets";
            this.cmb_header_edit_presets.Size = new System.Drawing.Size(95, 21);
            this.cmb_header_edit_presets.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arguments";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(632, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Framerate numerator";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(632, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Framerate denominator";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(632, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Color bitdepth";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(632, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Framerate as fraction";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(632, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Directory from script\'s path";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(632, 252);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(174, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "Script\'s name without extension";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(632, 281);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(174, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "Subsampling string";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(632, 310);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(174, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "Width";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(632, 339);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(174, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "Height";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(632, 368);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(174, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "Total number of frames";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Placeholders";
            // 
            // tb_args_edit_presets
            // 
            this.tb_args_edit_presets.Location = new System.Drawing.Point(12, 92);
            this.tb_args_edit_presets.Multiline = true;
            this.tb_args_edit_presets.Name = "tb_args_edit_presets";
            this.tb_args_edit_presets.Size = new System.Drawing.Size(614, 299);
            this.tb_args_edit_presets.TabIndex = 23;
            // 
            // EditPresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 399);
            this.Controls.Add(this.tb_args_edit_presets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_header_edit_presets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_exe_edit_presets);
            this.Controls.Add(this.b_browse_exe_edit_presets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_del_edit_presets);
            this.Controls.Add(this.b_save_edit_presets);
            this.Controls.Add(this.cmb_presets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditPresets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Presets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_presets;
        private System.Windows.Forms.Button b_save_edit_presets;
        private System.Windows.Forms.Button b_del_edit_presets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_exe_edit_presets;
        private System.Windows.Forms.Button b_browse_exe_edit_presets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_header_edit_presets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_args_edit_presets;
    }
}