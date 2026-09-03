using GameHub.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHub
{
    public partial class frmGuessNumber : Form
    {
        GuessNumberGame guessNumberGame = new GuessNumberGame();
        public frmGuessNumber()
        {
            InitializeComponent();

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            guessNumberGame.StartGame();
            lblAttempts.Text = guessNumberGame.GetAttempts().ToString() + "/10";
        }

        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            //guessNumberGame.GetUserInput(txtGuess.Text);
            
            lblHint.Text = guessNumberGame.CheckGuess(guessNumberGame.GetUserInput(txtGuess.Text));
            lblAttempts.Text = guessNumberGame.GetAttempts().ToString()+"/10";
            txtGuess.ResetText();
        }
    }
}
