using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissors
    {

        string compChoice = null;
        int userWins = 0;
        int compWins = 0;
        int ties = 0;
        int gamesPlayed = 0;
        List<string> roundResults = new List<string>();

        public void PlayRound()
        {
            System.Console.WriteLine("");
            int roundNumber = roundResults.Count + 1;
            
            System.Console.WriteLine("Game " + roundNumber);
            System.Console.Write("Enter 'rock', 'paper', or 'scissors': ");
            string input = Console.ReadLine().ToLower();

            string computersMove = SetCompChoice();

            System.Console.WriteLine("You: " + input);
            System.Console.WriteLine("Computer: " + computersMove);

            if (input == computersMove)
            {
                ties++;
                gamesPlayed++;
                roundResults.Add("tie");
                Console.WriteLine("tie game.");
            }
            else
            {
                if(input == "rock")
                {
                    if(computersMove == "scissors")
                    {
                        userWins++;
                        gamesPlayed++;
                        roundResults.Add("win");
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "paper")
                    {   
                        compWins++;
                        gamesPlayed++;
                        roundResults.Add("loss");
                        System.Console.WriteLine("Loser!");
                    }
                }
                
                if(input == "paper")
                {
                    if(computersMove == "rock")
                    {
                        userWins++;
                        gamesPlayed++;
                        roundResults.Add("win");
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "scissors")
                    {   
                        compWins++;
                        gamesPlayed++;
                        roundResults.Add("loss");
                        System.Console.WriteLine("Loser!");
                    }
                }

                if(input == "scissors")
                {
                    if(computersMove == "paper")
                    {
                        userWins++;
                        gamesPlayed++;
                        roundResults.Add("win");
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "rock")
                    {   
                        compWins++;
                        gamesPlayed++;
                        roundResults.Add("loss");
                        System.Console.WriteLine("Loser!");
                    }
                }
            }
            System.Console.WriteLine("___________________________________________________________________________________________" + "\n\n");
        }

        public void PrintSummary()
        {
            System.Console.WriteLine("User Wins: " + userWins + "\n" + "Computer Wins: " + compWins + "\n" + "Games Tied: " + ties +"\n" + "Games Played: " + gamesPlayed);
 
            foreach (string result in roundResults)
            {
                System.Console.WriteLine(result + " ");
            }
            System.Console.WriteLine();
        }

        string SetCompChoice()
        {
            Random randomNum = new System.Random();
            int value = randomNum.Next(1, 4);
                  
            switch (value)
            {
                case 1:
                    compChoice = "rock";
                    break;
                case 2:
                    compChoice = "paper";
                    break;
                case 3:
                    compChoice = "scissors";
                    break;
            }
            
            return compChoice;
        }
    }
}