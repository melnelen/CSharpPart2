//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        MatchEmail(input);
    }

    static void MatchEmail(string input)
    {
        string emailRegex = @"[a-zA-Z0-9.!#$%&'*+-/=?\^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*";
        MatchCollection emails = Regex.Matches(input, emailRegex);
        foreach (Match item in emails)
        {
            Console.WriteLine(item);
        }
    }
}