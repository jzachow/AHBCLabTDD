using ROSHAMBO;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ROSHAMBOTest
{
    public class RandomPlayerTest
    {
        [Fact]
        public void RandomPlayerCanReturnRockTest()
        {
            //Arrange
            var expectedResult = "rock";
            var randomPlayer = new RandomPlayer();
            string result = string.Empty;

            //Act
            do
            {
                result = randomPlayer.GenerateChoice();
            } while (!result.Equals("rock"));

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void RandomPlayerCanReturnPaperTest()
        {
            //Arrange
            var expectedresult = "paper";
            var randomPlayer = new RandomPlayer();
            string result = string.Empty;

            //Act
            do
            {
                result = randomPlayer.GenerateChoice();
            } while (!result.Equals("paper"));

            //Assert
            Assert.Equal(expectedresult, result);
        }

        [Fact]
        public void RandomPlayerCanReturnScissorsTest()
        {
            //Arrange
            var expectedresult = "scissors";
            var randomPlayer = new RandomPlayer();
            string result = string.Empty;

            //Act
            do
            {
                result = randomPlayer.GenerateChoice();
            } while (!result.Equals("scissors"));

            //Assert
            Assert.Equal(expectedresult, result);
        }
    }
}
