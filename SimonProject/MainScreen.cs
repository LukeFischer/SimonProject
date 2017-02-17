using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonProject
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen1 gs = new GameScreen1();
            f.Controls.Add(gs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        }
    }

