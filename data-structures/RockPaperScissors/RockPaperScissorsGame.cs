using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {

        string compChoice = null;
        int userWins = 0;
        int compWins = 0;
        int ties = 0;
        int gamesPlayed = 0;

        public void PlayRound()
        {
            System.Console.WriteLine("");
            int roundNumber = userWins + compWins + ties + 1;
            System.Console.WriteLine("Game " + roundNumber);
            System.Console.WriteLine("Enter 'rock', 'paper', or 'scissors'...?");
            string input = Console.ReadLine();

            string computersMove = SetCompChoice();

            System.Console.WriteLine("Computer chose " + computersMove);

            if (input == computersMove)
            {
                ties++;
                gamesPlayed++;
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
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "paper")
                    {   
                        compWins++;
                        gamesPlayed++;
                        System.Console.WriteLine("Loser!");
                    }
                }
                
                if(input == "paper")
                {
                    if(computersMove == "rock")
                    {
                        userWins++;
                        gamesPlayed++;
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "scissors")
                    {   
                        compWins++;
                        gamesPlayed++;
                        System.Console.WriteLine("Loser!");
                    }
                }

                if(input == "scissors")
                {
                    if(computersMove == "paper")
                    {
                        userWins++;
                        gamesPlayed++;
                        System.Console.WriteLine("Nice job!");
                    }
                    else if(computersMove == "rock")
                    {   
                        compWins++;
                        gamesPlayed++;
                        System.Console.WriteLine("Loser!");
                    }
                }
            }
            System.Console.WriteLine("=========================================================================================");
            System.Console.WriteLine("");
        }

        public void PrintSummary()
        {
            System.Console.WriteLine("User Wins: " + userWins + "\n" + "Computer Wins: " + compWins + "\n" + "Games Tied: " + ties +"\n" + "Games Played: " + gamesPlayed);
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