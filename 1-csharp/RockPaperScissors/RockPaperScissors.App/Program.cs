using System;
using RockPaperScissorsGame.Library;

namespace RockPaperScissorsGame.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            var game = new RockPaperScissors();

            while (!readyToQuit)
            {
                System.Console.Write("Do you want to play a game...? (y/n): ");
                string input = Console.ReadLine().ToLower();


                if (input == "n" || input == "no")
                {
                    readyToQuit = true;
                }
                else if (input == "y" || input == "yes")
                {
                    game.PlayRound();
                    //play a round and print the result 
                }
                else
                {
                    System.Console.WriteLine("you must choose...");
                }
            }

            game.PrintSummary();
            //prints out a summary of the rounds
            // (games played, how many wins, how many losses?)
        }
    }
}
