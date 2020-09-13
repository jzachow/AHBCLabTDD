using System;

namespace ROSHAMBO
{
    public class RPS
    {
        public int PlayRound(string playerChoice, string gameChoice)
        {
            if (playerChoice.Equals(gameChoice))
                return 2;
            if (playerChoice.Equals("rock") && gameChoice.Equals("scissors"))
                return 1;
            if (playerChoice.Equals("paper") && gameChoice.Equals("rock"))
                return 1;
            if (playerChoice.Equals("scissors") && gameChoice.Equals("paper"))
                return 1;

            return 0;
        }
    }
}
