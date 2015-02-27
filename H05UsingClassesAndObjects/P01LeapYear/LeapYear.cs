//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Check if year is leap: ");
        int myYear = int.Parse(Console.ReadLine());
        if (CheckLeapYear(myYear))
        {
            Console.WriteLine("leap");
        }
        else
        {
            Console.WriteLine("not leap");
        }
    }

    static bool CheckLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 == 0);
    }
}