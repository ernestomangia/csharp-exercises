using System;
using System.Collections.Generic;
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

        [Fact]
        public void Alternating_Characters()
        {
            var s1 = "AAAA";
            var s2 = "BBBBB";
            var s3 = "ABABABAB";
            var s4 = "BABABA";
            var s5 = "AAABBB";

            var result1 = Algorithms.AlternatingCharacters(s1);
            var result2 = Algorithms.AlternatingCharacters(s2);
            var result3 = Algorithms.AlternatingCharacters(s3);
            var result4 = Algorithms.AlternatingCharacters(s4);
            var result5 = Algorithms.AlternatingCharacters(s5);

            Assert.Equal(3, result1);
            Assert.Equal(4, result2);
            Assert.Equal(0, result3);
            Assert.Equal(0, result4);
            Assert.Equal(4, result5);
        }

        [Fact]
        public void Valid_Sherlock_String()
        {
            var s1 = "hgfedcbaeabcdefgh";

            var result = Algorithms.IsValidSherlockString(s1);

            Assert.Equal("YES", result);
        }

        [Fact]
        public void Invalid_Sherlock_String()
        {
            var s1 = "aabbcd";

            var result = Algorithms.IsValidSherlockString(s1);

            Assert.Equal("NO", result);
        }

        [Fact]
        public void Substring_Count()
        {
            var s1 = "aabbcd";

            var result = Algorithms.SubstringCount(s1.Length, s1);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Flipping_Matrix()
        {
            var matrix = new List<List<int>>
            {
                new() {112, 42, 83, 119},
                new() {56, 125, 56, 49},
                new() {15, 78, 101, 43},
                new() {62, 98, 114, 108}
            };

            var result = Algorithms.FlippingMatrix(matrix);

            Assert.Equal(414, result);
        }

        [Fact]
        public void Minimum_Bribes()
        {
            var queue1 = new List<int> { 2, 1, 5, 3, 4 };
            var queue2 = new List<int> { 2, 5, 1, 3, 4 };

            var result1 = Algorithms.MinimumBribes(queue1);
            var result2 = Algorithms.MinimumBribes(queue2);

            Assert.Equal(result1, result1);
            Assert.Equal(result2, result2);
        }

        [Fact]
        public void Order_Sizes()
        {
            var s1 = "SLMSLM";

            var result = Algorithms.OrderSizes(s1);

            Assert.Equal("SSMMLL", result);
        }

        [Fact]
        public void Binary_Gap()
        {
            var n1 = 64;            // 1000000      Gap = 0
            var n2 = 31;            // 11111        Gap = 0
            var n3 = 100;           // 1100100      Gap = 2
            var n4 = 529;           // 1000010001   Gap = 4
            var n5 = 1073741825;    // 1000010001   Gap = 29

            var result1 = Algorithms.BinaryGap(n1);
            var result2 = Algorithms.BinaryGap(n2);
            var result3 = Algorithms.BinaryGap(n3);
            var result4 = Algorithms.BinaryGap(n4);
            var result5 = Algorithms.BinaryGap(n5);

            Assert.Equal(0, result1);
            Assert.Equal(0, result2);
            Assert.Equal(2, result3);
            Assert.Equal(4, result4);
            Assert.Equal(29, result5);
        }


        [Fact]
        public void Super_Reduced_String()
        {
            var s1 = "aaabccddd";

            var result1 = Algorithms.SuperReducedString(s1);

            Assert.Equal("abd", result1);
        }

        [Fact]
        public void Caesar_Cipher()
        {
            var s1 = "middle-Outz";
            var s2 = "Always-Look-on-the-Bright-Side-of-Life";
            var s3 = "abc";

            var result1 = Algorithms.CaesarCipher(s1, 2);
            var result2 = Algorithms.CaesarCipher(s2, 5);
            var result3 = Algorithms.CaesarCipher(s3, 53);

            Assert.Equal("okffng-Qwvb", result1);
            Assert.Equal("Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj", result2);
            Assert.Equal("bcd", result3);
        }

        [Fact]
        public void Minimum_Number()
        {
            var s1 = "2bb#A";

            var result1 = Algorithms.MinimumNumber(s1);

            Assert.Equal(1, result1);
        }

        [Fact]
        public void Rotate_Array()
        {
            var k1 = 5;
            var arr1 = new int[] { 3, 8, 9, 7, 6 };

            var k2 = 0;
            var arr2 = new int[] { 3 };

            var k3 = 0;
            var arr3 = new int[] { };

            var k4 = 1;
            var arr4 = new int[] { 988, 8, 10};

            var result1 = Algorithms.RotateArray(arr1, k1);
            var result2 = Algorithms.RotateArray(arr2, k2);
            var result3 = Algorithms.RotateArray(arr3, k3);
            var result4 = Algorithms.RotateArray(arr4, k4);

            Assert.Equal(new int[] { 3, 8, 9, 7, 6 }, result1);
            Assert.Equal(new int[] { 3 }, result2);
            Assert.Equal(new int[] { }, result3);
            Assert.Equal(new int[] { 10, 988, 8 }, result4);
        }

        [Fact]
        public void Find_Unpaired_Number()
        {
            var arr1 = new int[] { 1000, 801, 100, 1000, 100 };

            var result1 = Algorithms.FindUnpairedNumber_Solution2(arr1);
            
            Assert.Equal(801, result1);
        }
    }
}