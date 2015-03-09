//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	    output
//.NET	    platform for applications from Microsoft
//CLR	    managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>()
        {
        {".NET", "platform for applications from Microsoft"},
        {"CLR", "managed execution environment for .NET"},
        {"namespace", "hierarchical organization of classes"}
        };

        string input = Console.ReadLine();
        string output = string.Empty;
        if (myDictionary.TryGetValue(input, out output))
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("I don't konow this word");
        }
    }
}