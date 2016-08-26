using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;///线程

namespace ChatRobots
{
    public partial class 聊天机器人 : Form
    {
        private Robot A;//机器人对象
        private string Ask;//发送信息
        private string Answer;//返回信息
        private int isTeaching;//调教模式

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private string FileName;//txt文件路径
        private Thread T1;//创建一个线程

        public 聊天机器人()
        {
            InitializeComponent();
            A = new Robot("小A","女",18);//new一个机器人小A
            Ask = null;
            Answer = null;
            isTeaching = 0;//非调教状态
            this.richTextBox1_accept.AppendText("\n "+A.name+"：欢迎使用聊天机器人，我们愿意为您服务，我是"+A.name+"\n");
            //欢迎语
        }
        /////发送按扭
        private void button_sent_Click(object sender, EventArgs e)
        {
            if (isTeaching == 0)///正常聊天状态
            {
                Ask = this.richTextBox_sent.Text;

                this.richTextBox1_accept.SelectionAlignment = HorizontalAlignment.Right;//设置为右对齐
                this.richTextBox1_accept.AppendText(Ask + "：主人  \n");

                Answer = A.answer(Ask);
                this.richTextBox1_accept.SelectionAlignment = HorizontalAlignment.Left;//设置为左对齐
                this.richTextBox1_accept.AppendText(" "+ A.name + "：" + Answer + "\n");

            }///////调教机器人状态
            else if (isTeaching == 1)
            {
                Ask = this.richTextBox_sent.Text;
                this.richTextBox1_accept.SelectionAlignment = HorizontalAlignment.Right;
                this.richTextBox1_accept.AppendText(Ask + "：主人   \n");
                isTeaching = 2;
            }
            else
            {
                Answer = this.richTextBox_sent.Text;
                this.richTextBox1_accept.SelectionAlignment = HorizontalAlignment.Left;
                this.richTextBox1_accept.AppendText(" "+A.name+"：" + Answer + "\n");
                A.learn(Ask,Answer);
                isTeaching = 1;      
            }
            this.richTextBox1_accept.ScrollToCaret();//自动滚动到插入位置
            this.richTextBox_sent.Clear();//清空发送框
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();//关闭程序
        }

        private void button1_teaching_Click(object sender, EventArgs e)
        {
            if (isTeaching == 0)//设置为调教模式
            {
                isTeaching = 1;
                this.button1_teaching.Text = "完成调教";
            }
            else //完成调教
            {
                isTeaching = 0;
                this.button1_teaching.Text = "调教";
                //this.richTextBox1_accept.Clear();
            }
        }
       /* private void showimg(string R,int x,int y)
        {              
            Graphics g=richTextBox1_accept.CreateGraphics();
            Bitmap myBit = new Bitmap(R, false);
            g.DrawImage(myBit, x, y, 30, 100);
           
        }*/

        private void label1_robot_Click(object sender, EventArgs e)
        {

        }
       
        /// 窗口移动*******************************************************************
        private void 聊天机器人_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void 聊天机器人_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void 聊天机器人_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        //****************************************************************

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();//关闭程序
        }

        ///右上角的关闭窗口图片换
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Properties.Resources.x31);
            pictureBox4.Image = img;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Properties.Resources.x11);
            pictureBox4.Image = img;
        }
        ///导入词库
             private void Openfile()
        {        
            Iostreams.Import(FileName);//导入词库
            T1.Abort();
           // this.label2.Text = "导入词库";
           // MessageBox.Show(this, "导入完成");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = this.openFileDialog1.FileName;
                 T1 = new Thread(this.Openfile);///新建线程用于导入词库
                 T1.Start();///开始线程 
             //    this.label2.Text = "词库导入中";
            }
        }
    }
}
