using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace hello
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            panelInstruction.Visible = true;
            labelScore.BackColor = Color.Transparent;
            labelLast.Text = "0";
            labelSum.Text = "0";
            labelScore.Text = "0";
            random = new Random();

            Program.startTime = DateTime.Now;
            Program.loadFile(DateTime.Now + "");

            for (int i = 0; i < 12; i++)
            {
                timeSpan[i] = 0;
            }
            locked = 0;
        }

        int size = 0;
        int sum = 0;
        int current = 0;
        int exit = 0;
        int locked = 0;
        int enter = 0;        // 是否跳过指导语
        int clicked = 0;      // 是否点击了button
        int max = 30;                        // 气球总数
        int total = 0;                      // 每个球点击总数
        double[] timeSpan = new double[12]; // 记录反应时间
        double currentTime = 0;
        Random random;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && clicked == 0)
            {
                clicked = 1;
            }
        }

        public void panelInstruction_clicked(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            panelInstruction.Visible = false;
            panelPlay.Visible = true;
            Application.DoEvents();
            size = 0;
            resizeBallon(0);
            enter = 1;
        }

        // 按键控制
        public void panelPlay_keyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (total > max)
            {
                locked = 1;
                this.KeyPreview = false;
                return;
            }
            
            if (e.KeyChar.Equals(' ') && enter == 0)
            {
                this.KeyPreview = false;
                locked = 1;
                enter = 1;
                panelInstruction.Visible = false;
                panelPlay.Visible = true;
                Application.DoEvents();
                size = 0;
                resizeBallon(0);
            }
            if(e.KeyChar.Equals('f') && enter != 0 && locked == 0)
            {
                locked = 1;
                this.KeyPreview = false;
                blowballon();
            }
            else if (e.KeyChar.Equals('j') && enter != 0 && locked ==0)
            {
                locked = 1;
                this.KeyPreview = false;
                getMoney();
            }
        }

        public void panelPlay_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (total > max)
                return;
            if (e.Location.X <= panelPlay.Width / 2)
            {
                blowballon();
            }
            else
            {
                getMoney();
            }
        }

        public void pictureBox_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (total > max)
                return;
            if (e.Location.X <= pictureBox1.Width / 2)
            {
                blowballon();
            }
            else
            {
                getMoney();
            }
        }

        public void panelBallon_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (total > max)
                return;
            if (e.Location.X <= panelBallon.Width / 2)
            {
                blowballon();
            }
            else
            {
                getMoney();
            }
        }

        // 取钱：
        public void getMoney()
        {
            checkSum();
            int oldSum = sum;
            sum += current;
            checkSum();
            panelScore.Visible = true;
            panelPlay.Visible = false;
            labelLastScore.Text = "" + current;
            labelLast.Text = "" + current;
            labelSum.Text = "" + sum;
            Application.DoEvents();
            Thread.Sleep(1000);
            
            panelScore.Visible = false;
            panelPlay.Visible = true;
            // 更新总次数
            total++;
            // 记录信息
            String timeString = DateTime.Now + "";
            timeString = timeString.Replace(" ", "_");
            Program.writer.Write(total + " " + timeString + " " + size + " 1 " + oldSum + " ");
            for (int i = 0; i < 12; i++)
            {
                Program.writer.Write((int)timeSpan[i] + " ");
            }
            Program.writer.WriteLine();
            Program.writer.Flush();

            if (total == max)
            {
                end();
            }

            size = 0;
            resizeBallon(size);
            Application.DoEvents();
            this.KeyPreview = true;
            locked = 0;

            for (int i = 0; i < 12; i++)
            {
                timeSpan[i] = 0;
            }
        }

        // 继续吹大气球：
        public void blowballon()
        {
            size++;
            if (size > 12)
            {
                return;
            }

            int x = random.Next(0,13-size);
            if (x == 0)
            {
                explode();
            }
            else
            {
                resizeBallon(size);
            }
        }

        // 气球爆炸
        public void explode()
        {
            locked = 1;
            this.KeyPreview = false;
            //Console.WriteLine("size:" + size);
            if (size < 13)
            {
                timeSpan[size - 1] = DateTime.Now.TimeOfDay.TotalMilliseconds - currentTime;
            }
            double oldSum = sum;

            Application.DoEvents();
            panelPlay.Visible = false;
            panelPop.Visible = true;
            Application.DoEvents();
            Thread.Sleep(300);
            panelPop.Visible = false;

            Application.DoEvents();

            current = size * 5;
            sum -= current;
            checkSum();
            labelSum.Text = "" + sum;
            labelLast.Text = "-" + current;
            // 更新总次数
            total++;
            // 记录信息
            String timeString = DateTime.Now + "";
            timeString = timeString.Replace(" ", "_");
            Program.writer.Write(total + " " + timeString + " " + size + " 0 " + oldSum + " ");
            for (int i = 0; i < 12; i++)
            {
                Program.writer.Write((int)timeSpan[i] + " ");
            }
            Program.writer.WriteLine();
            Program.writer.Flush();

            if (total == max)
            {
                end();
            } 
 
            size = 0;
            resizeBallon(size);

            panelPlay.Visible = true;

            for (int i = 0; i < 12; i++)
            {
                timeSpan[i] = 0;
            }
        }

        public void checkSum()
        {
            if (sum < 0.01 && sum > -0.01)
                sum = 0;
        }

        // 结束反馈
        public void end()
        {
            panelEnd.Visible = true;
            panelPlay.Visible = false;
            checkSum();
            finalScore.Text = "" + sum;
            Application.DoEvents();
            Thread.Sleep(1000);
            exit = 1;
            Program.writer.WriteLine("---------------------");
            checkSum();
            Program.writer.WriteLine("总收获：" + sum);
            double span = DateTime.Now.TimeOfDay.TotalMilliseconds - Program.startTime.TimeOfDay.TotalMilliseconds;
            int temp = (int)span;
            Program.writer.WriteLine("总时间：" + temp + "ms");
            Program.writer.Flush();
            
            Application.Exit();
        }

        // 改变气球的大小：
        public void resizeBallon(int size)
        {
            if (size >= 1)
            {
                timeSpan[size - 1] = DateTime.Now.TimeOfDay.TotalMilliseconds - currentTime;
            }
            int width = 50 * size + 200;
            int height = (int)(40 * size + 160);
            pictureBox1.Location = new Point((int)(400 - 0.5 * width), (int)(320 - 0.5 * height));
            pictureBox1.Size = new Size(width, height);
            current = size * 5;
            labelScore.Text = "" + current;
            Application.DoEvents();
            this.KeyPreview = true;
            locked = 0;
            currentTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            getMoney();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            blowballon();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            blowballon();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            getMoney();
        }

        private void labelLast_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            blowballon();
        }

        private void labelSum_Click(object sender, EventArgs e)
        {
            if (total > max)
                return;
            getMoney();
        }

        public void form1_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (exit == 0)
                e.Cancel = true;
            else
                e.Cancel = false;
        }


    }
}
