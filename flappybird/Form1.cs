using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class Form1 : Form
    {
        int pipespeed =  15;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            pipebottom2.Left -= pipespeed;
            pipetop2.Left -= pipespeed;
            pipebottom3.Left -= pipespeed;
            pipetop3.Left -= pipespeed;

            scoreText.Text = "Score: " + score;

            if (pipebottom.Left < -150)
            {
                pipebottom.Left = 1400;
                score++;
            }
            if (pipetop.Left < -180)
            {
                pipetop.Left = 1600;
                score++;
            }

            if ( flappybird.Bounds.IntersectsWith(pipebottom.Bounds) || flappybird.Bounds.IntersectsWith(pipetop.Bounds) || flappybird.Bounds.IntersectsWith(pipebottom2.Bounds) || flappybird.Bounds.IntersectsWith(pipetop2.Bounds) || flappybird.Bounds.IntersectsWith(pipebottom3.Bounds) || flappybird.Bounds.IntersectsWith(pipetop3.Bounds) || flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < 3 )
            {
                endgame();
            }
           
            if ( score > 2 )
            {
                pipespeed = 12;
            }
            if (score > 4)
            {
                pipespeed = 14;
            }
            if (score > 6)
            {
                pipespeed = 14;
            }
            if (score > 8)
            {
                pipespeed = 12;
            }
            if (score > 10)
            {
                pipespeed = 12;
            }
            if (score > 12)
            {
                pipespeed = 12;
            }
            if (score > 14)
            {
                pipespeed = 12;
            }
            if (score > 16)
            {
                pipespeed = 12;
            }
            if (score > 18)
            {
                pipespeed = 12;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
            }

        }

        private void endgame()
        {
            gametimer.Stop();

            

               scoreText.Text += " GAME OVER !!!!";

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pipebottom_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
