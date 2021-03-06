﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class HumanPlayer
    {
        public string Name { get; set; }
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public string GetChoice()
        {
            Console.WriteLine("Please enter your choice: 1. Rock 2. Paper 3. Scissors");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                default:
                    return "scissors";
            }           
        }
    }
}
