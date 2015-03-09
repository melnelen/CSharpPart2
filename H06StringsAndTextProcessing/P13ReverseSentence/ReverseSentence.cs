//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.

//Example:
//input	                                    output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseSentence
{
    static string[] punctuation = new string[] { ".", ",", "-", ":", ";", "!", "?" };

    static void Main()
    {
        string mySentence = Console.ReadLine();
        string reversedSentece = ReverseTheSentence(mySentence);
        Console.WriteLine(reversedSentece);
    }

    private static string ReverseTheSentence(string input)
    {
        StringBuilder sb = new StringBuilder(input.Length);
        string[] words = input
            .Split(new char[] { ' ', ',', '.', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        int counter = 0;
        bool notWord = false;
        for (int i = 0; i < input.Length; i++)
        {

            switch (input[i])
            {
                case ',': sb.Append(words[counter]); ++counter; sb.Append(','); notWord = true; break;
                case '.': sb.Append(words[counter]); ++counter; sb.Append('.'); notWord = true; break;
                case '!': sb.Append(words[counter]); ++counter; sb.Append('!'); notWord = true; break;
                case '?': sb.Append(words[counter]); ++counter; sb.Append('?'); notWord = true; break;
                case '-': sb.Append(words[counter]); ++counter; sb.Append('-'); notWord = true; break;
                default: break;
            }


            if (input[i] == ' ' && !notWord)
            {
                sb.Append(words[counter]);
                sb.Append(' ');
                ++counter;
            }
            else if (input[i] == ' ' && notWord)
            {
                sb.Append(' ');
                notWord = false;
            }

        }
        return sb.ToString();
    }
}