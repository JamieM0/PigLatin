using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.

namespace PigLatinForms
{
    public partial class RPS : Form
    {
        int playerScore = 0;
        int opponentsScore = 0;
        int playerSelection = 0;

        public RPS()
        {
            InitializeComponent();
            pnlOpponentsSide.Visible = false;
        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            playerSelection = 1;
            pbPlayerSelection.Image = PigLatinForms.Properties.Resources.rock;
            movePlayerSideToLeft();
        }

        private void pbPaper_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
            pbPlayerSelection.Image = PigLatinForms.Properties.Resources.paper;
            movePlayerSideToLeft();
        }

        private void pbScissors_Click(object sender, EventArgs e)
        {
            playerSelection = 3;
            pbPlayerSelection.Image = PigLatinForms.Properties.Resources.scissors;
            movePlayerSideToLeft();
        }

        private void movePlayerSideToLeft()
        {
            int currentX = pnlPlayerSide.Location.X;
            int currentY = pnlPlayerSide.Location.Y;
            int animationSpeed = 248;
            Point currentP = new Point(currentX, currentY);
            if (currentP != new Point(37, 90))
            {
                for (int i = 0; i < animationSpeed; i++)
                {
                    pnlPlayerSide.Location = new Point(pnlPlayerSide.Location.X - 1, currentY);
                }
            }
            pnlOpponentsSide.Visible = true;
            disablePlayerOptions();
            opponentsGenerator();
        }

        private void disablePlayerOptions()
        {
            pbRock.Image = PigLatinForms.Properties.Resources.rock_disabled;
            pbPaper.Image = PigLatinForms.Properties.Resources.paper_disabled;
            pbScissors.Image = PigLatinForms.Properties.Resources.scissors_disabled;
            pbRock.Enabled = false;
            pbPaper.Enabled = false;
            pbScissors.Enabled = false;
        }

        private void enablePlayerOptions()
        {
            pbRock.Image = PigLatinForms.Properties.Resources.rock;
            pbPaper.Image = PigLatinForms.Properties.Resources.paper;
            pbScissors.Image = PigLatinForms.Properties.Resources.scissors;
            pbRock.Enabled = true;
            pbPaper.Enabled = true;
            pbScissors.Enabled = true;
        }

        private void opponentsGenerator()
        {
            //Generate random number between 1 and 3
            Random rnd = new Random();
            int opponentsChoice = rnd.Next(1, 4);
            if (opponentsChoice == 1)
            {
                pbOpponentsSelection.SizeMode = PictureBoxSizeMode.Zoom;
                pbOpponentsSelection.Image = PigLatinForms.Properties.Resources.rock;
            }
            else if (opponentsChoice == 2)
            {
                pbOpponentsSelection.SizeMode = PictureBoxSizeMode.Zoom;
                pbOpponentsSelection.Image = PigLatinForms.Properties.Resources.paper;
            }
            else if (opponentsChoice == 3)
            {
                pbOpponentsSelection.SizeMode = PictureBoxSizeMode.Zoom;
                pbOpponentsSelection.Image = PigLatinForms.Properties.Resources.scissors;
            }
            
            if (playerSelection == opponentsChoice)
            {
                enablePlayerOptions();
                //movePlayerSideToRight();
            }
            else if (playerSelection == 1 && opponentsChoice == 2)
            {
                ScoreOpponent();
            }
            else if (playerSelection == 1 && opponentsChoice == 3)
            {
                ScorePlayer();
            }
            else if (playerSelection == 2 && opponentsChoice == 1)
            {
                ScorePlayer();
            }
            else if (playerSelection == 2 && opponentsChoice == 3)
            {
                ScoreOpponent();
            }
            else if (playerSelection == 3 && opponentsChoice == 1)
            {
                ScoreOpponent();
            }
            else if (playerSelection == 3 && opponentsChoice == 2)
            {
                ScorePlayer();
            }
        }

        public void ScorePlayer()
        {
            playerScore++;
            lbPlayerScore.Text = playerScore.ToString();
            enablePlayerOptions();
        }

        public void ScoreOpponent()
        {
            opponentsScore++;
            lbOpponentsScore.Text = opponentsScore.ToString();
            enablePlayerOptions();
        }
    }
}
