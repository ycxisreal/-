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
            initialize();
        }
        //1
        public void initialize()//读取文件中的信息
        {
            StreamReader sr = new StreamReader("file.txt",Encoding.Default);
            string line;
            string path = "";
            int timer = 1;
            while((line = sr.ReadLine()) != null)
            {
                if (timer % 2 == 1)
                    path = line;
                else
                {
                    files.Add(new Myfile(path, Convert.ToInt32(line)));
                    int Index=Convert.ToInt32(line);
                    labels[Index - 1].Visible = true;
                    A_buttons[Index - 1].Visible = true;
                    int index_last = path.LastIndexOf("\\");
                    labels[Index - 1].Text = path.Substring(index_last + 1);
                }
                timer++;
            }
            sr.Close();
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
                bool if_exsist = false;
                int exsist_index=0;
                //获取选择的目录路径
                FolderPath = dialog.SelectedPath;
                labels[Index - 1].Visible = true;
                A_buttons[Index - 1].Visible = true;
                Myfile temp =new Myfile(FolderPath,Index);
                foreach(Myfile a in files)//判断是否为第一次添加
                {
                    if (a.num == Index)
                    {
                        if_exsist = true;
                        exsist_index = files.IndexOf(a);
                    }
                }
                if (if_exsist)//替换
                    files[exsist_index] = temp;
                else
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
            int index = 0;
            foreach(Myfile a in files)
            {
                if(a.num==1)
                    index=files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S2_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 2)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S3_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 3)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S4_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 4)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S5_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 5)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S6_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 6)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
        }
        private void S7_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Myfile a in files)
            {
                if (a.num == 7)
                    index = files.IndexOf(a);
            }
            Process.Start("explorer.exe", files[index].path);
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
