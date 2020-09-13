using System;
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
            return "rock";
        }
    }
}
