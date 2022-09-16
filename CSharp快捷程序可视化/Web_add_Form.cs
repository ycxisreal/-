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
    public partial class Web_add_Form : Form
    {
        public string name;
        public string url;
        public Web_add_Form()
        {
            name = "";
            url = "";
            //nameBox.Text = "";
            //webBox.Text = "";
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length==0 || webBox.Text.Length==0)
            {
                MessageBox.Show("请将网址及网址名填写完整！");
                return;
            }
            name=nameBox.Text;
            url = webBox.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
