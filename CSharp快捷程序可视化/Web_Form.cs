using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
namespace CSharp快捷程序可视化
{
    public partial class Web_Form : Form
    {
        public List<Web> webs = new List<Web>();
        public ArrayList W_name=new ArrayList();
        public Web_Form()
        {
            InitializeComponent();
            initial();
            foreach (Web web in webs)
                W_name.Add(web.name);
            show_web();
            datasource_update();
        }
        public void initial()
        {
            StreamReader sr = new StreamReader("web.txt", Encoding.Default);
            string line;
            string name = "";
            string url = "";
            int timer = 1;
            while((line=sr.ReadLine())!=null)
            {
                if (timer % 3 == 1)
                    name = line;
                else if (timer % 3 == 2)
                    url = line;
                else
                    webs.Add(new Web(name, url, Convert.ToInt32(line)));
                timer++;
            }
            sr.Close();
        }
        public void show_web()
        {
            textBox1.Clear();
            foreach(string name in W_name)
                textBox1.Text+=name+"\r\n";
        }
        private void add_Click(object sender, EventArgs e)
        {
            
            Web_add_Form web_Add_Form = new Web_add_Form();
            web_Add_Form.ShowDialog();
            if (web_Add_Form.name != "")
            {
                webs.Add(new Web(web_Add_Form.name, web_Add_Form.url, 0));
                W_name.Add(web_Add_Form.name);
                datasource_update();
            }
            show_web();
        }
        public void datasource_update()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = W_name;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("还没有添加网站！");
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("未选择网站！");
                return;
            }
            int Index=comboBox1.SelectedIndex;
            Process.Start("explorer.exe", webs[Index].url);
            webs[Index].times++;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("还没有添加网站！");
                return;
            }else if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("未选择网站!");
            }
            int Index = comboBox1.SelectedIndex;
            W_name.RemoveAt(Index);
            webs.RemoveAt(Index);
            show_web();
            datasource_update();
        }

        private void Web_Form_Load(object sender, EventArgs e)
        {

        }
    }
    public class Web
    {
        public string name;
        public string url;
        public int times;
        public Web(string name, string url, int times)
        {
            this.name = name;
            this.url = url;
            this.times = times;
        }   
    }
    
}
