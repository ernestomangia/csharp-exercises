using Xunit;

namespace Exercises.UnitTests
{
    public class AlgorithmsTests
    {
        [Fact]
        public void Make_Valid_Anagram()
        {
            var s1 = "fcrxzwscanmligyxyvym";
            var s2 = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            var result = Algorithms.MakeAnagram(s1, s2);

            Assert.Equal(30, result);
        }

        [Fact]
        public void Find_The_Difference()
        {
            var s1 = "aaabbb";
            var s2 = "bababaz";

            var result = Algorithms.FindTheDifference(s1, s2);

            Assert.Equal('z', result);
        }
    }
}