//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        foreach (var match in Regex.Matches(input, @"\w+"))
        {
            if (IsPalindrome(match.ToString()))
            {
                result.AppendLine(match.ToString());
            }
        }
        Console.WriteLine(result);
    }

    static bool IsPalindrome(string match)
    {
        for (int left = 0, right = match.Length - 1;
            left < match.Length / 2;
            left++, right--)
        {
            if (match[left] != match[right])
            {
                return false;
            }
        }
        return true;
    }
}