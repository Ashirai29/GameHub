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
    internal class GuessNumberGame
    {
        const int MaximumAttempts = 10;

        int TargetNumber = Random.Shared.Next(1, 101);

        int attempts = 0;

        int NumberGuessed;

        bool isGameOver = false;

        int score = 0;

        int bestScore = 0;



        public void StartGame()
        {
            TargetNumber = Random.Shared.Next(1, 101);
            attempts = 0;
            NumberGuessed = 0;
            isGameOver = false;
            score = 0;

            //bestScore is not reset because it must remain available for the next game.
        }



        public int GetUserInput(string input)
        {
            if (isGameOver)
            {
                // Console.WriteLine("The game is over. Please start a new game.");
                return -5; // Return -5 to indicate that the game is over.
            }

            //Console.WriteLine("Guess a number between 1 and 100: "); This line is commented out cause console output in a GUI isnt good.
            // string input = input; Removed this line because input is already passed as a parameter to the method.

            if (int.TryParse(input, out int guess))
            {
                if (guess < 1 || guess > 100)
                {
                    NumberGuessed = -1;
                    return NumberGuessed;
                } // Checking if the guess is valid in terms of our given range

                NumberGuessed = guess;
                attempts++;

                //The attempt limit was previously checked here.
                //It was moved to CheckGuess so that the player can still win on their final attempt.
                //return -5; Return -5 was previously used to indicate that the game was over due to reaching the maximum number of attempts.

                //return NumberGuessed; terribly placed return statement, moved to the end of the method.
            }
            else
            {
                //Console.WriteLine("Invalid input. Please enter a valid number."); Commented out because console output in a GUI isnt good.
                NumberGuessed = -1; // Set NumberGuessed to -1 to indicate invalid input.
                // GetUserInput(); not needed since the input is already passed as a parameter to the method
                //need to call GetUserInput() again to get a new input from the user, but since this is a GUI application, we should not call it recursively.
            }

            return NumberGuessed;// moved the return statement here to ensure that the method always returns a value, even if the input is invalid.
        }



        public string CheckGuess(int NumberGuessed)
        {
            string result = "";

            if (NumberGuessed == -1)
            {
                result = "Invalid input. Please enter a number between 1 and 100.";
                return DisplayVerdict(result); // Exit the method if the input is invalid.
            }

            if (NumberGuessed == -5)
            {
                result = "The game is over. Please start a new game.";
                return DisplayVerdict(result); // Exit the method because the current game has already ended.
            }

            if (NumberGuessed == TargetNumber)
            {
                isGameOver = true;
                score = CalculateScore();

                result = ($"Congratulations! You've guessed the number {TargetNumber} in {attempts} attempts. Your score is {score}.");
            }
            else if (attempts >= MaximumAttempts)
            {
                isGameOver = true;
                score = 0;

                result = $"Game over! You've reached the maximum number of attempts. The correct number was {TargetNumber}. Your score is {score}.";

                //Console.WriteLine($"Game over! You've reached the maximum number of attempts. The correct number was {TargetNumber}.");
                //return -5; Return -5 is no longer needed here because CheckGuess returns the verdict for the GUI.
            }
            else if (NumberGuessed < TargetNumber)
            {
                result = "Too low! Try again.";

                //GetUserInput(); not needed since the input is already passed as a parameter to the method, and we don't want to call the method recursively without a new input.
                //CheckGuess(NumberGuessed);
            }
            else if (NumberGuessed > TargetNumber)
            {
                result = "Too high! Try again.";

                //CheckGuess(GetUserInput());
            }

            return DisplayVerdict(result);
        }



        public int CalculateScore()
        {
            if (NumberGuessed == TargetNumber)
            {
                score = (MaximumAttempts - attempts + 1) * 100;

                if (score > bestScore)
                {
                    bestScore = score;
                }
            }
            else
            {
                score = 0;
            }

            return score;
        }



        public string DisplayVerdict(string result)
        {
            return result;
        }



        /*
        public void ResetGame()
        {
            TargetNumber = Random.Shared.Next(1, 101);
            attempts = 0;
            NumberGuessed = 0;
            isGameOver = false;
            score = 0;

            //bestScore is not reset because it must remain available for the next game.
        }
        */



        public int GetAttempts()
        {
            return attempts;
        }



        public int GetScore()
        {
            return score;
        }



        public int GetBestScore()
        {
            return bestScore;
        }



        public string GetTargetNumber()
        {
            return TargetNumber.ToString();
        }
    }
}