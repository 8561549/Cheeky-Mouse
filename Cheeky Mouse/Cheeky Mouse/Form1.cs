using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cheeky_Mouse
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭正在运行的程序
        }

        private void labstart_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏主窗体
            //实例化游戏窗体
            frmgame game = new frmgame();
            game.Show();
        }
    }
}
