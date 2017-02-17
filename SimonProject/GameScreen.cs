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
    public partial class GameScreen : UserControl
        
    {
        int guess = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(100);
        }

        private void ComputerTurn()
        {
            //Random Number
            Random randNum = new Random();
            int rand = randNum.Next(1, 4);

            // Add Colours to the list
            Form1.pattern.Add(1);
            //Form1.pattern.Add(2);
            //Form1.pattern.Add(3);
            //Form1.pattern.Add(4);

            //computer turn
            for (int i = 0; i < Form1.pattern.Count(); i++)
            { 
                if (Form1.pattern[i] == 1)
                {
                    bluebutton.BackColor = Color.DodgerBlue;
                    Refresh();
                    Thread.Sleep(1600);
                    bluebutton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(400);
                }
                if (Form1.pattern[i] == 2)
                {
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

        private void bluebutton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
                for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                bluebutton.BackColor = Color.DodgerBlue;
                Refresh();
                Thread.Sleep(300);
                bluebutton.BackColor = Color.Blue;
                Refresh();
                Thread.Sleep(400);
                int guess = i++;               // add 1 to guess
                if [guess] = Form1.pattern.Count) 
                ComputerTurn();
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                greenButton.BackColor = Color.LimeGreen;
                Refresh();
                Thread.Sleep(300);
                greenButton.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(400);
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                yellowButton.BackColor = Color.Khaki;
                Refresh();
                Thread.Sleep(300);
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(400);
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 4)
            {
                redButton.BackColor = Color.IndianRed;
                Refresh();
                Thread.Sleep(300);
                yellowButton.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(400);
                ComputerTurn();
            }
        }
    }
}
