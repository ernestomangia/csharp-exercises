using Exercises;

/*
 * These exercises has been taken from coding platforms like HackerRank.
 *
 */

Console.WriteLine("-----------------------------------------");

MakeAnagram();

Console.WriteLine("-----------------------------------------");

FindTheDifference();

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