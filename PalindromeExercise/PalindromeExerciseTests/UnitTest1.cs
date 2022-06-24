using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("Hello", false)]
        [InlineData("Wow", true)]
        [InlineData("nope", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var wordsmith = new WordSmith();

            var actual = wordsmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
