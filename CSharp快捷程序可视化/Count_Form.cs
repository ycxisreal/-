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
    public partial class Count_Form : Form
    {
        public List<Main_Form.G> gs = new List<Main_Form.G>();
        public List<Main_Form.W> ws = new List<Main_Form.W>();
        public Count_Form(List<Main_Form.G> a,List<Main_Form.W> b)
        {
            textBox1 = new TextBox();
            foreach(Main_Form.G g in a)
                gs.Add(g);
            foreach(Main_Form.W w in b)
                ws.Add(w);
            gs.Sort((x,y)=>y.times.CompareTo(x.times));
            ws.Sort((x,y)=>y.times.CompareTo(x.times));
            InitializeComponent();
        }
        private void G_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach(Main_Form.G i in gs)
                textBox1.Text += "使用次数：" + i.times + "次 | " + i.name + "\r\n";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void W_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach(Main_Form.W i in ws)
                textBox1.Text+= "使用次数：" + i.times + "次 | " + i.name + "\r\n";
        }
    }
}
