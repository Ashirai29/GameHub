/* Ashley Ashirai Hlatshwayo
 * GameHub by Ashley Ashirai Hlatshwayo AKA GHOSTTECH.Ashirai
 */

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
    public partial class frmMemoryTiles : Form
    {
        MemoryTilesGame memoryTilesGame =
            new MemoryTilesGame();



        Button[] TileButtons =
            Array.Empty<Button>();



        bool isCheckingTiles = false;



        public frmMemoryTiles()
        {
            InitializeComponent();

            SetUpTileButtons();

            SetUpEvents();

            StartBoard();
        }



        private void SetUpTileButtons()
        {
            TileButtons = new Button[]
            {
                btnTile1,
                btnTile2,
                btnTile3,
                btnTile4,
                btnTile5,
                btnTile6,
                btnTile7,
                btnTile8,
                btnTile9,
                btnTile10,
                btnTile11,
                btnTile12,
                btnTile13,
                btnTile14,
                btnTile15,
                btnTile16
            };



            for (int i = 0; i < TileButtons.Length; i++)
            {
                //The Tag stores the tile position used
                //inside the MemoryTilesGame class.
                TileButtons[i].Tag = i;
            }
        }



        private void SetUpEvents()
        {
            for (int i = 0; i < TileButtons.Length; i++)
            {
                //Remove the event first to prevent it from
                //being connected more than once.
                TileButtons[i].Click -= TileButton_Click;

                //All sixteen tiles use the same click event.
                TileButtons[i].Click += TileButton_Click;
            }



            btnRestart.Click -= btnRestart_Click;

            btnRestart.Click += btnRestart_Click;



            lblBack.Click -= lblBack_Click;

            lblBack.Click += lblBack_Click;
        }



        private void StartBoard()
        {
            //StartGame resets and shuffles the information
            //inside the MemoryTilesGame class.
            memoryTilesGame.StartGame();

            isCheckingTiles = false;



            for (int i = 0; i < TileButtons.Length; i++)
            {
                //Turn every tile face down.
                TileButtons[i].Text = "?";

                TileButtons[i].BackColor =
                    Color.FromArgb(11, 20, 37);

                TileButtons[i].ForeColor =
                    Color.White;

                TileButtons[i].Enabled = true;
            }



            lblMoves.Text =
                memoryTilesGame.GetAttempts().ToString();

            lblPairs.Text =
                memoryTilesGame.GetMatchesFound().ToString() + " / 8";

            lblMemoryStatus.Text =
                "Select two tiles to find a matching pair.";

            btnRestart.Enabled = true;
        }



        private async void TileButton_Click(
            object? sender,
            EventArgs e)
        {
            if (isCheckingTiles)
            {
                //The player must wait while the current
                //two selected tiles are being checked.
                return;
            }



            if (memoryTilesGame.GetIsGameOver())
            {
                lblMemoryStatus.Text =
                    "The game is over. Restart the board to play again.";

                return;
            }



            if (sender is not Button SelectedButton)
            {
                //Exit if this event was not triggered by a button.
                return;
            }



            int TileIndex =
                Convert.ToInt32(SelectedButton.Tag);



            string TileValue =
                memoryTilesGame.SelectTile(TileIndex);



            if (TileValue == string.Empty)
            {
                //The tile was not a valid selection.
                return;
            }



            //Reveal the selected tile.
            SelectedButton.Text =
                TileValue;

            SelectedButton.BackColor =
                Color.FromArgb(92, 63, 235);



            if (!memoryTilesGame.HasTwoTilesSelected())
            {
                lblMemoryStatus.Text =
                    "Select one more tile.";

                return;
            }



            //Prevent the player from selecting another tile
            //while the current pair is being checked.
            isCheckingTiles = true;

            btnRestart.Enabled = false;



            int FirstSelectedTile =
                memoryTilesGame.GetFirstSelectedTile();

            int SecondSelectedTile =
                memoryTilesGame.GetSecondSelectedTile();



            string result =
                memoryTilesGame.CheckMatch();



            lblMemoryStatus.Text =
                result;

            UpdateGameStatistics();



            if (memoryTilesGame.IsTileMatched(
                FirstSelectedTile))
            {
                //The selected tiles are a matching pair,
                //so they remain visible.

                TileButtons[FirstSelectedTile].BackColor =
                    Color.FromArgb(92, 63, 235);

                TileButtons[SecondSelectedTile].BackColor =
                    Color.FromArgb(92, 63, 235);
            }
            else
            {
                //Keep the incorrect tiles visible briefly
                //so that the player can see their values.
                await Task.Delay(800);



                if (this.IsDisposed ||
                    this.Disposing)
                {
                    //Stop the method if the Form was closed
                    //while waiting for the tiles.
                    return;
                }



                //Turn the incorrect tiles face down again.
                TileButtons[FirstSelectedTile].Text =
                    "?";

                TileButtons[SecondSelectedTile].Text =
                    "?";



                TileButtons[FirstSelectedTile].BackColor =
                    Color.FromArgb(11, 20, 37);

                TileButtons[SecondSelectedTile].BackColor =
                    Color.FromArgb(11, 20, 37);
            }



            //Clear the selections so that the player
            //can select another pair.
            memoryTilesGame.ResetSelectedTiles();

            isCheckingTiles = false;

            btnRestart.Enabled = true;
        }



        private void UpdateGameStatistics()
        {
            lblMoves.Text =
                memoryTilesGame.GetAttempts().ToString();

            lblPairs.Text =
                memoryTilesGame.GetMatchesFound().ToString() + " / 8";
        }



        private void btnRestart_Click(
            object? sender,
            EventArgs e)
        {
            StartBoard();
        }



        private void lblBack_Click(
            object? sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}