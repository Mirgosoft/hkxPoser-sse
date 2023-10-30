namespace hkxPoser
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                viewer.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox_ShowBones = new System.Windows.Forms.CheckBox();
            this.button_PlayPausePlayback = new System.Windows.Forms.Button();
            this.numericUpDown_MaxFPS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TotalFrames = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.label_CurrentFrame = new System.Windows.Forms.Label();
            this.checkBox_SmoothFrames = new System.Windows.Forms.CheckBox();
            this.label_FPS = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_OpenPrevFile = new System.Windows.Forms.Button();
            this.button_OpenNextFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Update
            // 
            this.timer_Update.Interval = 32;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(12, 419);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(647, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseMove);
            // 
            // checkBox_ShowBones
            // 
            this.checkBox_ShowBones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_ShowBones.AutoSize = true;
            this.checkBox_ShowBones.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowBones.Checked = true;
            this.checkBox_ShowBones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowBones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowBones.Location = new System.Drawing.Point(7, 360);
            this.checkBox_ShowBones.Name = "checkBox_ShowBones";
            this.checkBox_ShowBones.Size = new System.Drawing.Size(112, 20);
            this.checkBox_ShowBones.TabIndex = 2;
            this.checkBox_ShowBones.Text = "Show Bones";
            this.checkBox_ShowBones.UseVisualStyleBackColor = false;
            this.checkBox_ShowBones.CheckedChanged += new System.EventHandler(this.checkBox_ShowBones_CheckedChanged);
            // 
            // button_PlayPausePlayback
            // 
            this.button_PlayPausePlayback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_PlayPausePlayback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayPausePlayback.Location = new System.Drawing.Point(7, 385);
            this.button_PlayPausePlayback.Name = "button_PlayPausePlayback";
            this.button_PlayPausePlayback.Size = new System.Drawing.Size(70, 29);
            this.button_PlayPausePlayback.TabIndex = 3;
            this.button_PlayPausePlayback.Text = "Play";
            this.button_PlayPausePlayback.UseVisualStyleBackColor = true;
            this.button_PlayPausePlayback.Click += new System.EventHandler(this.button_PlayPauseAnim_Click);
            // 
            // numericUpDown_MaxFPS
            // 
            this.numericUpDown_MaxFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_MaxFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_MaxFPS.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_MaxFPS.Location = new System.Drawing.Point(9, 309);
            this.numericUpDown_MaxFPS.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDown_MaxFPS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_MaxFPS.Name = "numericUpDown_MaxFPS";
            this.numericUpDown_MaxFPS.Size = new System.Drawing.Size(57, 26);
            this.numericUpDown_MaxFPS.TabIndex = 4;
            this.numericUpDown_MaxFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_MaxFPS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_MaxFPS.ValueChanged += new System.EventHandler(this.numericUpDown_MaxFPS_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max FPS";
            // 
            // label_TotalFrames
            // 
            this.label_TotalFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TotalFrames.AutoSize = true;
            this.label_TotalFrames.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalFrames.Location = new System.Drawing.Point(333, 3);
            this.label_TotalFrames.Name = "label_TotalFrames";
            this.label_TotalFrames.Size = new System.Drawing.Size(84, 18);
            this.label_TotalFrames.TabIndex = 6;
            this.label_TotalFrames.Text = "Frames: 0";
            // 
            // label_Duration
            // 
            this.label_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Duration.AutoSize = true;
            this.label_Duration.BackColor = System.Drawing.Color.Transparent;
            this.label_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Duration.Location = new System.Drawing.Point(455, 3);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(91, 18);
            this.label_Duration.TabIndex = 7;
            this.label_Duration.Text = "Duration: 0";
            // 
            // label_CurrentFrame
            // 
            this.label_CurrentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CurrentFrame.AutoSize = true;
            this.label_CurrentFrame.BackColor = System.Drawing.Color.Transparent;
            this.label_CurrentFrame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentFrame.Location = new System.Drawing.Point(77, 388);
            this.label_CurrentFrame.Name = "label_CurrentFrame";
            this.label_CurrentFrame.Size = new System.Drawing.Size(20, 22);
            this.label_CurrentFrame.TabIndex = 8;
            this.label_CurrentFrame.Text = "0";
            // 
            // checkBox_SmoothFrames
            // 
            this.checkBox_SmoothFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_SmoothFrames.AutoSize = true;
            this.checkBox_SmoothFrames.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SmoothFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SmoothFrames.Location = new System.Drawing.Point(7, 335);
            this.checkBox_SmoothFrames.Name = "checkBox_SmoothFrames";
            this.checkBox_SmoothFrames.Size = new System.Drawing.Size(100, 20);
            this.checkBox_SmoothFrames.TabIndex = 9;
            this.checkBox_SmoothFrames.Text = "Smoothing";
            this.checkBox_SmoothFrames.UseVisualStyleBackColor = false;
            this.checkBox_SmoothFrames.CheckedChanged += new System.EventHandler(this.checkBox_SmoothFrames_CheckedChanged);
            // 
            // label_FPS
            // 
            this.label_FPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FPS.AutoSize = true;
            this.label_FPS.BackColor = System.Drawing.Color.Transparent;
            this.label_FPS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FPS.Location = new System.Drawing.Point(-1, 278);
            this.label_FPS.Name = "label_FPS";
            this.label_FPS.Size = new System.Drawing.Size(54, 19);
            this.label_FPS.TabIndex = 10;
            this.label_FPS.Text = "FPS: ";
            // 
            // button_OpenPrevFile
            // 
            this.button_OpenPrevFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_OpenPrevFile.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenPrevFile.Location = new System.Drawing.Point(126, 383);
            this.button_OpenPrevFile.Name = "button_OpenPrevFile";
            this.button_OpenPrevFile.Size = new System.Drawing.Size(42, 32);
            this.button_OpenPrevFile.TabIndex = 11;
            this.button_OpenPrevFile.Text = "|<";
            this.button_OpenPrevFile.UseVisualStyleBackColor = true;
            this.button_OpenPrevFile.Click += new System.EventHandler(this.button_OpenPrevFile_Click);
            // 
            // button_OpenNextFile
            // 
            this.button_OpenNextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_OpenNextFile.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenNextFile.Location = new System.Drawing.Point(174, 383);
            this.button_OpenNextFile.Name = "button_OpenNextFile";
            this.button_OpenNextFile.Size = new System.Drawing.Size(42, 32);
            this.button_OpenNextFile.TabIndex = 12;
            this.button_OpenNextFile.Text = ">|";
            this.button_OpenNextFile.UseVisualStyleBackColor = true;
            this.button_OpenNextFile.Click += new System.EventHandler(this.button_OpenNextFile_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.button_OpenNextFile);
            this.Controls.Add(this.button_OpenPrevFile);
            this.Controls.Add(this.numericUpDown_MaxFPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_FPS);
            this.Controls.Add(this.checkBox_SmoothFrames);
            this.Controls.Add(this.button_PlayPausePlayback);
            this.Controls.Add(this.label_CurrentFrame);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_TotalFrames);
            this.Controls.Add(this.checkBox_ShowBones);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "hkxPoser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxFPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox_ShowBones;
        private System.Windows.Forms.Button button_PlayPausePlayback;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxFPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TotalFrames;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.Label label_CurrentFrame;
        private System.Windows.Forms.CheckBox checkBox_SmoothFrames;
        private System.Windows.Forms.Label label_FPS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_OpenPrevFile;
        private System.Windows.Forms.Button button_OpenNextFile;
    }
}

