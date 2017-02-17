using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SimonProject
{
    public partial class GameScreen1 : UserControl
    {
        
        int guess = 0;
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
            Random randNum = new Random();
            int rand = randNum.Next(1, 4);
            int rand2 = randNum.Next(1, 4);
            int rand3 = randNum.Next(1, 4);
            int rand4 = randNum.Next(1, 4);

            // Add Random Colours to the list
            Form1.pattern.Add(rand);
            Form1.pattern.Add(rand2);
            Form1.pattern.Add(rand3);
            Form1.pattern.Add(rand4);

            //computer turn
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 1)
                {
                    Refresh();
                    Thread.Sleep(100);
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
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(1600);
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 3)
                {
                    yellowButton.BackColor = Color.Khaki;
                    Refresh();
                    Thread.Sleep(1600);
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 4)
                {
                    redButton.BackColor = Color.IndianRed;
                    Refresh();
                    Thread.Sleep(1600);
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(400);
                }

            }
            
            guess = 0;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
               for (int i = 0; i < Form1.pattern.Count(); i++)

                {
                    blueButton.BackColor = Color.DodgerBlue;
                    Refresh();
                    Thread.Sleep(300);
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(400);
                    int guess = i++;
                    if (guess == Form1.pattern.Count())
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        GameOverScreen gs = new GameOverScreen();
                        f.Controls.Add(gs);
                        
                    }

                        
                }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
                for (int i = 0; i < Form1.pattern.Count(); i++)

                {
                    greenButton.BackColor = Color.LimeGreen;
                    Refresh();
                    Thread.Sleep(300);
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(400);
                    int guess = i++;
                    if (guess == Form1.pattern.Count())


                    ComputerTurn();
                    
                }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

            if (Form1.pattern[guess] == 3)
                for (int i = 0; i < Form1.pattern.Count(); i++)
                {
                    yellowButton.BackColor = Color.Khaki;
                    Refresh();
                    Thread.Sleep(300);
                    greenButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(400);
                    int guess = i++;
                    if (guess == Form1.pattern.Count())


                    ComputerTurn();
                }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 4)
                for (int i = 0; i < Form1.pattern.Count(); i++)
                {
                    redButton.BackColor = Color.IndianRed;
                    Refresh();
                    Thread.Sleep(300);
                    greenButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(400);
                    int guess = i++;
                    if (guess == Form1.pattern.Count())


                    ComputerTurn();
                }
        }
    
    }
}
