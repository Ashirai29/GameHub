/* Ashley Ashirai Hlatshwayo
 * GameHub by Ashley Ashirai Hlatshwayo AKA GHOSTTECH.Ashirai
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.GameLogic
{
    internal class MemoryTilesGame
    {

        //List<string> TileValues = new List<string>();

        List<string> TileValues = new List<string>()
        {
            "A", "A",
            "B", "B",
            "C", "C",
            "D", "D",
            "E", "E",
            "F", "F",
            "G", "G",
            "H", "H"
        };



        List<bool> MatchedTiles = new List<bool>();



        int FirstSelectedTile = -1;

        int SecondSelectedTile = -1;



        int attempts = 0;

        int matchesFound = 0;

        int score = 0;



        bool isGameOver = false;



        public MemoryTilesGame()
        {
            StartGame();
        }



        public void StartGame()
        {
            ShuffleTiles();

            MatchedTiles =
                Enumerable.Repeat(false, TileValues.Count).ToList();

            FirstSelectedTile = -1;
            SecondSelectedTile = -1;

            attempts = 0;
            matchesFound = 0;
            score = 0;

            isGameOver = false;
        }



        private void ShuffleTiles()
        {
            for (int i = TileValues.Count - 1; i > 0; i--)
            {
                int RandomPosition =
                    Random.Shared.Next(0, i + 1);

                string TemporaryValue =
                    TileValues[i];

                TileValues[i] =
                    TileValues[RandomPosition];

                TileValues[RandomPosition] =
                    TemporaryValue;
            }
        }


        public string SelectTile(int TileIndex)
        {
            if (isGameOver)
            {
                //The player should start a new game before selecting more tiles
                return "";
            }

            if (TileIndex < 0 ||
                TileIndex >= TileValues.Count)
            {
                //Return an empty string if the given tile position is invalid
                return "";
            }

            if (MatchedTiles[TileIndex])
            {
                //A tile that has already been matched cannot be selected again
                return "";
            }

            if (TileIndex == FirstSelectedTile)
            {
                //The same tile cannot be selected as both the first and second tile
                return "";
            }

            if (FirstSelectedTile == -1)
            {
                FirstSelectedTile = TileIndex;

                return TileValues[TileIndex];
            }

            if (SecondSelectedTile == -1)
            {
                SecondSelectedTile = TileIndex;

                return TileValues[TileIndex];
            }

            return "";
        }



        public bool HasTwoTilesSelected()
        {
            if (FirstSelectedTile != -1 &&
                SecondSelectedTile != -1)
            {
                return true;
            }

            return false;
        }



        public string CheckMatch()
        {
            string result = "";

            if (!HasTwoTilesSelected())
            {
                result =
                    "Please select a second tile.";

                return result;
            }

            //One attempt is counted after the player has selected two tiles
            attempts++;

            if (TileValues[FirstSelectedTile] ==
                TileValues[SecondSelectedTile])
            {
                MatchedTiles[FirstSelectedTile] = true;

                MatchedTiles[SecondSelectedTile] = true;

                matchesFound++;

                CalculateScore(true);

                result =
                    "It is a match!";

                if (matchesFound ==
                    TileValues.Count / 2)
                {
                    isGameOver = true;

                    //The player receives an extra 200 points
                    //for finding all the matching pairs
                    score += 200;

                    result =
                        $"Congratulations! You found all the pairs " +
                        $"in {attempts} attempts. Your score is {score}.";
                }
            }
            else
            {
                CalculateScore(false);

                result =
                    "The tiles do not match. Try again.";
            }

            //The result is now returned directly 
            //DisplayVerdict method is not needed anymore
            return result;
        }



        public void ResetSelectedTiles()
        {
            FirstSelectedTile = -1;

            SecondSelectedTile = -1;
        }



        public int CalculateScore(bool isMatch)
        {
            if (isMatch)
            {
                //The player receives 100 points for every match
                score += 100;
            }
            else
            {
                //The player loses 10 points for an incorrect match
                score -= 10;

                if (score < 0)
                {
                    //The player's score should never be less than zero
                    score = 0;
                }
            }

            return score;
        }



        public string GetTileValue(int TileIndex)
        {
            if (TileIndex < 0 ||
                TileIndex >= TileValues.Count)
            {
                return "";
            }

            return TileValues[TileIndex];
        }



        public bool IsTileMatched(int TileIndex)
        {
            if (TileIndex < 0 ||
                TileIndex >= MatchedTiles.Count)
            {
                return false;
            }

            return MatchedTiles[TileIndex];
        }



        public int GetFirstSelectedTile()
        {
            return FirstSelectedTile;
        }



        public int GetSecondSelectedTile()
        {
            return SecondSelectedTile;
        }



        public int GetAttempts()
        {
            return attempts;
        }



        public int GetMatchesFound()
        {
            return matchesFound;
        }



        public int GetScore()
        {
            return score;
        }



        public bool GetIsGameOver()
        {
            return isGameOver;
        }

        /*public string DisplayVerdict(string result)
        {
            return result;
        }*/
    }
}