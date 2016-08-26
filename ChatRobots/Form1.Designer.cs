namespace ChatRobots
{
    partial class 聊天机器人
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(聊天机器人));
            this.button_sent = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.richTextBox_sent = new System.Windows.Forms.RichTextBox();
            this.richTextBox1_accept = new System.Windows.Forms.RichTextBox();
            this.button1_teaching = new System.Windows.Forms.Button();
            this.label1_robot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sent
            // 
            this.button_sent.BackColor = System.Drawing.Color.Azure;
            this.button_sent.BackgroundImage = global::ChatRobots.Properties.Resources.bt;
            this.button_sent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_sent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sent.ForeColor = System.Drawing.Color.White;
            this.button_sent.Location = new System.Drawing.Point(455, 449);
            this.button_sent.Name = "button_sent";
            this.button_sent.Size = new System.Drawing.Size(111, 26);
            this.button_sent.TabIndex = 2;
            this.button_sent.Text = "发送";
            this.button_sent.UseVisualStyleBackColor = false;
            this.button_sent.Click += new System.EventHandler(this.button_sent_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Turquoise;
            this.button_exit.BackgroundImage = global::ChatRobots.Properties.Resources.bt;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(365, 449);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(85, 26);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // richTextBox_sent
            // 
            this.richTextBox_sent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_sent.Location = new System.Drawing.Point(12, 376);
            this.richTextBox_sent.Name = "richTextBox_sent";
            this.richTextBox_sent.Size = new System.Drawing.Size(554, 95);
            this.richTextBox_sent.TabIndex = 6;
            this.richTextBox_sent.Text = "";
            // 
            // richTextBox1_accept
            // 
            this.richTextBox1_accept.BackColor = System.Drawing.Color.White;
            this.richTextBox1_accept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1_accept.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1_accept.Location = new System.Drawing.Point(12, 112);
            this.richTextBox1_accept.Name = "richTextBox1_accept";
            this.richTextBox1_accept.ReadOnly = true;
            this.richTextBox1_accept.Size = new System.Drawing.Size(554, 247);
            this.richTextBox1_accept.TabIndex = 7;
            this.richTextBox1_accept.Text = "";
            // 
            // button1_teaching
            // 
            this.button1_teaching.BackgroundImage = global::ChatRobots.Properties.Resources.bt;
            this.button1_teaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_teaching.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1_teaching.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1_teaching.ForeColor = System.Drawing.Color.White;
            this.button1_teaching.Location = new System.Drawing.Point(149, 83);
            this.button1_teaching.Name = "button1_teaching";
            this.button1_teaching.Size = new System.Drawing.Size(79, 26);
            this.button1_teaching.TabIndex = 8;
            this.button1_teaching.Text = "调教";
            this.button1_teaching.UseVisualStyleBackColor = true;
            this.button1_teaching.Click += new System.EventHandler(this.button1_teaching_Click);
            // 
            // label1_robot
            // 
            this.label1_robot.AutoSize = true;
            this.label1_robot.BackColor = System.Drawing.Color.LightGray;
            this.label1_robot.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_robot.Location = new System.Drawing.Point(102, 24);
            this.label1_robot.Name = "label1_robot";
            this.label1_robot.Size = new System.Drawing.Size(41, 20);
            this.label1_robot.TabIndex = 9;
            this.label1_robot.Text = "小A";
            this.label1_robot.Click += new System.EventHandler(this.label1_robot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = " 我是你的聊天机器人，无论你喜欢不喜欢我，我都喜欢你。。。";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChatRobots.Properties.Resources.DCV;
            this.pictureBox3.Location = new System.Drawing.Point(566, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatRobots.Properties.Resources._20;
            this.pictureBox2.Location = new System.Drawing.Point(566, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatRobots.Properties.Resources.pstop;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::ChatRobots.Properties.Resources.x11;
            this.pictureBox4.Location = new System.Drawing.Point(722, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::ChatRobots.Properties.Resources.bt2;
            this.label2.Location = new System.Drawing.Point(70, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "导入词库";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "女  18岁";
            // 
            // 聊天机器人
            // 
            this.AcceptButton = this.button_sent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChatRobots.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(750, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_robot);
            this.Controls.Add(this.button1_teaching);
            this.Controls.Add(this.richTextBox1_accept);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_sent);
            this.Controls.Add(this.richTextBox_sent);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "聊天机器人";
            this.Text = "聊天机器人";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.聊天机器人_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.聊天机器人_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.聊天机器人_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sent;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.RichTextBox richTextBox_sent;
        private System.Windows.Forms.RichTextBox richTextBox1_accept;
        private System.Windows.Forms.Button button1_teaching;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1_robot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

