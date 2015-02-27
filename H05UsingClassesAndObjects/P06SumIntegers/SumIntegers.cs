//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	                output
//"43 68 9 23 318"	    461

using System;
using System.Linq;

class SumIntegers
{
    static void Main(string[] args)
    {
        string myString = Console.ReadLine();
        Console.WriteLine(CalcSumFromString(myString));
    }

    static long CalcSumFromString(string str)
    {
        int[] arr = str
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        long sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}