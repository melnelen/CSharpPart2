//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words 
//in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToUpper();

        StringBuilder result = new StringBuilder();
        Dictionary<string, int> words = new Dictionary<string, int>();
        CountWords(input, words);
        foreach (var word in words)
        {
            Console.WriteLine("{1,-12}[{0}]", word.Key, word.Value);
        }
    }

    static void CountWords(string text, Dictionary<string, int> words)
    {
        foreach (var match in Regex.Matches(text, @"\w+"))
        {
            if (!words.ContainsKey(match.ToString()))
            {
                words.Add(match.ToString(), 1);
            }
            else
            {
                words[match.ToString()] += 1;
            }
        }
    }
}