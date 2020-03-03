using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            RockPaperScissors game = new RockPaperScissors();

            while (!readyToQuit)
            {
                System.Console.WriteLine("Do you want to play a game...? (y/n)");
                string input = Console.ReadLine();


                if (input == "n" || input == "no")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound();
                    //play a round and print the result 
                }
            }

            game.PrintSummary();
            //prints out a summary of the rounds
            // (games played, how many wins, how many losses?)
        }
    }
}
