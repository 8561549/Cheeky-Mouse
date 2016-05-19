using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;//导入命名空间

namespace Cheeky_Mouse
{
    public partial class frmgame : Form
    {
        public frmgame()
        {
            InitializeComponent();
        }

        //计时器标志
        public int jis = 0;

        //打中的个数
        public int shu = 0;

        //暂停游戏的标志
        public int game = 0;

        //开始分数
        public int fenshu = 0;

        //开始游戏的标志
        public int index = 0;

        //打中的标志
        public int dazhong = 0;

        //升级标志
        public int sji = 0;

        //判断方法
        public void panduan(int times)
        {
            if (times == 1)
            {
                dazhong = times;
                this.pBox1.Image = Image.FromFile("mouse.png", true);//设置图片控件的图片
            }
            if (times == 2)
            {
                dazhong = times;
                this.pBox2.Image = Image.FromFile("mouse.png", true);//设置图片控件的图片
            }
            if (times == 3)
            {
                dazhong = times;
                this.pBox3.Image = Image.FromFile("mouse.png", true);//设置图片控件的图片
            }
            if (times == 4)
            {
                dazhong = times;
                this.pBox4.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 5)
            {
                dazhong = times;
                this.pBox5.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 6)
            {
                dazhong = times;
                this.pBox6.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 7)
            {
                dazhong = times;
                this.pBox7.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 8)
            {
                dazhong = times;
                this.pBox8.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 9)
            {
                dazhong = times;
                this.pBox9.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 10)
            {
                dazhong = times;
                this.pBox10.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 11)
            {
                dazhong = times;
                this.pBox11.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 12)
            {
                dazhong = times;
                this.pBox12.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 13)
            {
                dazhong = times;
                this.pBox13.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 14)
            {
                dazhong = times;
                this.pBox14.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
            if (times == 15)
            {
                dazhong = times;
                this.pBox15.Image = Image.FromFile("mouse.jpg", true);//设置图片控件的图片
            }
        }

        //恢复方法
        public void huifu()
        {
            this.pBox1.Image = Image.FromFile("hole.jpg", true);
            this.pBox2.Image = Image.FromFile("hole.jpg", true);
            this.pBox3.Image = Image.FromFile("hole.jpg", true);
            this.pBox4.Image = Image.FromFile("hole.jpg", true);
            this.pBox5.Image = Image.FromFile("hole.jpg", true);
            this.pBox6.Image = Image.FromFile("hole.jpg", true);
            this.pBox7.Image = Image.FromFile("hole.jpg", true);
            this.pBox8.Image = Image.FromFile("hole.jpg", true);
            this.pBox9.Image = Image.FromFile("hole.jpg", true);
            this.pBox10.Image = Image.FromFile("hole.jpg", true);
            this.pBox11.Image = Image.FromFile("hole.jpg", true);
            this.pBox12.Image = Image.FromFile("hole.jpg", true);
            this.pBox13.Image = Image.FromFile("hole.jpg", true);
            this.pBox14.Image = Image.FromFile("hole.jpg", true);
            this.pBox15.Image = Image.FromFile("hole.jpg", true);
            dazhong = 0;
        }
        
        //退出游戏按钮
        private void butexit_Click(object sender, EventArgs e)
        {
            //判断用户是否单击了“是”按钮
            if (MessageBox.Show("你确定要退出游戏？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //移除关闭事件
                this.FormClosing -= this.frmgame_FormClosing;
                Application.Exit();//关闭正在运行的程序
            }
        }

        //计时器时间控件
        private void timerjishi_Tick(object sender, EventArgs e)
        {
            jis+=1;
            this.labjishiqi.Text = jis.ToString();
        }

        //恢复时间控件
        private void timerhuifu_Tick(object sender, EventArgs e)
        {
            //调用恢复方法
            huifu();
        }

        //开始游戏时间控件
        private void timerstart_Tick(object sender, EventArgs e)
        {
            //创建随即类
            Random ra = new Random();
            //产生1-16的数并赋值给time变量
            int time = ra.Next(1,16);
            //调用判断方法
            panduan(time);
        }

        //判断分数时间控件
        private void timerfenshuif_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.labgeshu.Text) >= 30 && sji==0)
            {
                sji = 1;                            //重新赋值升级标志，即进入下一等级
                this.timerstart.Interval = 800;     //改变开始游戏时间控件的间隔时间
                this.timerhuifu.Interval = 900;
                this.tsmenuzhongji.Checked = true;  //选中中级选项
                this.tsmenugaoji.Checked = false;
                this.tsmenuchuji.Checked = false;
                this.timerfenshuif.Stop();
                MessageBox.Show("恭喜你进入了中级水平！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(this.labgeshu.Text)>200 && sji==1)
            {
                sji = 1;                            //重新赋值升级标志，即进入下一等级
                this.timerstart.Interval = 600;     //改变开始游戏时间控件的间隔时间
                this.timerhuifu.Interval = 700;
                this.tsmenuzhongji.Checked = true;  //选中中级选项
                this.tsmenugaoji.Checked = false;
                this.tsmenuchuji.Checked = false;
                this.timerfenshuif.Stop();
                MessageBox.Show("恭喜你进入了高级水平！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        //开始按钮
        private void bustart_Click(object sender, EventArgs e)
        {
            //重新赋值给开始游戏标志
            index = 1;
            //启动开始游戏时间控件
            this.timerstart.Start();
            //启动恢复时间控件
            this.timerhuifu.Start();
            //启动计时器时间控件
            this.timerjishi.Start();
            //启动判断分数时间控件
            this.timerfenshuif.Start();
            //启用
            this.butstop.Enabled = true;
        }

        //正在关闭窗体时
        private void frmgame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断用户是否单击了“是”按钮
            if (MessageBox.Show("你确定要退出游戏？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //移除关闭事件
                this.FormClosing -= this.frmgame_FormClosing;
                Application.Exit();//关闭正在运行的程序
            }
            else
            {
                //不执行任何操作
                e.Cancel = true;
            }
        }

        //暂停游戏按钮
        private void butstop_Click(object sender, EventArgs e)
        {
            if (game==0)
            {
                //禁止开始游戏按钮
                this.butstart.Enabled = false;
                //暂停开始游戏时间控件
                this.timerstart.Stop();
                //暂停恢复时间控件
                this.timerhuifu.Stop();
                //暂停计时器时间控件
                this.timerjishi.Stop();
                //暂停判断分数时间控件
                this.timerfenshuif.Stop();
                this.butstop.Text = "开始游戏";
                game = 1;
                return;
            }
            if (game==1)
            {
                //启用开始游戏按钮
                this.butstart.Enabled = true;
                //启动开始游戏时间控件
                this.timerstart.Start();
                //启动恢复时间控件
                this.timerhuifu.Start();
                //启动计时器时间控件
                this.timerjishi.Start();
                //启动判断分数时间控件
                this.timerfenshuif.Start();
                this.butstop.Text = "暂停游戏";
                game = 0;
                return;
            }
        }

        //菜单栏的退出按钮
        private void tsmenuexit_Click(object sender, EventArgs e)
        {
            //判断用户是否单击了“是”按钮
            if (MessageBox.Show("你确定要退出游戏？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //移除关闭事件
                this.FormClosing -= this.frmgame_FormClosing;
                Application.Exit();//关闭正在运行的程序
            }
        }

        //窗体加载
        private void frmgame_Load(object sender, EventArgs e)
        {
            //禁用
            this.butstop.Enabled = false;
        }

        //鼠标移动上去后
        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.panel1.Cursor = new Cursor("1.ico");
        }

        //当鼠标按下后
        private void pBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.panel1.Cursor = new Cursor("2.ico");
        }

        //当鼠标释放后
        private void pBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.panel1.Cursor = new Cursor("1.ico");
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
           //判断开始游戏标志
            if (index==1)
            {
                //判断是否被打中
                if (dazhong==1)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;//分数加5
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;//个数加1
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 2)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 3)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 4)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 5)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 6)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox7_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 7)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox8_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 8)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox9_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 9)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox10_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 10)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox11_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 11)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox12_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 12)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox13_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 13)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox14_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 14)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox15_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 15)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        private void pBox16_Click(object sender, EventArgs e)
        {
            //判断开始游戏标志
            if (index == 1)
            {
                //判断是否被打中
                if (dazhong == 16)
                {
                    SoundPlayer sp = new SoundPlayer("01.wav");//实例化音乐类
                    sp.Play();//播放音乐一次
                    fenshu += 5;
                    this.labdefenkuang.Text = fenshu + "";
                    shu += 1;
                    this.labgeshu.Text = shu + "";
                }
            }
        }

        //初级选项
        private void tsmenuchuji_Click(object sender, EventArgs e)
        {
            //设置控件的时间间隔
            this.timerstart.Interval = 1000;
            this.timerhuifu.Interval = 1000;
            //选中初级选项
            this.tsmenuchuji.Checked = true;
            this.tsmenuzhongji.Checked = false;
            this.tsmenugaoji.Checked = false;
        }

        //中级选项
        private void tsmenuzhongji_Click(object sender, EventArgs e)
        {
            //设置控件的时间间隔
            this.timerstart.Interval = 800;
            this.timerhuifu.Interval = 900;
            //选中中级选项
            this.tsmenuzhongji.Checked = true;
            this.tsmenuchuji.Checked = false;
            this.tsmenugaoji.Checked = false;
        }

        //高级选项
        private void tsmenugaoji_Click(object sender, EventArgs e)
        {
            //设置控件的时间间隔
            this.timerstart.Interval = 600;
            this.timerhuifu.Interval = 700;
            //选中高级选项
            this.tsmenugaoji.Checked = true;
            this.tsmenuchuji.Checked = false;
            this.tsmenuzhongji.Checked = false;
        }
    }
}
