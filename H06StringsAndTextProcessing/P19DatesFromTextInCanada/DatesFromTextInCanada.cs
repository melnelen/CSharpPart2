//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string input = Console.ReadLine();
        string format = "d.M.yyyy";
        CultureInfo culture = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(input, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            Console.WriteLine(DateTime.ParseExact(match.ToString(), format, culture).ToShortDateString());
        }
    }
}