//Problem 5. Workdays

//Write a method that calculates the number of workdays 
//between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday 
//except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;

class Workdays
{
    static List<DateTime> officialHolidays = new List<DateTime>()
    {
        new DateTime(2013, 01, 01), new DateTime(2013, 01, 02), new DateTime(2013, 03, 03), 
        new DateTime(2013, 05, 01), new DateTime(2013, 05, 24), new DateTime(2013, 09, 22), 
        new DateTime(2013, 10, 01), new DateTime(2013, 12, 24), new DateTime(2013, 12, 25),
        new DateTime(2013, 12, 26)
    };

    static void Main()
    {
        Console.WriteLine("Enter day in format YEAR/MONTH/DAY:");
        string[] dateStr = Console.ReadLine().Split('/');
        int year = int.Parse(dateStr[0]);
        int days = int.Parse(dateStr[2]);
        int month = int.Parse(dateStr[1]);
        DateTime endDate = new DateTime(year, month, days);
        Console.Write("There are {0} working days between {1} and {2}", CalcWorkingDays(DateTime.Now, endDate), DateTime.Now, endDate);
    }

    static List<DateTime> GetAllDays(DateTime from, DateTime to)
    {
        List<DateTime> dates = new List<DateTime>();
        for (var dt = from; dt <= to; dt = dt.AddDays(1))
        {
            dates.Add(dt);
        }
        return dates;
    }

    static bool IsWorkingDay(DateTime date)
    {
        return (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            && !officialHolidays.Contains(date);
    }

    static int CalcWorkingDays(DateTime from, DateTime to)
    {
        List<DateTime> allDates = GetAllDays(from, to);
        return allDates.Where(day => IsWorkingDay(day)).Count();
    }
}