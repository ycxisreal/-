using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CSharp快捷程序可视化
{
    public partial class File_Form : Form
    {
        List<Label> labels = new List<Label>();
        List<Button> A_buttons = new List<Button>(); 
        public List<Myfile> files = new List<Myfile>();
        public File_Form()
        {
            
            InitializeComponent();
            A_Buttons_ini();
            Labels_ini();
        }
        public void A_Buttons_ini()
        {
            A_buttons.Add(S1);
            A_buttons.Add(S2);
            A_buttons.Add(S3);
            A_buttons.Add(S4);
            A_buttons.Add(S5);
            A_buttons.Add(S6);
            A_buttons.Add(S7);
        }
        public void Labels_ini()
        {
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
        }
        private void Add_click(int Index)
        {
            string FolderPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "选择目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取选择的目录路径
                FolderPath = dialog.SelectedPath;
                labels[Index - 1].Visible = true;
                A_buttons[Index - 1].Visible = true;
                Myfile temp =new Myfile(FolderPath,Index);

                files.Add(temp);
                int index_last = FolderPath.LastIndexOf("\\");
                labels[Index-1].Text = FolderPath.Substring(index_last+1);
            }
        }
        //添加按钮集合
        private void b1_Click(object sender, EventArgs e)
        {
            Add_click(1);

        }
        private void b2_Click(object sender, EventArgs e)
        {
            Add_click(2);
        }
        private void b3_Click(object sender, EventArgs e)
        {
            Add_click(3);
        }
        private void b4_Click(object sender, EventArgs e)
        {
            Add_click(4);
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Add_click(5);
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Add_click(6);
        }
        private void b7_Click(object sender, EventArgs e)
        {
            Add_click(7);
        }
        //启动按钮集合
        private void S1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[0].path);
        }
        private void S2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[1].path);
        }
        private void S3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[2].path);
        }
        private void S4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[3].path);
        }
        private void S5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[4].path);
        }
        private void S6_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[5].path);
        }
        private void S7_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", files[6].path);
        }
    }
    public class Myfile
    {
        public string path;
        public int num;
        public Myfile()
        {
            path = "";
            num = 0;
        }
        public Myfile(string path, int num)
        {
            this.path = path;
            this.num = num;
        }
    }
}
