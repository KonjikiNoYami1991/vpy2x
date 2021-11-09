
namespace vpy2x
{
    partial class LoadScript
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
            this.b_load_script = new System.Windows.Forms.Button();
            this.tb_vpy = new System.Windows.Forms.TextBox();
            this.cmb_presets_load_script = new System.Windows.Forms.ComboBox();
            this.b_save_load_script = new System.Windows.Forms.Button();
            this.b_del_load_script = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_exe_load_script = new System.Windows.Forms.TextBox();
            this.b_exe_load_script = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_header_load_script = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_framerate_num_load_script = new System.Windows.Forms.Button();
            this.b_framerate_denom_load_script = new System.Windows.Forms.Button();
            this.b_bitdepth_load_script = new System.Windows.Forms.Button();
            this.b_framerate_fraction_load_script = new System.Windows.Forms.Button();
            this.b_dir_script_path_load_script = new System.Windows.Forms.Button();
            this.b_script_name_no_ext_load_script = new System.Windows.Forms.Button();
            this.b_subsampling_load_script = new System.Windows.Forms.Button();
            this.b_width_load_script = new System.Windows.Forms.Button();
            this.b_height_load_script = new System.Windows.Forms.Button();
            this.b_num_frames_load_script = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_done = new System.Windows.Forms.Button();
            this.num_start_frame = new System.Windows.Forms.NumericUpDown();
            this.num_end_frame = new System.Windows.Forms.NumericUpDown();
            this.b_grab_num_frames = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_args_load_script = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_start_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_end_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // b_load_script
            // 
            this.b_load_script.Location = new System.Drawing.Point(12, 12);
            this.b_load_script.Name = "b_load_script";
            this.b_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_load_script.TabIndex = 0;
            this.b_load_script.Text = "Browse VPY";
            this.b_load_script.UseVisualStyleBackColor = true;
            // 
            // tb_vpy
            // 
            this.tb_vpy.Location = new System.Drawing.Point(93, 14);
            this.tb_vpy.Name = "tb_vpy";
            this.tb_vpy.Size = new System.Drawing.Size(713, 20);
            this.tb_vpy.TabIndex = 1;
            // 
            // cmb_presets_load_script
            // 
            this.cmb_presets_load_script.FormattingEnabled = true;
            this.cmb_presets_load_script.Location = new System.Drawing.Point(93, 57);
            this.cmb_presets_load_script.Name = "cmb_presets_load_script";
            this.cmb_presets_load_script.Size = new System.Drawing.Size(551, 21);
            this.cmb_presets_load_script.TabIndex = 2;
            this.cmb_presets_load_script.SelectedIndexChanged += new System.EventHandler(this.cmb_presets_load_script_SelectedIndexChanged);
            // 
            // b_save_load_script
            // 
            this.b_save_load_script.Location = new System.Drawing.Point(650, 55);
            this.b_save_load_script.Name = "b_save_load_script";
            this.b_save_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_save_load_script.TabIndex = 3;
            this.b_save_load_script.Text = "Save";
            this.b_save_load_script.UseVisualStyleBackColor = true;
            this.b_save_load_script.Click += new System.EventHandler(this.b_save_load_script_Click);
            // 
            // b_del_load_script
            // 
            this.b_del_load_script.Location = new System.Drawing.Point(731, 55);
            this.b_del_load_script.Name = "b_del_load_script";
            this.b_del_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_del_load_script.TabIndex = 4;
            this.b_del_load_script.Text = "Delete";
            this.b_del_load_script.UseVisualStyleBackColor = true;
            this.b_del_load_script.Click += new System.EventHandler(this.b_del_load_script_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preset";
            // 
            // tb_exe_load_script
            // 
            this.tb_exe_load_script.Location = new System.Drawing.Point(93, 87);
            this.tb_exe_load_script.Name = "tb_exe_load_script";
            this.tb_exe_load_script.Size = new System.Drawing.Size(551, 20);
            this.tb_exe_load_script.TabIndex = 7;
            // 
            // b_exe_load_script
            // 
            this.b_exe_load_script.Location = new System.Drawing.Point(12, 85);
            this.b_exe_load_script.Name = "b_exe_load_script";
            this.b_exe_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_exe_load_script.TabIndex = 6;
            this.b_exe_load_script.Text = "Browse EXE";
            this.b_exe_load_script.UseVisualStyleBackColor = true;
            this.b_exe_load_script.Click += new System.EventHandler(this.b_exe_load_script_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Header";
            // 
            // cmb_header_load_script
            // 
            this.cmb_header_load_script.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_header_load_script.FormattingEnabled = true;
            this.cmb_header_load_script.Items.AddRange(new object[] {
            "No header",
            "Y4M"});
            this.cmb_header_load_script.Location = new System.Drawing.Point(711, 86);
            this.cmb_header_load_script.Name = "cmb_header_load_script";
            this.cmb_header_load_script.Size = new System.Drawing.Size(95, 21);
            this.cmb_header_load_script.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arguments";
            // 
            // b_framerate_num_load_script
            // 
            this.b_framerate_num_load_script.Location = new System.Drawing.Point(632, 153);
            this.b_framerate_num_load_script.Name = "b_framerate_num_load_script";
            this.b_framerate_num_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_num_load_script.TabIndex = 12;
            this.b_framerate_num_load_script.Text = "Framerate numerator";
            this.b_framerate_num_load_script.UseVisualStyleBackColor = true;
            // 
            // b_framerate_denom_load_script
            // 
            this.b_framerate_denom_load_script.Location = new System.Drawing.Point(632, 182);
            this.b_framerate_denom_load_script.Name = "b_framerate_denom_load_script";
            this.b_framerate_denom_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_denom_load_script.TabIndex = 13;
            this.b_framerate_denom_load_script.Text = "Framerate denominator";
            this.b_framerate_denom_load_script.UseVisualStyleBackColor = true;
            // 
            // b_bitdepth_load_script
            // 
            this.b_bitdepth_load_script.Location = new System.Drawing.Point(632, 211);
            this.b_bitdepth_load_script.Name = "b_bitdepth_load_script";
            this.b_bitdepth_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_bitdepth_load_script.TabIndex = 14;
            this.b_bitdepth_load_script.Text = "Color bitdepth";
            this.b_bitdepth_load_script.UseVisualStyleBackColor = true;
            // 
            // b_framerate_fraction_load_script
            // 
            this.b_framerate_fraction_load_script.Location = new System.Drawing.Point(632, 240);
            this.b_framerate_fraction_load_script.Name = "b_framerate_fraction_load_script";
            this.b_framerate_fraction_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_fraction_load_script.TabIndex = 15;
            this.b_framerate_fraction_load_script.Text = "Framerate as fraction";
            this.b_framerate_fraction_load_script.UseVisualStyleBackColor = true;
            // 
            // b_dir_script_path_load_script
            // 
            this.b_dir_script_path_load_script.Location = new System.Drawing.Point(632, 269);
            this.b_dir_script_path_load_script.Name = "b_dir_script_path_load_script";
            this.b_dir_script_path_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_dir_script_path_load_script.TabIndex = 16;
            this.b_dir_script_path_load_script.Text = "Directory from script\'s path";
            this.b_dir_script_path_load_script.UseVisualStyleBackColor = true;
            // 
            // b_script_name_no_ext_load_script
            // 
            this.b_script_name_no_ext_load_script.Location = new System.Drawing.Point(632, 298);
            this.b_script_name_no_ext_load_script.Name = "b_script_name_no_ext_load_script";
            this.b_script_name_no_ext_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_script_name_no_ext_load_script.TabIndex = 17;
            this.b_script_name_no_ext_load_script.Text = "Script\'s name without extension";
            this.b_script_name_no_ext_load_script.UseVisualStyleBackColor = true;
            // 
            // b_subsampling_load_script
            // 
            this.b_subsampling_load_script.Location = new System.Drawing.Point(632, 327);
            this.b_subsampling_load_script.Name = "b_subsampling_load_script";
            this.b_subsampling_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_subsampling_load_script.TabIndex = 18;
            this.b_subsampling_load_script.Text = "Subsampling string";
            this.b_subsampling_load_script.UseVisualStyleBackColor = true;
            // 
            // b_width_load_script
            // 
            this.b_width_load_script.Location = new System.Drawing.Point(632, 356);
            this.b_width_load_script.Name = "b_width_load_script";
            this.b_width_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_width_load_script.TabIndex = 19;
            this.b_width_load_script.Text = "Width";
            this.b_width_load_script.UseVisualStyleBackColor = true;
            // 
            // b_height_load_script
            // 
            this.b_height_load_script.Location = new System.Drawing.Point(632, 385);
            this.b_height_load_script.Name = "b_height_load_script";
            this.b_height_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_height_load_script.TabIndex = 20;
            this.b_height_load_script.Text = "Height";
            this.b_height_load_script.UseVisualStyleBackColor = true;
            // 
            // b_num_frames_load_script
            // 
            this.b_num_frames_load_script.Location = new System.Drawing.Point(632, 414);
            this.b_num_frames_load_script.Name = "b_num_frames_load_script";
            this.b_num_frames_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_num_frames_load_script.TabIndex = 21;
            this.b_num_frames_load_script.Text = "Total number of frames";
            this.b_num_frames_load_script.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Placeholders";
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(731, 470);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 24;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_done
            // 
            this.b_done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_done.Location = new System.Drawing.Point(650, 470);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(75, 23);
            this.b_done.TabIndex = 23;
            this.b_done.Text = "Done";
            this.b_done.UseVisualStyleBackColor = true;
            // 
            // num_start_frame
            // 
            this.num_start_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_start_frame.Location = new System.Drawing.Point(79, 448);
            this.num_start_frame.Name = "num_start_frame";
            this.num_start_frame.Size = new System.Drawing.Size(111, 20);
            this.num_start_frame.TabIndex = 25;
            this.num_start_frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_end_frame
            // 
            this.num_end_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_end_frame.Location = new System.Drawing.Point(218, 448);
            this.num_end_frame.Name = "num_end_frame";
            this.num_end_frame.Size = new System.Drawing.Size(111, 20);
            this.num_end_frame.TabIndex = 26;
            this.num_end_frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_grab_num_frames
            // 
            this.b_grab_num_frames.Location = new System.Drawing.Point(335, 445);
            this.b_grab_num_frames.Name = "b_grab_num_frames";
            this.b_grab_num_frames.Size = new System.Drawing.Size(75, 23);
            this.b_grab_num_frames.TabIndex = 27;
            this.b_grab_num_frames.Text = "From video";
            this.b_grab_num_frames.UseVisualStyleBackColor = true;
            this.b_grab_num_frames.Click += new System.EventHandler(this.b_grab_num_frames_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Frames from";
            // 
            // tb_args_load_script
            // 
            this.tb_args_load_script.Location = new System.Drawing.Point(12, 138);
            this.tb_args_load_script.Multiline = true;
            this.tb_args_load_script.Name = "tb_args_load_script";
            this.tb_args_load_script.Size = new System.Drawing.Size(614, 299);
            this.tb_args_load_script.TabIndex = 31;
            // 
            // LoadScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 505);
            this.Controls.Add(this.tb_args_load_script);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.b_grab_num_frames);
            this.Controls.Add(this.num_end_frame);
            this.Controls.Add(this.num_start_frame);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_num_frames_load_script);
            this.Controls.Add(this.b_height_load_script);
            this.Controls.Add(this.b_width_load_script);
            this.Controls.Add(this.b_subsampling_load_script);
            this.Controls.Add(this.b_script_name_no_ext_load_script);
            this.Controls.Add(this.b_dir_script_path_load_script);
            this.Controls.Add(this.b_framerate_fraction_load_script);
            this.Controls.Add(this.b_bitdepth_load_script);
            this.Controls.Add(this.b_framerate_denom_load_script);
            this.Controls.Add(this.b_framerate_num_load_script);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_header_load_script);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_exe_load_script);
            this.Controls.Add(this.b_exe_load_script);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_del_load_script);
            this.Controls.Add(this.b_save_load_script);
            this.Controls.Add(this.cmb_presets_load_script);
            this.Controls.Add(this.tb_vpy);
            this.Controls.Add(this.b_load_script);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoadScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Script";
            ((System.ComponentModel.ISupportInitialize)(this.num_start_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_end_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_load_script;
        private System.Windows.Forms.TextBox tb_vpy;
        private System.Windows.Forms.ComboBox cmb_presets_load_script;
        private System.Windows.Forms.Button b_save_load_script;
        private System.Windows.Forms.Button b_del_load_script;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_exe_load_script;
        private System.Windows.Forms.Button b_exe_load_script;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_header_load_script;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_framerate_num_load_script;
        private System.Windows.Forms.Button b_framerate_denom_load_script;
        private System.Windows.Forms.Button b_bitdepth_load_script;
        private System.Windows.Forms.Button b_framerate_fraction_load_script;
        private System.Windows.Forms.Button b_dir_script_path_load_script;
        private System.Windows.Forms.Button b_script_name_no_ext_load_script;
        private System.Windows.Forms.Button b_subsampling_load_script;
        private System.Windows.Forms.Button b_width_load_script;
        private System.Windows.Forms.Button b_height_load_script;
        private System.Windows.Forms.Button b_num_frames_load_script;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_done;
        private System.Windows.Forms.NumericUpDown num_start_frame;
        private System.Windows.Forms.NumericUpDown num_end_frame;
        private System.Windows.Forms.Button b_grab_num_frames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_args_load_script;
    }
}