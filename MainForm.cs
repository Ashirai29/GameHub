/* Ashley Ashirai Hlatshwayo
 * 31/08/2026
 * GameHub by Ashley Ashirai Hlatshwayo AKA GHOSTTECH.Ashirai
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayGuessNumber_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            frmGuessNumber frmGuessNumber = new frmGuessNumber();
            frmGuessNumber.FormClosed += (s, args) => this.Visible = true;
            frmGuessNumber.Show();


        }

        private void btnPlayMemoryTiles_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMemoryTiles frmMemoryTiles = new frmMemoryTiles();
            frmMemoryTiles.FormClosed += (s, args) => this.Visible = true;
            frmMemoryTiles.Show();
        }

        private void btnPlayMathChallenge_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMathChallenge frmMathChallenge = new frmMathChallenge();
            frmMathChallenge.FormClosed += (s, args) => this.Visible = true;
            frmMathChallenge.Show();
        }

        private void btnPlayTicTacToe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTicTacToe frmTicTacToe = new frmTicTacToe();
            frmTicTacToe.FormClosed += (s, args) => this.Visible = true;
            frmTicTacToe.Show();
        }

        private void btnPlaySnake_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSnake frmSnake = new frmSnake();
            frmSnake.FormClosed += (s, args) => this.Visible = true;
            frmSnake.Show();
        }
    }
}