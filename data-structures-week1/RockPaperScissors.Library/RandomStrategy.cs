using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class RandomStrategy : IRPSStrategy
    {
        public string DecideMove(List<string> previousOutcomes)
        {
            string[] possibleMoves = { "Rock", "Paper", "Scissors" };
            var random = new Random();
            return possibleMoves[random.Next(0, 3)];
        }
    }
}
