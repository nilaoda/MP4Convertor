namespace MP4Convertor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.filelist = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFile = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.OutPath = new System.Windows.Forms.Label();
            this.checkBox_qtcs = new System.Windows.Forms.CheckBox();
            this.checkBox_allstream = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.Label();
            this.OutName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_movflags = new System.Windows.Forms.CheckBox();
            this.checkBox_meta = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_copyright = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(575, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 26);
            this.button3.TabIndex = 104;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_Title.Location = new System.Drawing.Point(12, 4);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(270, 22);
            this.label_Title.TabIndex = 106;
            this.label_Title.Text = "MP4 Convertor 0.1  by：nilaoda";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            // 
            // filelist
            // 
            this.filelist.AllowDrop = true;
            this.filelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.filelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filelist.Cursor = System.Windows.Forms.Cursors.Default;
            this.filelist.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.filelist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filelist.FormattingEnabled = true;
            this.filelist.ItemHeight = 17;
            this.filelist.Location = new System.Drawing.Point(12, 50);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(644, 206);
            this.filelist.TabIndex = 107;
            this.filelist.DragDrop += new System.Windows.Forms.DragEventHandler(this.filelist_DragDrop);
            this.filelist.DragEnter += new System.Windows.Forms.DragEventHandler(this.filelist_DragEnter);
            this.filelist.DragOver += new System.Windows.Forms.DragEventHandler(this.filelist_DragOver);
            this.filelist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.删除全部ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 删除全部ToolStripMenuItem
            // 
            this.删除全部ToolStripMenuItem.Name = "删除全部ToolStripMenuItem";
            this.删除全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除全部ToolStripMenuItem.Text = "删除全部";
            this.删除全部ToolStripMenuItem.Click += new System.EventHandler(this.删除全部ToolStripMenuItem_Click);
            // 
            // AddFile
            // 
            this.AddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddFile.FlatAppearance.BorderSize = 0;
            this.AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddFile.ForeColor = System.Drawing.Color.White;
            this.AddFile.Location = new System.Drawing.Point(430, 355);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(110, 24);
            this.AddFile.TabIndex = 108;
            this.AddFile.Text = "添加视频文件";
            this.AddFile.UseVisualStyleBackColor = false;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // Convert
            // 
            this.Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Convert.FlatAppearance.BorderSize = 0;
            this.Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Convert.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Convert.ForeColor = System.Drawing.Color.White;
            this.Convert.Location = new System.Drawing.Point(546, 355);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(110, 24);
            this.Convert.TabIndex = 109;
            this.Convert.Text = "开始转换";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // OutPath
            // 
            this.OutPath.AutoSize = true;
            this.OutPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutPath.Location = new System.Drawing.Point(311, 18);
            this.OutPath.Name = "OutPath";
            this.OutPath.Size = new System.Drawing.Size(47, 12);
            this.OutPath.TabIndex = 110;
            this.OutPath.Text = "OutPath";
            this.OutPath.Visible = false;
            // 
            // checkBox_qtcs
            // 
            this.checkBox_qtcs.AutoSize = true;
            this.checkBox_qtcs.Checked = true;
            this.checkBox_qtcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_qtcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_qtcs.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_qtcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBox_qtcs.Location = new System.Drawing.Point(16, 358);
            this.checkBox_qtcs.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_qtcs.Name = "checkBox_qtcs";
            this.checkBox_qtcs.Size = new System.Drawing.Size(145, 21);
            this.checkBox_qtcs.TabIndex = 112;
            this.checkBox_qtcs.Text = "-bsf:a aac_adtstoasc";
            this.checkBox_qtcs.UseVisualStyleBackColor = true;
            this.checkBox_qtcs.CheckedChanged += new System.EventHandler(this.checkBox_qtcs_CheckedChanged);
            // 
            // checkBox_allstream
            // 
            this.checkBox_allstream.AutoSize = true;
            this.checkBox_allstream.Checked = true;
            this.checkBox_allstream.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_allstream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_allstream.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_allstream.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBox_allstream.Location = new System.Drawing.Point(165, 358);
            this.checkBox_allstream.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_allstream.Name = "checkBox_allstream";
            this.checkBox_allstream.Size = new System.Drawing.Size(111, 21);
            this.checkBox_allstream.TabIndex = 113;
            this.checkBox_allstream.Text = "保留所有视音轨";
            this.checkBox_allstream.UseVisualStyleBackColor = true;
            this.checkBox_allstream.CheckedChanged += new System.EventHandler(this.checkBox_allstream_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(13, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "注意：*可直接拖入视频    *输出目录为所选文件夹的子目录 MP4 Convertor.";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Command.Location = new System.Drawing.Point(311, 30);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(47, 12);
            this.Command.TabIndex = 117;
            this.Command.Text = "Command";
            this.Command.Visible = false;
            // 
            // OutName
            // 
            this.OutName.AutoSize = true;
            this.OutName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutName.Location = new System.Drawing.Point(311, 4);
            this.OutName.Name = "OutName";
            this.OutName.Size = new System.Drawing.Size(47, 12);
            this.OutName.TabIndex = 118;
            this.OutName.Text = "OutName";
            this.OutName.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox1.Location = new System.Drawing.Point(12, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(644, 82);
            this.textBox1.TabIndex = 119;
            this.textBox1.Text = "请在下方进行操作...";
            // 
            // checkBox_movflags
            // 
            this.checkBox_movflags.AutoSize = true;
            this.checkBox_movflags.Checked = true;
            this.checkBox_movflags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_movflags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_movflags.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_movflags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBox_movflags.Location = new System.Drawing.Point(280, 358);
            this.checkBox_movflags.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_movflags.Name = "checkBox_movflags";
            this.checkBox_movflags.Size = new System.Drawing.Size(111, 21);
            this.checkBox_movflags.TabIndex = 120;
            this.checkBox_movflags.Text = "使之能边下边看";
            this.checkBox_movflags.UseVisualStyleBackColor = true;
            this.checkBox_movflags.CheckedChanged += new System.EventHandler(this.checkBox_movflags_CheckedChanged);
            // 
            // checkBox_meta
            // 
            this.checkBox_meta.AutoSize = true;
            this.checkBox_meta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_meta.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_meta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.checkBox_meta.Location = new System.Drawing.Point(16, 390);
            this.checkBox_meta.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_meta.Name = "checkBox_meta";
            this.checkBox_meta.Size = new System.Drawing.Size(123, 21);
            this.checkBox_meta.TabIndex = 121;
            this.checkBox_meta.Text = "为视频添加元数据";
            this.checkBox_meta.UseVisualStyleBackColor = true;
            this.checkBox_meta.CheckedChanged += new System.EventHandler(this.checkBox_meta_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(139, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "标题";
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_title.Enabled = false;
            this.textBox_title.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.textBox_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_title.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_title.Location = new System.Drawing.Point(177, 391);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(130, 22);
            this.textBox_title.TabIndex = 123;
            // 
            // textBox_copyright
            // 
            this.textBox_copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_copyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_copyright.Enabled = false;
            this.textBox_copyright.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.textBox_copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_copyright.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_copyright.Location = new System.Drawing.Point(351, 390);
            this.textBox_copyright.Name = "textBox_copyright";
            this.textBox_copyright.Size = new System.Drawing.Size(130, 22);
            this.textBox_copyright.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(313, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = "版权";
            // 
            // textBox_comment
            // 
            this.textBox_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_comment.Enabled = false;
            this.textBox_comment.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.textBox_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_comment.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_comment.Location = new System.Drawing.Point(526, 390);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(130, 22);
            this.textBox_comment.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(487, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "描述";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 128;
            this.button1.Text = "MIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(537, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 129;
            this.label5.Text = "2017/2/25 最后编译";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_copyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_meta);
            this.Controls.Add(this.checkBox_movflags);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutName);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_allstream);
            this.Controls.Add(this.checkBox_qtcs);
            this.Controls.Add(this.OutPath);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListBox filelist;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label OutPath;
        private System.Windows.Forms.CheckBox checkBox_qtcs;
        private System.Windows.Forms.CheckBox checkBox_allstream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Command;
        private System.Windows.Forms.Label OutName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_movflags;
        private System.Windows.Forms.CheckBox checkBox_meta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除全部ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_copyright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

