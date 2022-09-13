using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp快捷程序可视化
{
    public partial class Game_add_Form : Form
    {
        public string FilePath;
        public string AppName;
        public Game_add_Form()
        {
            FilePath = "";
            AppName = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Title = "请选择应用";
            dialog.Filter = "应用(*.exe;*.Lnk;*.url)|*.exe;*.Lnk;*.url";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取选择的文件路径,并显示添加的应用名称
                FilePath = dialog.FileName;
                label1.Visible = true;
                textBox1.Visible = true;
                int index_last = FilePath.LastIndexOf("\\");
                AppName = FilePath.Substring(index_last+1,FilePath.Length-index_last-5);
                textBox1.Text = AppName;//显示应用名
            }
            
        }
        private void exit_Click(object sender, EventArgs e)
        {
            FilePath = "";
            Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            AppName = textBox1.Text;
            Close();
        }
    }
}
