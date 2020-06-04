using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form1 : Form
    {
        bool isUpPressed_1, isDownPressed_1;
        bool isUpPressed_2, isDownPressed_2;
        int PaddleSpeed = 2;
        int BallSpeedValue = 1;
        private double Xdirection,Ydirection;
        public int theta;
        private int score_1, score_2;
        int labeX;
        Random rnd = new Random();
        public Form1()
        {
            /*Random direction start*/
            Xdirection = rnd.Next(2, 6) * Math.Pow(-1, rnd.Next(2, 5));
            Ydirection = 2 * Math.Pow(-1, rnd.Next(2, 5));
            score_1 = 0;
            score_2 = 0;
            InitializeComponent();
            labeX = label1.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //Two Paddles KeyBoard Control
            if (isUpPressed_2 == true)
            {
                paddle2.Location = new Point(paddle2.Location.X, Math.Max(0,paddle2.Location.Y - PaddleSpeed));
            }
            if (isDownPressed_2 == true)
            {
                paddle2.Location = new Point(paddle2.Location.X, Math.Min(ClientRectangle.Bottom- 75, paddle2.Location.Y + PaddleSpeed));
            }
            if (isUpPressed_1 == true)
            {
                paddle1.Location = new Point(paddle1.Location.X, Math.Max(0,paddle1.Location.Y - PaddleSpeed));
            }
            if (isDownPressed_1 == true)
            {
                paddle1.Location = new Point(paddle1.Location.X, Math.Min(ClientRectangle.Bottom - 75, paddle1.Location.Y + PaddleSpeed));
            }
            //Move the ball.
            MoveBall();
            //If player one has scored 10 points.
            if (score_1 == 10)
            {
                timer1.Enabled = false;
                ball.Visible = false;
                label1.Text = "Win";
                label1.Left = 100;
                informationBox.Text = "Press Space to Play Again";
                userControl12.Value = 10;
            }//If player two has scored 10 points.
            else if (score_2 == 10)
            {
                timer1.Enabled = false;
                ball.Visible = false;
                label1.Text = "Win";
                label1.Left = 530;
                informationBox.Text = "Press Space to Play Again";
                userControl11.Value = 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paddle2_Click(object sender, EventArgs e)
        {

        }

        private void informationBox_Click(object sender, EventArgs e)
        {

        }

        //Key Event, move the paddles.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !timer1.Enabled)
            {
                timer1.Enabled = true;
                ball.Visible = true;
                score_1 = 0;
                score_2 = 0;
                label1.Left =labeX;
                Player1.Text = 0.ToString();
                Player2.Text = 0.ToString();
                informationBox.Text = "";
                label1.Text = "Score";
                userControl11.Value = 0;
                userControl12.Value = 0;
            }
            switch (e.KeyCode)
            {
                case Keys.K:
                    isUpPressed_2 = true;
                    break;
                case Keys.A:
                    isUpPressed_1 = true;
                    break;
                case Keys.M:
                    isDownPressed_2 = true;
                    break;
                case Keys.Z:
                    isDownPressed_1 = true;
                    break;
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.K:
                    isUpPressed_2 = false;
                    break;
                case Keys.A:
                    isUpPressed_1 = false;
                    break;
                case Keys.M:
                    isDownPressed_2 = false;
                    break;
                case Keys.Z:
                    isDownPressed_1 = false;
                    break;
            }
        }

        private void MoveBall()
        {
            //Update the ball position.
            ball.Location = new Point(ball.Location.X + BallSpeedValue *Convert.ToInt16(Xdirection), ball.Location.Y + BallSpeedValue * Convert.ToInt16(Ydirection));
            //Collision of the ball and the wall.
            if (ball.Location.Y >= ClientRectangle.Bottom - ball.Size.Height || ball.Location.Y <= ClientRectangle.Top)
            {
                Ydirection = -Ydirection;
            }
            //Collision of the ball and paddles
            if (ball.Location.X <= paddle1.Location.X + paddle1.Size.Width)
            {
                //Player 1 
                if (ball.Location.Y <= paddle1.Location.Y + paddle1.Size.Height
                && ball.Location.Y + ball.Size.Height >= paddle1.Location.Y )
                { Xdirection = -Xdirection; }//Player 1 is safe.
                else
                {
                    score_2 += 1;
                    Player2.Text = score_2.ToString();
                    userControl12.Value = score_2;
                    ReStart();//Player 1 lose one point.
                }
            }
                //Player 2
            if (ball.Location.X >= paddle2.Location.X - ball.Size.Width)
            {
                if (ball.Location.Y <= paddle2.Location.Y + paddle2.Size.Height
                && ball.Location.Y + ball.Size.Height >= paddle2.Location.Y )
                { Xdirection = -Xdirection; }//Player 2 is safe.
                else
                {
                    score_1 += 1;
                    Player1.Text = score_1.ToString();
                    userControl11.Value = score_1;
                    ReStart();//Player 2 lose one point.
                }
            }
        }

        //A new round. Reset the ball position(random) and the speed direction (random) 
        //of the ball.
        private void ReStart()
        {
            ball.Location = new Point(ClientRectangle.Right / 2 ,
                                      ClientRectangle.Bottom / 2 + rnd.Next(-150, 150));
            Xdirection = rnd.Next(2, 6) * Math.Pow(-1,rnd.Next(2,5) );
            Ydirection = 2*Math.Pow(-1, rnd.Next(2,5));
        }
    }
}
