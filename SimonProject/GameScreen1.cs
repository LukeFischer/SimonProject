using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace SimonProject
{
    public partial class GameScreen1 : UserControl
    {
        Random randNum = new Random();
        int guess = 0;
        int count = 0;

        public GameScreen1()
        {
            InitializeComponent();
        }

        private void GameScreen1_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(100);
            ComputerTurn();
        }
        private void ComputerTurn()
        {
            //Random Number
            
            int rand = randNum.Next(1, 4);
            

            // Add Random Colours to the list
            Form1.pattern.Add(rand);
            //computer turn
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 1)
                {
                    Refresh();
                    Thread.Sleep(100);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Ding);
                    player.Play();
                    blueButton.BackColor = Color.DodgerBlue;
                    Refresh();
                    Thread.Sleep(1600);
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 2)
                {
                    Refresh();
                    Thread.Sleep(100);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Ding);
                    player.Play();
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(1600);
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 3)
                {
                    Refresh();
                    Thread.Sleep(100);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Ding);
                    player.Play();
                    yellowButton.BackColor = Color.Khaki;
                    Refresh();
                    Thread.Sleep(1600);
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 4)
                {
                    Refresh();
                    Thread.Sleep(100);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Ding);
                    player.Play();
                    redButton.BackColor = Color.IndianRed;
                    Refresh();
                    Thread.Sleep(1600);
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(400);
                }

            }
            //Reset count and guess
            count = 0;
            guess = 0;
        }


        private void click(String s)
        {
            //If blue button is pressed
            if (s == "Blue")
            {
                guess = 1;

                SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ding);
                player1.Play();
                blueButton.BackColor = Color.DodgerBlue;
                Refresh();
                Thread.Sleep(300);
                blueButton.BackColor = Color.Blue;
                Refresh();
                Thread.Sleep(400);
            }

            //If green button is pressed
            if (s == "Green")
            {
                guess = 2;

                SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ding);
                player1.Play();
                greenButton.BackColor = Color.LimeGreen;
                Refresh();
                Thread.Sleep(300);
                greenButton.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(400);

            }
            //If yellow button is pressed
            if (s == "Yellow")
            {
                guess = 3;

                SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ding);
                player1.Play();
                yellowButton.BackColor = Color.Khaki;
                Refresh();
                Thread.Sleep(300);
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(400);
            }
            //If red button is pressed
            if (s == "Red")
            {
                SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ding);
                player1.Play();
                guess = 4;
                redButton.BackColor = Color.IndianRed;
                Refresh();
                Thread.Sleep(300);
                redButton.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(400);
            }

            //If guess is incorrect, end game and open GameOver screen
            if(Form1.pattern[count] != guess)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Buzzer);
                player.Play();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gs = new GameOverScreen();
                f.Controls.Add(gs);

                count = 0;
                guess = 0;
                Form1.pattern.Clear();
            }
            //If guess is correct, resume player turn
            else
            {
                
                count++;


                //Launch computer screen once the pattern is fully completed
                if (count == Form1.pattern.Count())
                {
                    Thread.Sleep(1000);
                    ComputerTurn();
                }
            }

            
        
         }

        private void blueButton_Click(object sender, EventArgs e)
        {

            click("Blue");

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            click("Green");
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

            click("Yellow");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            click("Red");
        }
    
    }
}
