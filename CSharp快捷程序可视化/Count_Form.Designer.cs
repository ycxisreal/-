namespace CSharp快捷程序可视化
{
    partial class Count_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Count_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.G_button = new System.Windows.Forms.Button();
            this.W_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "统计信息";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(37, 385);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(119, 37);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "知道了";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(162, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(368, 366);
            this.textBox1.TabIndex = 2;
            this.textBox1.WordWrap = false;
            // 
            // G_button
            // 
            this.G_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.G_button.Location = new System.Drawing.Point(37, 56);
            this.G_button.Name = "G_button";
            this.G_button.Size = new System.Drawing.Size(112, 48);
            this.G_button.TabIndex = 3;
            this.G_button.Text = "看应用";
            this.G_button.UseVisualStyleBackColor = true;
            this.G_button.Click += new System.EventHandler(this.G_button_Click);
            // 
            // W_button
            // 
            this.W_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.W_button.Location = new System.Drawing.Point(37, 119);
            this.W_button.Name = "W_button";
            this.W_button.Size = new System.Drawing.Size(112, 49);
            this.W_button.TabIndex = 4;
            this.W_button.Text = "看网站";
            this.W_button.UseVisualStyleBackColor = true;
            this.W_button.Click += new System.EventHandler(this.W_button_Click);
            // 
            // Count_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(542, 434);
            this.ControlBox = false;
            this.Controls.Add(this.W_button);
            this.Controls.Add(this.G_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Name = "Count_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button exit_button;
        private TextBox textBox1;
        private Button G_button;
        private Button W_button;
    }
}