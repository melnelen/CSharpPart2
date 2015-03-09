//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

//Example:
//input	    output
//Hi!	    \u0048\u0069\u0021

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        string myText = Console.ReadLine();
        Console.WriteLine(ConvertToUnicode(myText));
    }

    public static string ConvertToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();
        foreach (char ch in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)ch));
        }
        return result.ToString();
    }
}