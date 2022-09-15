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
using System.Runtime.InteropServices;
using System.IO;
namespace CSharp快捷程序可视化
{
    using System.Collections;

    public partial class Game_Form : Form
    {
        public List<Game> games = new List<Game>();
        ArrayList G_name =new ArrayList();
        public enum ShowWindowCommands : int//设置各类参数
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,    //用最近的大小和位置显示，激活
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_MAX = 10
        }
        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(
         IntPtr hwnd,
         string lpszOp,
         string lpszFile,
         string lpszParams,
         string lpszDir,
         ShowWindowCommands FsShowCmd
         );
        public Game_Form()//构造
        {
            InitializeComponent();
            initial();
            foreach (Game game in games)
                G_name.Add(game.name);
        }

        private void add_Click(object sender, EventArgs e)//添加按钮
        {
            
            Game_add_Form game_Add_Form = new Game_add_Form();
            game_Add_Form.ShowDialog();
            //判断是否添加
            if(game_Add_Form.FilePath != "")
            {
                Game a = new Game(game_Add_Form.AppName, game_Add_Form.FilePath,0);
                games.Add(a);
                G_name.Add(a.name);
                Datasource_update();
            }
            
                
            show_games();
        }
        public void show_games()//在textbox展示
        {
            textBox1.Clear();
            foreach(string a in G_name)
                textBox1.Text+=a+"\r\n";
        }
        public void initial()//读取
        {

        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("还没有添加应用！");
                return;
            }
            else if(comboBox1.SelectedItem==null)
            {
                MessageBox.Show("未选择应用！");
                return;
            }
            int Index=comboBox1.SelectedIndex;
            ShellExecute(IntPtr.Zero, "open", games[Index].path, null, null, ShowWindowCommands.SW_SHOWNORMAL);
            games[Index].times++;
            
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("还没有添加应用！");
                return;
            }
            //执行两次删除操作，并更新textbox以及DataSource
            int Index = comboBox1.SelectedIndex;
            G_name.RemoveAt(Index);
            games.RemoveAt(Index);
            show_games();
            Datasource_update();
        }
        private void Datasource_update()//更新DataSource 
        {
            comboBox1.DataSource=null;
            comboBox1.DataSource = G_name;
        }
        
    }
    public class Game
    {
        public string name;
        public string path;
        public int times;
        public Game()
        {
            name = "";
            path = "";
            times = 0;
        }
        public Game(string a,string b,int c=0)
        {
            name=a;
            path=b;
            times=c;
        }
    }
}
