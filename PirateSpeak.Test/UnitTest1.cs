using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Test
{
    public class UnitTest1
    {
        [Fact]
        public void pirate_does_speak()
        {
            //Arrange
            var nonsense = "ebwol";
            var possibleWords = new List<string> { "elbow", "bowl", "below" };
            var expectedResults = new List<string> { "elbow", "below" };
            var translator = new Pirate();


            //Act

            var actualResults = translator.GetPossibleWords(nonsense, possibleWords);

            //Assert

            Assert.Equal(expectedResults, actualResults);

        }
    }
}
