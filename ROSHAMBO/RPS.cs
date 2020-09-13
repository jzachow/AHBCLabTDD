using System;

namespace ROSHAMBO
{
    public class RPS
    {
        public int PlayRound(string playerChoice, string gameChoice)
        {
            if (playerChoice.Equals("rock") && gameChoice.Equals("scissors"))
                return 1;
            else
                return 0;
        }
    }
}
