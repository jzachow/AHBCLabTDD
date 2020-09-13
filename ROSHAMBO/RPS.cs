using System;

namespace ROSHAMBO
{
    public class RPS
    {
        public int PlayRound(string playerChoice, string gameChoice)
        {
            int result = 0;

            if (playerChoice.Equals(gameChoice))
                result = 2;
            if (playerChoice.Equals("rock") && gameChoice.Equals("scissors"))
                result = 1;
            if (playerChoice.Equals("paper") && gameChoice.Equals("rock"))
                result = 1;
            if (playerChoice.Equals("scissors") && gameChoice.Equals("paper"))
                result = 1;

            return result;
        }
    }
}
