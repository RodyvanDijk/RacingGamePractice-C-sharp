using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOverLabel.Visible = false;
            restartButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            coins(gameSpeed);
            coinsCollection();
        }

        int collectedcoins = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            { x=r.Next(0,280);

                enemy1.Location = new Point(x, 0);
            }
            else
            { enemy1.Top += speed; }
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 280);

                enemy2.Location = new Point(x, 0);
            }
            else
            { enemy2.Top += speed; }
            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 280);

                enemy3.Location = new Point(x, 0);
            }
            else
            { enemy3.Top += speed; }

            if (enemy4.Top >= 500)
            {
                x = r.Next(0, 280);

                enemy4.Location = new Point(x, 0);
            }
            else
            { enemy4.Top += speed; }
        }


        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 280);

                coin1.Location = new Point(x, 0);
            }
            else
            { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 280);

                coin2.Location = new Point(x, 0);
            }
            else
            { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 280);

                coin3.Location = new Point(x, 0);
            }
            else
            { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 280);

                coin4.Location = new Point(x, 0);
            }
            else
            { coin4.Top += speed; }

        }
        void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                GameOverLabel.Visible = true;
                restartButton.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                GameOverLabel.Visible = true;
                restartButton.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                GameOverLabel.Visible = true;
                restartButton.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                GameOverLabel.Visible = true;
                restartButton.Visible = true;
            }
        }
        void moveLine(int speed)
        {
            if(pictureBox1.Top>= 500)
            {pictureBox1.Top = 0;}
            else
            {pictureBox1.Top += speed;}

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox6.Top >= 500)
            { pictureBox6.Top = 0; }
            else
            { pictureBox6.Top += speed; }

        }

        void coinsCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(0, 280);

                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(0, 280);

                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(0, 280);

                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(0, 280);

                coin4.Location = new Point(x, 0);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        int gameSpeed = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left>0)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<280)
                car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if(gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }
    }
}
