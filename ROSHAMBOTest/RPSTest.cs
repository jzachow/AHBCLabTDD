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
        public void ScissorsBeatsPaperTesT()
        {
            //Arrange
            var expectedResult = 1;
            RPS rps = new RPS();

            //Act
            int result = rps.PlayRound("scissors", "paper");

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
