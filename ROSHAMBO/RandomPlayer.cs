using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class RandomPlayer
    {
        public string GenerateChoice()
        {
            Random random = new Random();
            int choice = random.Next(3);

            switch (choice)
            {
                case 0:
                    return "paper";
                case 1:
                    return "scissors";
                default:                
                    return "rock";
            }           
        }
    }
}
