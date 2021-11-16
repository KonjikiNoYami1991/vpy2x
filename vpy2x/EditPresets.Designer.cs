
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
            this.cmb_edit_presets = new System.Windows.Forms.ComboBox();
            this.b_save_edit_presets = new System.Windows.Forms.Button();
            this.b_del_edit_presets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_exe_edit_presets = new System.Windows.Forms.TextBox();
            this.b_browse_exe_edit_presets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_header_edit_presets = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_fr_num_edit_presets = new System.Windows.Forms.Button();
            this.b_fr_denom_edit_presets = new System.Windows.Forms.Button();
            this.b_bitdepth_edit_presets = new System.Windows.Forms.Button();
            this.b_fr_as_fraction_edit_presets = new System.Windows.Forms.Button();
            this.b_dir_script_path_edit_presets = new System.Windows.Forms.Button();
            this.b_script_name_no_ext_edit_presets = new System.Windows.Forms.Button();
            this.b_subsampl_string_edit_presets = new System.Windows.Forms.Button();
            this.b_width_edit_presets = new System.Windows.Forms.Button();
            this.b_height_edit_presets = new System.Windows.Forms.Button();
            this.b_num_frames_edit_presets = new System.Windows.Forms.Button();
            this.tb_args_edit_presets = new System.Windows.Forms.TextBox();
            this.ll_help_placeholders = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_edit_presets
            // 
            this.cmb_edit_presets.FormattingEnabled = true;
            this.cmb_edit_presets.Location = new System.Drawing.Point(93, 11);
            this.cmb_edit_presets.Name = "cmb_edit_presets";
            this.cmb_edit_presets.Size = new System.Drawing.Size(551, 21);
            this.cmb_edit_presets.TabIndex = 2;
            this.cmb_edit_presets.SelectedIndexChanged += new System.EventHandler(this.cmb_presets_SelectedIndexChanged);
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
            // b_fr_num_edit_presets
            // 
            this.b_fr_num_edit_presets.Location = new System.Drawing.Point(632, 107);
            this.b_fr_num_edit_presets.Name = "b_fr_num_edit_presets";
            this.b_fr_num_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_fr_num_edit_presets.TabIndex = 12;
            this.b_fr_num_edit_presets.Text = "Framerate numerator";
            this.b_fr_num_edit_presets.UseVisualStyleBackColor = true;
            this.b_fr_num_edit_presets.Click += new System.EventHandler(this.b_fr_num_edit_presets_Click);
            // 
            // b_fr_denom_edit_presets
            // 
            this.b_fr_denom_edit_presets.Location = new System.Drawing.Point(632, 136);
            this.b_fr_denom_edit_presets.Name = "b_fr_denom_edit_presets";
            this.b_fr_denom_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_fr_denom_edit_presets.TabIndex = 13;
            this.b_fr_denom_edit_presets.Text = "Framerate denominator";
            this.b_fr_denom_edit_presets.UseVisualStyleBackColor = true;
            this.b_fr_denom_edit_presets.Click += new System.EventHandler(this.b_fr_denom_edit_presets_Click);
            // 
            // b_bitdepth_edit_presets
            // 
            this.b_bitdepth_edit_presets.Location = new System.Drawing.Point(632, 165);
            this.b_bitdepth_edit_presets.Name = "b_bitdepth_edit_presets";
            this.b_bitdepth_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_bitdepth_edit_presets.TabIndex = 14;
            this.b_bitdepth_edit_presets.Text = "Color bitdepth";
            this.b_bitdepth_edit_presets.UseVisualStyleBackColor = true;
            this.b_bitdepth_edit_presets.Click += new System.EventHandler(this.b_bitdepth_edit_presets_Click);
            // 
            // b_fr_as_fraction_edit_presets
            // 
            this.b_fr_as_fraction_edit_presets.Location = new System.Drawing.Point(632, 194);
            this.b_fr_as_fraction_edit_presets.Name = "b_fr_as_fraction_edit_presets";
            this.b_fr_as_fraction_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_fr_as_fraction_edit_presets.TabIndex = 15;
            this.b_fr_as_fraction_edit_presets.Text = "Framerate as fraction";
            this.b_fr_as_fraction_edit_presets.UseVisualStyleBackColor = true;
            this.b_fr_as_fraction_edit_presets.Click += new System.EventHandler(this.b_fr_as_fraction_edit_presets_Click);
            // 
            // b_dir_script_path_edit_presets
            // 
            this.b_dir_script_path_edit_presets.Location = new System.Drawing.Point(632, 223);
            this.b_dir_script_path_edit_presets.Name = "b_dir_script_path_edit_presets";
            this.b_dir_script_path_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_dir_script_path_edit_presets.TabIndex = 16;
            this.b_dir_script_path_edit_presets.Text = "Directory from script\'s path";
            this.b_dir_script_path_edit_presets.UseVisualStyleBackColor = true;
            this.b_dir_script_path_edit_presets.Click += new System.EventHandler(this.b_dir_script_path_edit_presets_Click);
            // 
            // b_script_name_no_ext_edit_presets
            // 
            this.b_script_name_no_ext_edit_presets.Location = new System.Drawing.Point(632, 252);
            this.b_script_name_no_ext_edit_presets.Name = "b_script_name_no_ext_edit_presets";
            this.b_script_name_no_ext_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_script_name_no_ext_edit_presets.TabIndex = 17;
            this.b_script_name_no_ext_edit_presets.Text = "Script\'s name without extension";
            this.b_script_name_no_ext_edit_presets.UseVisualStyleBackColor = true;
            this.b_script_name_no_ext_edit_presets.Click += new System.EventHandler(this.b_script_name_no_ext_edit_presets_Click);
            // 
            // b_subsampl_string_edit_presets
            // 
            this.b_subsampl_string_edit_presets.Location = new System.Drawing.Point(632, 281);
            this.b_subsampl_string_edit_presets.Name = "b_subsampl_string_edit_presets";
            this.b_subsampl_string_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_subsampl_string_edit_presets.TabIndex = 18;
            this.b_subsampl_string_edit_presets.Text = "Subsampling string";
            this.b_subsampl_string_edit_presets.UseVisualStyleBackColor = true;
            this.b_subsampl_string_edit_presets.Click += new System.EventHandler(this.b_subsampl_string_edit_presets_Click);
            // 
            // b_width_edit_presets
            // 
            this.b_width_edit_presets.Location = new System.Drawing.Point(632, 310);
            this.b_width_edit_presets.Name = "b_width_edit_presets";
            this.b_width_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_width_edit_presets.TabIndex = 19;
            this.b_width_edit_presets.Text = "Width";
            this.b_width_edit_presets.UseVisualStyleBackColor = true;
            this.b_width_edit_presets.Click += new System.EventHandler(this.b_width_edit_presets_Click);
            // 
            // b_height_edit_presets
            // 
            this.b_height_edit_presets.Location = new System.Drawing.Point(632, 339);
            this.b_height_edit_presets.Name = "b_height_edit_presets";
            this.b_height_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_height_edit_presets.TabIndex = 20;
            this.b_height_edit_presets.Text = "Height";
            this.b_height_edit_presets.UseVisualStyleBackColor = true;
            this.b_height_edit_presets.Click += new System.EventHandler(this.b_height_edit_presets_Click);
            // 
            // b_num_frames_edit_presets
            // 
            this.b_num_frames_edit_presets.Location = new System.Drawing.Point(632, 368);
            this.b_num_frames_edit_presets.Name = "b_num_frames_edit_presets";
            this.b_num_frames_edit_presets.Size = new System.Drawing.Size(174, 23);
            this.b_num_frames_edit_presets.TabIndex = 21;
            this.b_num_frames_edit_presets.Text = "Total number of frames";
            this.b_num_frames_edit_presets.UseVisualStyleBackColor = true;
            this.b_num_frames_edit_presets.Click += new System.EventHandler(this.b_num_frames_edit_presets_Click);
            // 
            // tb_args_edit_presets
            // 
            this.tb_args_edit_presets.Location = new System.Drawing.Point(12, 92);
            this.tb_args_edit_presets.Multiline = true;
            this.tb_args_edit_presets.Name = "tb_args_edit_presets";
            this.tb_args_edit_presets.Size = new System.Drawing.Size(614, 299);
            this.tb_args_edit_presets.TabIndex = 23;
            // 
            // ll_help_placeholders
            // 
            this.ll_help_placeholders.AutoSize = true;
            this.ll_help_placeholders.Location = new System.Drawing.Point(777, 92);
            this.ll_help_placeholders.Name = "ll_help_placeholders";
            this.ll_help_placeholders.Size = new System.Drawing.Size(29, 13);
            this.ll_help_placeholders.TabIndex = 34;
            this.ll_help_placeholders.TabStop = true;
            this.ll_help_placeholders.Text = "Help";
            this.ll_help_placeholders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_help_placeholders_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Placeholders";
            // 
            // EditPresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 399);
            this.Controls.Add(this.ll_help_placeholders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_args_edit_presets);
            this.Controls.Add(this.b_num_frames_edit_presets);
            this.Controls.Add(this.b_height_edit_presets);
            this.Controls.Add(this.b_width_edit_presets);
            this.Controls.Add(this.b_subsampl_string_edit_presets);
            this.Controls.Add(this.b_script_name_no_ext_edit_presets);
            this.Controls.Add(this.b_dir_script_path_edit_presets);
            this.Controls.Add(this.b_fr_as_fraction_edit_presets);
            this.Controls.Add(this.b_bitdepth_edit_presets);
            this.Controls.Add(this.b_fr_denom_edit_presets);
            this.Controls.Add(this.b_fr_num_edit_presets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_header_edit_presets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_exe_edit_presets);
            this.Controls.Add(this.b_browse_exe_edit_presets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_del_edit_presets);
            this.Controls.Add(this.b_save_edit_presets);
            this.Controls.Add(this.cmb_edit_presets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditPresets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Presets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_edit_presets;
        private System.Windows.Forms.Button b_save_edit_presets;
        private System.Windows.Forms.Button b_del_edit_presets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_exe_edit_presets;
        private System.Windows.Forms.Button b_browse_exe_edit_presets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_header_edit_presets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_fr_num_edit_presets;
        private System.Windows.Forms.Button b_fr_denom_edit_presets;
        private System.Windows.Forms.Button b_bitdepth_edit_presets;
        private System.Windows.Forms.Button b_fr_as_fraction_edit_presets;
        private System.Windows.Forms.Button b_dir_script_path_edit_presets;
        private System.Windows.Forms.Button b_script_name_no_ext_edit_presets;
        private System.Windows.Forms.Button b_subsampl_string_edit_presets;
        private System.Windows.Forms.Button b_width_edit_presets;
        private System.Windows.Forms.Button b_height_edit_presets;
        private System.Windows.Forms.Button b_num_frames_edit_presets;
        private System.Windows.Forms.TextBox tb_args_edit_presets;
        private System.Windows.Forms.LinkLabel ll_help_placeholders;
        private System.Windows.Forms.Label label5;
    }
}