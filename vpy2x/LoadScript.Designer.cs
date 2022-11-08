
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
            this.ll_help_placeholders = new System.Windows.Forms.LinkLabel();
            this.b_skip = new System.Windows.Forms.Button();
            this.tb_vpy_av = new System.Windows.Forms.TextBox();
            this.b_load_script_av = new System.Windows.Forms.Button();
            this.b_audio = new System.Windows.Forms.Button();
            this.tv_audiotracks = new System.Windows.Forms.TreeView();
            this.b_expand_tv = new System.Windows.Forms.Button();
            this.b_collapse_tv = new System.Windows.Forms.Button();
            this.b_remove_audiosource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_start_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_end_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // b_load_script
            // 
            this.b_load_script.Location = new System.Drawing.Point(12, 12);
            this.b_load_script.Name = "b_load_script";
            this.b_load_script.Size = new System.Drawing.Size(178, 23);
            this.b_load_script.TabIndex = 0;
            this.b_load_script.Text = "Browse VPY";
            this.b_load_script.UseVisualStyleBackColor = true;
            this.b_load_script.Click += new System.EventHandler(this.b_load_script_Click);
            // 
            // tb_vpy
            // 
            this.tb_vpy.AllowDrop = true;
            this.tb_vpy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_vpy.Location = new System.Drawing.Point(199, 14);
            this.tb_vpy.Name = "tb_vpy";
            this.tb_vpy.Size = new System.Drawing.Size(732, 20);
            this.tb_vpy.TabIndex = 1;
            this.tb_vpy.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_vpy_DragDrop);
            this.tb_vpy.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_vpy_DragEnter);
            // 
            // cmb_presets_load_script
            // 
            this.cmb_presets_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_presets_load_script.FormattingEnabled = true;
            this.cmb_presets_load_script.Location = new System.Drawing.Point(93, 285);
            this.cmb_presets_load_script.Name = "cmb_presets_load_script";
            this.cmb_presets_load_script.Size = new System.Drawing.Size(676, 21);
            this.cmb_presets_load_script.TabIndex = 2;
            this.cmb_presets_load_script.SelectedIndexChanged += new System.EventHandler(this.cmb_presets_load_script_SelectedIndexChanged);
            // 
            // b_save_load_script
            // 
            this.b_save_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save_load_script.Location = new System.Drawing.Point(775, 283);
            this.b_save_load_script.Name = "b_save_load_script";
            this.b_save_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_save_load_script.TabIndex = 3;
            this.b_save_load_script.Text = "Save";
            this.b_save_load_script.UseVisualStyleBackColor = true;
            this.b_save_load_script.Click += new System.EventHandler(this.b_save_load_script_Click);
            // 
            // b_del_load_script
            // 
            this.b_del_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_del_load_script.Location = new System.Drawing.Point(856, 283);
            this.b_del_load_script.Name = "b_del_load_script";
            this.b_del_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_del_load_script.TabIndex = 4;
            this.b_del_load_script.Text = "Delete";
            this.b_del_load_script.UseVisualStyleBackColor = true;
            this.b_del_load_script.Click += new System.EventHandler(this.b_del_load_script_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preset";
            // 
            // tb_exe_load_script
            // 
            this.tb_exe_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_exe_load_script.Location = new System.Drawing.Point(93, 315);
            this.tb_exe_load_script.Name = "tb_exe_load_script";
            this.tb_exe_load_script.Size = new System.Drawing.Size(676, 20);
            this.tb_exe_load_script.TabIndex = 7;
            // 
            // b_exe_load_script
            // 
            this.b_exe_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_exe_load_script.Location = new System.Drawing.Point(12, 313);
            this.b_exe_load_script.Name = "b_exe_load_script";
            this.b_exe_load_script.Size = new System.Drawing.Size(75, 23);
            this.b_exe_load_script.TabIndex = 6;
            this.b_exe_load_script.Text = "Browse EXE";
            this.b_exe_load_script.UseVisualStyleBackColor = true;
            this.b_exe_load_script.Click += new System.EventHandler(this.b_exe_load_script_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Header";
            // 
            // cmb_header_load_script
            // 
            this.cmb_header_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_header_load_script.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_header_load_script.FormattingEnabled = true;
            this.cmb_header_load_script.Items.AddRange(new object[] {
            "No header",
            "Y4M"});
            this.cmb_header_load_script.Location = new System.Drawing.Point(836, 314);
            this.cmb_header_load_script.Name = "cmb_header_load_script";
            this.cmb_header_load_script.Size = new System.Drawing.Size(95, 21);
            this.cmb_header_load_script.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arguments";
            // 
            // b_framerate_num_load_script
            // 
            this.b_framerate_num_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_framerate_num_load_script.Location = new System.Drawing.Point(757, 381);
            this.b_framerate_num_load_script.Name = "b_framerate_num_load_script";
            this.b_framerate_num_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_num_load_script.TabIndex = 12;
            this.b_framerate_num_load_script.Text = "Framerate numerator";
            this.b_framerate_num_load_script.UseVisualStyleBackColor = true;
            this.b_framerate_num_load_script.Click += new System.EventHandler(this.b_framerate_num_load_script_Click);
            // 
            // b_framerate_denom_load_script
            // 
            this.b_framerate_denom_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_framerate_denom_load_script.Location = new System.Drawing.Point(757, 410);
            this.b_framerate_denom_load_script.Name = "b_framerate_denom_load_script";
            this.b_framerate_denom_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_denom_load_script.TabIndex = 13;
            this.b_framerate_denom_load_script.Text = "Framerate denominator";
            this.b_framerate_denom_load_script.UseVisualStyleBackColor = true;
            this.b_framerate_denom_load_script.Click += new System.EventHandler(this.b_framerate_denom_load_script_Click);
            // 
            // b_bitdepth_load_script
            // 
            this.b_bitdepth_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_bitdepth_load_script.Location = new System.Drawing.Point(757, 439);
            this.b_bitdepth_load_script.Name = "b_bitdepth_load_script";
            this.b_bitdepth_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_bitdepth_load_script.TabIndex = 14;
            this.b_bitdepth_load_script.Text = "Color bitdepth";
            this.b_bitdepth_load_script.UseVisualStyleBackColor = true;
            this.b_bitdepth_load_script.Click += new System.EventHandler(this.b_bitdepth_load_script_Click);
            // 
            // b_framerate_fraction_load_script
            // 
            this.b_framerate_fraction_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_framerate_fraction_load_script.Location = new System.Drawing.Point(757, 468);
            this.b_framerate_fraction_load_script.Name = "b_framerate_fraction_load_script";
            this.b_framerate_fraction_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_framerate_fraction_load_script.TabIndex = 15;
            this.b_framerate_fraction_load_script.Text = "Framerate as fraction";
            this.b_framerate_fraction_load_script.UseVisualStyleBackColor = true;
            this.b_framerate_fraction_load_script.Click += new System.EventHandler(this.b_framerate_fraction_load_script_Click);
            // 
            // b_dir_script_path_load_script
            // 
            this.b_dir_script_path_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_dir_script_path_load_script.Location = new System.Drawing.Point(757, 497);
            this.b_dir_script_path_load_script.Name = "b_dir_script_path_load_script";
            this.b_dir_script_path_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_dir_script_path_load_script.TabIndex = 16;
            this.b_dir_script_path_load_script.Text = "Directory from script\'s path";
            this.b_dir_script_path_load_script.UseVisualStyleBackColor = true;
            this.b_dir_script_path_load_script.Click += new System.EventHandler(this.b_dir_script_path_load_script_Click);
            // 
            // b_script_name_no_ext_load_script
            // 
            this.b_script_name_no_ext_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_script_name_no_ext_load_script.Location = new System.Drawing.Point(757, 526);
            this.b_script_name_no_ext_load_script.Name = "b_script_name_no_ext_load_script";
            this.b_script_name_no_ext_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_script_name_no_ext_load_script.TabIndex = 17;
            this.b_script_name_no_ext_load_script.Text = "Script\'s name without extension";
            this.b_script_name_no_ext_load_script.UseVisualStyleBackColor = true;
            this.b_script_name_no_ext_load_script.Click += new System.EventHandler(this.b_script_name_no_ext_load_script_Click);
            // 
            // b_subsampling_load_script
            // 
            this.b_subsampling_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_subsampling_load_script.Location = new System.Drawing.Point(757, 555);
            this.b_subsampling_load_script.Name = "b_subsampling_load_script";
            this.b_subsampling_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_subsampling_load_script.TabIndex = 18;
            this.b_subsampling_load_script.Text = "Subsampling string";
            this.b_subsampling_load_script.UseVisualStyleBackColor = true;
            this.b_subsampling_load_script.Click += new System.EventHandler(this.b_subsampling_load_script_Click);
            // 
            // b_width_load_script
            // 
            this.b_width_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_width_load_script.Location = new System.Drawing.Point(757, 584);
            this.b_width_load_script.Name = "b_width_load_script";
            this.b_width_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_width_load_script.TabIndex = 19;
            this.b_width_load_script.Text = "Width";
            this.b_width_load_script.UseVisualStyleBackColor = true;
            this.b_width_load_script.Click += new System.EventHandler(this.b_width_load_script_Click);
            // 
            // b_height_load_script
            // 
            this.b_height_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_height_load_script.Location = new System.Drawing.Point(757, 613);
            this.b_height_load_script.Name = "b_height_load_script";
            this.b_height_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_height_load_script.TabIndex = 20;
            this.b_height_load_script.Text = "Height";
            this.b_height_load_script.UseVisualStyleBackColor = true;
            this.b_height_load_script.Click += new System.EventHandler(this.b_height_load_script_Click);
            // 
            // b_num_frames_load_script
            // 
            this.b_num_frames_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_num_frames_load_script.Location = new System.Drawing.Point(757, 642);
            this.b_num_frames_load_script.Name = "b_num_frames_load_script";
            this.b_num_frames_load_script.Size = new System.Drawing.Size(174, 23);
            this.b_num_frames_load_script.TabIndex = 21;
            this.b_num_frames_load_script.Text = "Total number of frames";
            this.b_num_frames_load_script.UseVisualStyleBackColor = true;
            this.b_num_frames_load_script.Click += new System.EventHandler(this.b_num_frames_load_script_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Placeholders";
            // 
            // b_cancel
            // 
            this.b_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(856, 698);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 24;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_done
            // 
            this.b_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_done.Location = new System.Drawing.Point(775, 698);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(75, 23);
            this.b_done.TabIndex = 23;
            this.b_done.Text = "Done";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // num_start_frame
            // 
            this.num_start_frame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_start_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_start_frame.Location = new System.Drawing.Point(79, 676);
            this.num_start_frame.Name = "num_start_frame";
            this.num_start_frame.Size = new System.Drawing.Size(111, 20);
            this.num_start_frame.TabIndex = 25;
            this.num_start_frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_end_frame
            // 
            this.num_end_frame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_end_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_end_frame.Location = new System.Drawing.Point(218, 676);
            this.num_end_frame.Name = "num_end_frame";
            this.num_end_frame.Size = new System.Drawing.Size(111, 20);
            this.num_end_frame.TabIndex = 26;
            this.num_end_frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_grab_num_frames
            // 
            this.b_grab_num_frames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_grab_num_frames.Location = new System.Drawing.Point(335, 673);
            this.b_grab_num_frames.Name = "b_grab_num_frames";
            this.b_grab_num_frames.Size = new System.Drawing.Size(75, 23);
            this.b_grab_num_frames.TabIndex = 27;
            this.b_grab_num_frames.Text = "From video";
            this.b_grab_num_frames.UseVisualStyleBackColor = true;
            this.b_grab_num_frames.Click += new System.EventHandler(this.b_grab_num_frames_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 678);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "to";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Frames from";
            // 
            // tb_args_load_script
            // 
            this.tb_args_load_script.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_args_load_script.Location = new System.Drawing.Point(12, 366);
            this.tb_args_load_script.Multiline = true;
            this.tb_args_load_script.Name = "tb_args_load_script";
            this.tb_args_load_script.Size = new System.Drawing.Size(739, 299);
            this.tb_args_load_script.TabIndex = 31;
            // 
            // ll_help_placeholders
            // 
            this.ll_help_placeholders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ll_help_placeholders.AutoSize = true;
            this.ll_help_placeholders.Location = new System.Drawing.Point(902, 365);
            this.ll_help_placeholders.Name = "ll_help_placeholders";
            this.ll_help_placeholders.Size = new System.Drawing.Size(29, 13);
            this.ll_help_placeholders.TabIndex = 32;
            this.ll_help_placeholders.TabStop = true;
            this.ll_help_placeholders.Text = "Help";
            this.ll_help_placeholders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_help_placeholders_LinkClicked);
            // 
            // b_skip
            // 
            this.b_skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_skip.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_skip.Location = new System.Drawing.Point(694, 698);
            this.b_skip.Name = "b_skip";
            this.b_skip.Size = new System.Drawing.Size(75, 23);
            this.b_skip.TabIndex = 33;
            this.b_skip.Text = "Skip";
            this.b_skip.UseVisualStyleBackColor = true;
            this.b_skip.Visible = false;
            this.b_skip.Click += new System.EventHandler(this.b_skip_Click);
            // 
            // tb_vpy_av
            // 
            this.tb_vpy_av.AllowDrop = true;
            this.tb_vpy_av.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_vpy_av.Location = new System.Drawing.Point(199, 43);
            this.tb_vpy_av.Name = "tb_vpy_av";
            this.tb_vpy_av.Size = new System.Drawing.Size(732, 20);
            this.tb_vpy_av.TabIndex = 35;
            this.tb_vpy_av.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_vpy_av_DragDrop);
            this.tb_vpy_av.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_vpy_av_DragEnter);
            // 
            // b_load_script_av
            // 
            this.b_load_script_av.Location = new System.Drawing.Point(12, 41);
            this.b_load_script_av.Name = "b_load_script_av";
            this.b_load_script_av.Size = new System.Drawing.Size(178, 23);
            this.b_load_script_av.TabIndex = 34;
            this.b_load_script_av.Text = "Browse VPY for AVScenechange";
            this.b_load_script_av.UseVisualStyleBackColor = true;
            this.b_load_script_av.Click += new System.EventHandler(this.b_load_script_av_Click);
            // 
            // b_audio
            // 
            this.b_audio.Location = new System.Drawing.Point(12, 88);
            this.b_audio.Name = "b_audio";
            this.b_audio.Size = new System.Drawing.Size(178, 38);
            this.b_audio.TabIndex = 37;
            this.b_audio.Text = "Audio tracks";
            this.b_audio.UseVisualStyleBackColor = true;
            this.b_audio.Click += new System.EventHandler(this.b_audio_Click);
            // 
            // tv_audiotracks
            // 
            this.tv_audiotracks.AllowDrop = true;
            this.tv_audiotracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_audiotracks.Location = new System.Drawing.Point(199, 69);
            this.tv_audiotracks.Name = "tv_audiotracks";
            this.tv_audiotracks.Size = new System.Drawing.Size(732, 210);
            this.tv_audiotracks.TabIndex = 38;
            this.tv_audiotracks.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_audiotracks_NodeMouseClick);
            this.tv_audiotracks.DragDrop += new System.Windows.Forms.DragEventHandler(this.tv_audio_DragDrop);
            this.tv_audiotracks.DragEnter += new System.Windows.Forms.DragEventHandler(this.tv_audio_DragEnter);
            // 
            // b_expand_tv
            // 
            this.b_expand_tv.Location = new System.Drawing.Point(12, 132);
            this.b_expand_tv.Name = "b_expand_tv";
            this.b_expand_tv.Size = new System.Drawing.Size(75, 23);
            this.b_expand_tv.TabIndex = 39;
            this.b_expand_tv.Text = "Expand all";
            this.b_expand_tv.UseVisualStyleBackColor = true;
            this.b_expand_tv.Click += new System.EventHandler(this.b_expand_tv_Click);
            // 
            // b_collapse_tv
            // 
            this.b_collapse_tv.Location = new System.Drawing.Point(115, 132);
            this.b_collapse_tv.Name = "b_collapse_tv";
            this.b_collapse_tv.Size = new System.Drawing.Size(75, 23);
            this.b_collapse_tv.TabIndex = 40;
            this.b_collapse_tv.Text = "Collapse all";
            this.b_collapse_tv.UseVisualStyleBackColor = true;
            this.b_collapse_tv.Click += new System.EventHandler(this.b_collapse_tv_Click);
            // 
            // b_remove_audiosource
            // 
            this.b_remove_audiosource.Location = new System.Drawing.Point(12, 172);
            this.b_remove_audiosource.Name = "b_remove_audiosource";
            this.b_remove_audiosource.Size = new System.Drawing.Size(75, 37);
            this.b_remove_audiosource.TabIndex = 41;
            this.b_remove_audiosource.Text = "Remove selected";
            this.b_remove_audiosource.UseVisualStyleBackColor = true;
            this.b_remove_audiosource.Click += new System.EventHandler(this.b_remove_audiosource_Click);
            // 
            // LoadScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 733);
            this.Controls.Add(this.b_remove_audiosource);
            this.Controls.Add(this.b_collapse_tv);
            this.Controls.Add(this.b_expand_tv);
            this.Controls.Add(this.tv_audiotracks);
            this.Controls.Add(this.b_audio);
            this.Controls.Add(this.tb_vpy_av);
            this.Controls.Add(this.b_load_script_av);
            this.Controls.Add(this.b_skip);
            this.Controls.Add(this.ll_help_placeholders);
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
            this.MinimizeBox = false;
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
        private System.Windows.Forms.LinkLabel ll_help_placeholders;
        private System.Windows.Forms.Button b_skip;
        private System.Windows.Forms.TextBox tb_vpy_av;
        private System.Windows.Forms.Button b_load_script_av;
        private System.Windows.Forms.Button b_audio;
        private System.Windows.Forms.TreeView tv_audiotracks;
        private System.Windows.Forms.Button b_expand_tv;
        private System.Windows.Forms.Button b_collapse_tv;
        private System.Windows.Forms.Button b_remove_audiosource;
    }
}