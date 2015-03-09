//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series 
//of consecutive identical letters with a single one.

//Example:
//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(UniqueLetters(input));
    }

    static string UniqueLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }
}