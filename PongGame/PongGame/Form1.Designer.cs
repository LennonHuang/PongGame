namespace PongGame
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
            this.components = new System.ComponentModel.Container();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.informationBox = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.userControl12 = new PongGame.UserControl1();
            this.userControl11 = new PongGame.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paddle1.Location = new System.Drawing.Point(0, 157);
            this.paddle1.Margin = new System.Windows.Forms.Padding(2);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(15, 78);
            this.paddle1.TabIndex = 0;
            this.paddle1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paddle2.Location = new System.Drawing.Point(664, 157);
            this.paddle2.Margin = new System.Windows.Forms.Padding(2);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(15, 78);
            this.paddle2.TabIndex = 1;
            this.paddle2.TabStop = false;
            this.paddle2.Click += new System.EventHandler(this.paddle2_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(323, 172);
            this.ball.Margin = new System.Windows.Forms.Padding(2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 26);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            this.ball.WaitOnLoad = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // informationBox
            // 
            this.informationBox.AutoSize = true;
            this.informationBox.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.Location = new System.Drawing.Point(224, 255);
            this.informationBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(202, 81);
            this.informationBox.TabIndex = 7;
            this.informationBox.Text = "Press Space to Play\r\n  Player 1 Key: A Z\r\n  Player 2 Key: K M";
            this.informationBox.Click += new System.EventHandler(this.informationBox_Click);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(372, 32);
            this.Player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(24, 27);
            this.Player2.TabIndex = 6;
            this.Player2.Text = "0";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(270, 32);
            this.Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(24, 27);
            this.Player1.TabIndex = 5;
            this.Player1.Text = "0";
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(374, 102);
            this.userControl12.Margin = new System.Windows.Forms.Padding(1);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(21, 34);
            this.userControl12.TabIndex = 9;
            this.userControl12.Value = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(272, 102);
            this.userControl11.Margin = new System.Windows.Forms.Padding(1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(21, 34);
            this.userControl11.TabIndex = 8;
            this.userControl11.Value = 0;
            this.userControl11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.userControl11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label informationBox;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        public System.Windows.Forms.Label label1;
    }
}

