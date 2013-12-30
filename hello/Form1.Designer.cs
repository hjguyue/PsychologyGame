namespace hello
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelEnter = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.panelBallon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.panelPop = new System.Windows.Forms.Panel();
            this.panelScore = new System.Windows.Forms.Panel();
            this.labelLastScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.finalScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelEnter.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.panelBallon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelScore.SuspendLayout();
            this.panelEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEnter
            // 
            this.panelEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEnter.Controls.Add(this.textBox1);
            this.panelEnter.Controls.Add(this.label1);
            this.panelEnter.Controls.Add(this.button1);
            this.panelEnter.Location = new System.Drawing.Point(370, 221);
            this.panelEnter.Name = "panelEnter";
            this.panelEnter.Size = new System.Drawing.Size(585, 266);
            this.panelEnter.TabIndex = 0;
            this.panelEnter.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("KaiTi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(339, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 50);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KaiTi", 28F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入您的姓名：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("KaiTi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(219, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "进入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.labelScore);
            this.panelPlay.Controls.Add(this.panelBallon);
            this.panelPlay.Controls.Add(this.labelSum);
            this.panelPlay.Controls.Add(this.label6);
            this.panelPlay.Controls.Add(this.labelLast);
            this.panelPlay.Controls.Add(this.label4);
            this.panelPlay.Controls.Add(this.label3);
            this.panelPlay.Controls.Add(this.label2);
            this.panelPlay.Location = new System.Drawing.Point(-1, 3);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(1278, 796);
            this.panelPlay.TabIndex = 0;
            this.panelPlay.Visible = false;
            this.panelPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPlay_Click);
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelScore.Location = new System.Drawing.Point(570, 675);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(180, 70);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBallon
            // 
            this.panelBallon.BackColor = System.Drawing.Color.Transparent;
            this.panelBallon.Controls.Add(this.pictureBox1);
            this.panelBallon.Location = new System.Drawing.Point(255, 20);
            this.panelBallon.Name = "panelBallon";
            this.panelBallon.Size = new System.Drawing.Size(800, 640);
            this.panelBallon.TabIndex = 9;
            this.panelBallon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBallon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::hello.Properties.Resources.b1;
            this.pictureBox1.Location = new System.Drawing.Point(347, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSum.ForeColor = System.Drawing.Color.White;
            this.labelSum.Location = new System.Drawing.Point(1091, 717);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(66, 33);
            this.labelSum.TabIndex = 7;
            this.labelSum.Text = "sum";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(981, 717);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "共计";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLast.ForeColor = System.Drawing.Color.White;
            this.labelLast.Location = new System.Drawing.Point(252, 712);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(83, 33);
            this.labelLast.TabIndex = 5;
            this.labelLast.Text = "last";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 712);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "上个气球";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1181, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 462);
            this.label3.TabIndex = 3;
            this.label3.Text = "点击屏幕右侧停止吹气球";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("KaiTi", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 360);
            this.label2.TabIndex = 2;
            this.label2.Text = "点击屏幕左侧吹气球";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelInstruction
            // 
            this.panelInstruction.BackgroundImage = global::hello.Properties.Resources.Instruction;
            this.panelInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInstruction.Location = new System.Drawing.Point(3, 3);
            this.panelInstruction.Name = "panelInstruction";
            this.panelInstruction.Size = new System.Drawing.Size(1277, 796);
            this.panelInstruction.TabIndex = 0;
            this.panelInstruction.Visible = false;
            this.panelInstruction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelInstruction_clicked);
            // 
            // panelPop
            // 
            this.panelPop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPop.BackgroundImage")));
            this.panelPop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPop.Location = new System.Drawing.Point(3, 3);
            this.panelPop.Name = "panelPop";
            this.panelPop.Size = new System.Drawing.Size(1277, 796);
            this.panelPop.TabIndex = 11;
            this.panelPop.Visible = false;
            // 
            // panelScore
            // 
            this.panelScore.Controls.Add(this.labelLastScore);
            this.panelScore.Controls.Add(this.label5);
            this.panelScore.Location = new System.Drawing.Point(4, 10);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(1276, 789);
            this.panelScore.TabIndex = 0;
            this.panelScore.Visible = false;
            // 
            // labelLastScore
            // 
            this.labelLastScore.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLastScore.ForeColor = System.Drawing.Color.Lime;
            this.labelLastScore.Location = new System.Drawing.Point(525, 376);
            this.labelLastScore.Name = "labelLastScore";
            this.labelLastScore.Size = new System.Drawing.Size(220, 64);
            this.labelLastScore.TabIndex = 1;
            this.labelLastScore.Text = "0";
            this.labelLastScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(525, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 64);
            this.label5.TabIndex = 0;
            this.label5.Text = "您获得";
            // 
            // panelEnd
            // 
            this.panelEnd.Controls.Add(this.finalScore);
            this.panelEnd.Controls.Add(this.label8);
            this.panelEnd.Controls.Add(this.label7);
            this.panelEnd.Location = new System.Drawing.Point(-1, -7);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(1281, 806);
            this.panelEnd.TabIndex = 2;
            this.panelEnd.Visible = false;
            // 
            // finalScore
            // 
            this.finalScore.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finalScore.ForeColor = System.Drawing.Color.White;
            this.finalScore.Location = new System.Drawing.Point(485, 305);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(288, 64);
            this.finalScore.TabIndex = 2;
            this.finalScore.Text = "0";
            this.finalScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(467, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 64);
            this.label8.TabIndex = 1;
            this.label8.Text = "谢谢参与！";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(485, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 64);
            this.label7.TabIndex = 0;
            this.label7.Text = "您共获得";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1, 1);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panelInstruction);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.panelEnd);
            this.Controls.Add(this.panelPop);
            this.Controls.Add(this.panelEnter);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_Closing);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelPlay_keyPress);
            this.panelEnter.ResumeLayout(false);
            this.panelEnter.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.panelBallon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelScore.ResumeLayout(false);
            this.panelScore.PerformLayout();
            this.panelEnd.ResumeLayout(false);
            this.panelEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBallon;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Panel panelPop;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label labelLastScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelEnd;
        private System.Windows.Forms.Label finalScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

