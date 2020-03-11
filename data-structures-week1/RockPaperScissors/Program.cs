using System;
using RockPaperScissors.Library;

namespace RockPaperScissors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            InputterOutputter inputOutputSpecific = new InputterOutputter();
            IInputterOutputter inputOutputGeneral = inputOutputSpecific; // this is called upcasting
            var game = new RockPaperScissorsGame(inputOutputGeneral);

            bool readyToQuit = false;
            

            while (!readyToQuit)
            {

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
