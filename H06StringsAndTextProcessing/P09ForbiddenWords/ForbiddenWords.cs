//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

//Example text: Microsoft announced its next generation PHP compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

class ForbiddenWords
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p09text.txt");
        //Console.SetIn(reader);

        string myText = Console.ReadLine();
        string[] forbidenWords = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        Console.WriteLine(HideForbidenWords(myText, forbidenWords));
    }

    public static string HideForbidenWords(string text, string[] words)
    {
        return Regex.Replace(text, String.Join("|", words), delegate(Match match)
        {
            string newText = match.ToString();
            return Regex.Replace(newText, newText, new String('\u002A', newText.Length));
        }, RegexOptions.IgnoreCase);
    }
}