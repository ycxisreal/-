namespace CSharp快捷程序可视化
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.GameButton = new System.Windows.Forms.Button();
            this.WebButton = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.webpath = new System.Windows.Forms.LinkLabel();
            this.常用文件夹 = new System.Windows.Forms.Button();
            this.统计按钮 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // GameButton
            // 
            this.GameButton.BackColor = System.Drawing.Color.Transparent;
            this.GameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameButton.Location = new System.Drawing.Point(24, 93);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(168, 60);
            this.GameButton.TabIndex = 0;
            this.GameButton.Text = "button1";
            this.GameButton.UseVisualStyleBackColor = false;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // WebButton
            // 
            this.WebButton.BackColor = System.Drawing.Color.Transparent;
            this.WebButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebButton.Location = new System.Drawing.Point(24, 195);
            this.WebButton.Name = "WebButton";
            this.WebButton.Size = new System.Drawing.Size(168, 60);
            this.WebButton.TabIndex = 1;
            this.WebButton.Text = "button1";
            this.WebButton.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Location = new System.Drawing.Point(229, 93);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(168, 60);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            // 
            // webpath
            // 
            this.webpath.AutoSize = true;
            this.webpath.BackColor = System.Drawing.Color.Transparent;
            this.webpath.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.webpath.LinkColor = System.Drawing.Color.Black;
            this.webpath.Location = new System.Drawing.Point(12, 638);
            this.webpath.Name = "webpath";
            this.webpath.Size = new System.Drawing.Size(180, 28);
            this.webpath.TabIndex = 3;
            this.webpath.TabStop = true;
            this.webpath.Text = "杨春潇的哔站空间";
            this.webpath.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.webpath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // 常用文件夹
            // 
            this.常用文件夹.BackColor = System.Drawing.Color.Transparent;
            this.常用文件夹.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.常用文件夹.Location = new System.Drawing.Point(229, 195);
            this.常用文件夹.Name = "常用文件夹";
            this.常用文件夹.Size = new System.Drawing.Size(168, 60);
            this.常用文件夹.TabIndex = 4;
            this.常用文件夹.Text = "文件夹选项";
            this.常用文件夹.UseVisualStyleBackColor = false;
            // 
            // 统计按钮
            // 
            this.统计按钮.BackColor = System.Drawing.Color.Transparent;
            this.统计按钮.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.统计按钮.Location = new System.Drawing.Point(24, 294);
            this.统计按钮.Name = "统计按钮";
            this.统计按钮.Size = new System.Drawing.Size(168, 60);
            this.统计按钮.TabIndex = 5;
            this.统计按钮.Text = "统计信息";
            this.统计按钮.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(12, 610);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(84, 28);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GitHub";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 675);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.统计按钮);
            this.Controls.Add(this.常用文件夹);
            this.Controls.Add(this.webpath);
            this.Controls.Add(this.About);
            this.Controls.Add(this.WebButton);
            this.Controls.Add(this.GameButton);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ycx的快捷程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GameButton;
        private Button WebButton;
        private Button About;
        private LinkLabel webpath;
        private Button 常用文件夹;
        private Button 统计按钮;
        private LinkLabel linkLabel2;
    }
}