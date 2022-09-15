namespace CSharp快捷程序可视化
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    public partial class Main_Form : Form
    {
        List<G> times_G = new List<G>();
        public class G
        {
            public string name;
            public int times;
            public G(string n, int m)
            {
                name = n; times = m;
            }
        }
        public Main_Form()
        {
            InitializeComponent();
            
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            Game_Form game_Form = new Game_Form();
            game_Form.ShowDialog();
            //储存信息
            FileStream fs=new FileStream("game.txt",FileMode.Create);
            fs.Close();
            StreamWriter sr = new StreamWriter("game.txt");
            foreach (Game a in game_Form.games)
            {
                sr.WriteLine(a.name);
                sr.WriteLine(a.path);
                sr.WriteLine(a.times);
            }
            sr.Close();
            foreach (Game a in game_Form.games)//从上个窗口接受数据
                times_G.Add(new G(a.name, a.times)); 

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://space.bilibili.com/504747386");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/ycxisreal");
        }
        
    }
}