//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.

//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Linq;

class ExtractSentences
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p08text.txt");
        //Console.SetIn(reader);

        string myText = Console.ReadLine();
        string myKey = Console.ReadLine();

        if (FindMatches(GetSentences(myText), myKey) != String.Empty)
        {
            Console.WriteLine(FindMatches(GetSentences(myText), myKey));
        }
        else
        {
            Console.WriteLine("No matches were found!");
        }

        //string[] sentences = GetSentences(myText);
        //for (int i = 0; i < sentences.Length; i++)
        //{
        //    Console.WriteLine("!{0}!", sentences[i]);
        //}

    }

    public static string[] GetSentences(string text)
    {
        string[] splitText = text
            .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
                .ToArray(); ;

        return splitText;
    }

    public static bool ExactMatch(string text, string key)
    {
        return Regex.IsMatch(text, string.Format(@"\b{0}\b", Regex.Escape(key)), RegexOptions.IgnoreCase);
    }

    public static string FindMatches(string[] text, string key)
    {

        StringBuilder matches = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (ExactMatch(text[i], key))
            {
                matches.Append(text[i] + ". ");
            }
        }
        return matches.ToString();
    }
}