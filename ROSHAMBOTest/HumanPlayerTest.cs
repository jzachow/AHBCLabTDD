﻿using ROSHAMBO;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ROSHAMBOTest
{
    public class HumanPlayerTest
    {
        [Fact]
        public void PlayerGetsNameTest()
        {
            //Arrange
            var expectedResult = "Justin";
            var humanPlayer = new HumanPlayer("Justin");

            //Act
            var result = humanPlayer.Name;

            Assert.Equal(expectedResult, result);
        }
    }
}