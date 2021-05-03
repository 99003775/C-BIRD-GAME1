using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIRD_GAME
{
    


    public partial class Form1 : Form
    {
        int pipspeed = 5;
        int gravity = 5;
        int tscore= 0 ;


        public Form1()
        {
            InitializeComponent();
        }

        private void gametimer(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipbottom.Left -= pipspeed;
            piptop.Left -= pipspeed;
            score.Text=tscore.ToString(); 
            
            if(pipbottom.Left<-140)
            {
                pipbottom.Left = 900;
                tscore++;
            }
            if(piptop.Left<-60)
            {
                piptop.Left = 900;
                tscore++;
            }
            if(flappybird.Bounds.IntersectsWith(pipbottom.Bounds)||
                flappybird.Bounds.IntersectsWith(piptop.Bounds)||
                flappybird.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();
            }
            if(tscore>10)
            {
                pipspeed = 8;
            }
            if(flappybird.Top<-25)
            {
                endgame();
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode== Keys.Space)
            {
                gravity = -5;
            }

        }

        private void gameup(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }
        private void endgame()
        {
            timer.Stop();
            score.Text += "GAME OVER!!!!";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
