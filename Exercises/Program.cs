using Exercises;
using Exercises.Extensions;

/*
 * These exercises has been taken from coding platforms like HackerRank.
 *
 */

Console.WriteLine(" MakeAnagram ".PadBoth(50, '-'));

MakeAnagram();

Console.WriteLine(" FindTheDifference ".PadBoth(50, '-'));

FindTheDifference();

Console.WriteLine(" Epigram ".PadBoth(50, '-'));

var sum = Algorithms.Epigram("why and how");

Console.WriteLine(sum);

Console.WriteLine(" PalindromesSumFrom0ToN ".PadBoth(50, '-'));

var palindromes = Algorithms.PalindromesSumFrom0ToN(10000);

Console.WriteLine(palindromes);

Console.WriteLine(" SumOddFibonacciLowerThanN ".PadBoth(50, '-'));

var oddFibonacci = Algorithms.SumOddFibonacciLowerThanN(20);

Console.WriteLine(oddFibonacci);

Console.WriteLine("-----------------------------------------");

Console.ReadLine();

void MakeAnagram()
{
    Console.WriteLine("Algorithm #1: Make Anagram");

    var s1 = "fcrxzwscanmligyxyvym";
    var s2 = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

    var result = Algorithms.MakeAnagram(s1, s2);

    Console.WriteLine($"String 1: {s1}");
    Console.WriteLine($"String 2: {s2}");
    Console.WriteLine($"Result: {result}");
}

void FindTheDifference()
{
    Console.WriteLine($"Algorithm #2: Find The Difference");

    var s1 = "abc";
    var s2 = "acba";

    var result = Algorithms.FindTheDifference(s1, s2);

    Console.WriteLine($"String 1: {s1}");
    Console.WriteLine($"String 2: {s2}");
    Console.WriteLine($"Result: {result}");
}