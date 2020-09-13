using ROSHAMBO;
using System;
using Xunit;

namespace ROSHAMBOTest
{
    public class RPSTest
    {
        [Fact]
        public void RockBeatsScissorsTest()
        {
            //Arrange
            var expectedResult = 1;
            RPS rps = new RPS();

            //Act
            int result = rps.PlayRound("rock", "scissors");

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PaperBeatsRockTest()
        {
            //Arrange
            var expectedResult = 1;
            RPS rps = new RPS();

            //Act
            int result = rps.PlayRound("paper", "rock");

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScissorsBeatsPaperTest()
        {
            //Arrange
            var expectedResult = 1;
            RPS rps = new RPS();

            //Act
            int result = rps.PlayRound("scissors", "paper");

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SameChoiceResultsInTieTest()
        {
            //Arrange
            var expectedResult = 2;
            RPS rps = new RPS();

            //Act
            int result1 = rps.PlayRound("rock", "rock");
            int result2 = rps.PlayRound("paper", "paper");
            int result3 = rps.PlayRound("scissors", "scissors");

            //Assert
            Assert.Equal(expectedResult, result1);
            Assert.Equal(expectedResult, result2);
            Assert.Equal(expectedResult, result3);
        }

    }
}
