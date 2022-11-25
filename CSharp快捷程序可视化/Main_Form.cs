namespace CSharp快捷程序可视化
{
    using System.Text;
    using System.Diagnostics;
    using System.IO;
    public partial class Main_Form : Form
    {
        List<G> times_G = new List<G>();
        List<W> times_W = new List<W>();
        public class G
        {
            public string name;
            public int times;
            public G(string n, int m)
            {
                name = n; times = m;
            }
        }
        public class W
        {
            public string name;
            public int times;
            public W(string name, int times)
            {
                this.name = name;
                this.times = times;
            }
        }
        public Main_Form()
        {
            InitializeComponent();
            initializeCountServise();
        }
        private void initializeCountServise()
        {
            StreamWriter temp1 = new StreamWriter("game.txt", true);
            temp1.Close();
            temp1 = new StreamWriter("web.txt", true);
            temp1.Close();

            StreamReader streamReader = new StreamReader("game.txt", Encoding.Default);
            string name="";
            string temp;
            int timer = 1;
            while((temp = streamReader.ReadLine())!=null)
            {
                if (timer % 3 == 1)
                    name = temp;
                else if (timer % 3 == 0)
                    times_G.Add(new G(name, Convert.ToInt32(temp)));
                timer++;
            }
            streamReader.Close();
            streamReader = new StreamReader("web.txt",Encoding.Default);
            timer = 1;
            while ((temp = streamReader.ReadLine()) != null)
            {
                if (timer % 3 == 1)
                    name = temp;
                else if (timer % 3 == 0)
                    times_W.Add(new W(name, Convert.ToInt32(temp)));
                timer++;
            }
            streamReader.Close();
        }
        private void GameButton_Click(object sender, EventArgs e)
        {
            //临时
            StreamWriter temp = new StreamWriter("game.txt", true);
            temp.Close();
            Game_Form game_Form = new Game_Form();
            game_Form.ShowDialog();
            //储存信息
            FileStream fs = new FileStream("game.txt", FileMode.Create);
            fs.Close();
            StreamWriter sr = new StreamWriter("game.txt");

            foreach (Game a in game_Form.games)
            {
                sr.WriteLine(a.name);
                sr.WriteLine(a.path);
                sr.WriteLine(a.times);
            }
            sr.Close();
            times_G.Clear();
            foreach (Game a in game_Form.games)//从上个窗口接受数据
                times_G.Add(new G(a.name, a.times)); 
        }
        private void WebButton_Click(object sender, EventArgs e)
        {
            //临时
            StreamWriter temp = new StreamWriter("web.txt", true);
            temp.Close();
            Web_Form web_Form = new Web_Form();
            web_Form.ShowDialog();
            FileStream fs = new FileStream("web.txt",FileMode.Create);
            fs.Close();
            StreamWriter sw = new StreamWriter("web.txt");
            foreach(Web a in web_Form.webs)
            {
                sw.WriteLine(a.name);
                sw.WriteLine(a.url);
                sw.WriteLine(a.times);
            }
            sw.Close();
            //记录
            times_W.Clear();
            foreach(Web a in web_Form.webs)
                times_W.Add(new W(a.name, a.times));
        }
        private void FilesButton_Click(object sender, EventArgs e)
        {
            StreamWriter temp = new StreamWriter("file.txt", true);
            temp.Close();
            File_Form file_Form = new File_Form();
            file_Form.ShowDialog();
            FileStream fs = new FileStream("file.txt", FileMode.Create);
            fs.Close();//删除原有文件中的信息
            //储存文件夹信息
            StreamWriter streamWriter = new StreamWriter("file.txt");
            foreach(Myfile a in file_Form.files)
            {
                streamWriter.WriteLine(a.path);
                streamWriter.WriteLine(a.num);
            }
            streamWriter.Close();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://space.bilibili.com/504747386");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/ycxisreal");
        }

        private void About_Click(object sender, EventArgs e)
        {
            string text = "快捷程序V1.1\r\n" +
                "作者：杨春潇\r\n" +
                "qq：1634770529\r\n" +
                "有问题请反馈";
            MessageBox.Show(text);
        }

        private void tongji_Click(object sender, EventArgs e)
        {
            Count_Form count_Form = new Count_Form(times_G,times_W);
            count_Form.ShowDialog();
        }
    }
}