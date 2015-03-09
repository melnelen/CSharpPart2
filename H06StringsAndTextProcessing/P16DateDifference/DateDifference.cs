//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Globalization;

class DateDifference
{
    static void Main(string[] args)
    {
        string format = "d.M.yyyy";
        CultureInfo culture = CultureInfo.InvariantCulture;
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), format, culture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), format, culture);
        Console.WriteLine("Distance: " + (endDate - startDate).TotalDays);
    }
}