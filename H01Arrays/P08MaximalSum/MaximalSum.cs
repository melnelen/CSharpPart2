//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

//Example:
//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4

//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Linq;
using System.IO;

class MaximalSum
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p08text.txt");
        //Console.SetIn(reader);

        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int start = 0;
        int end = 0;
        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            if (sum <= 0)
            {
                start = i;
                sum = 0;
            }

            sum += myArr[i];

            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
            }
        }
        Console.Write("sequence: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("max sum: {0}", maxSum);
    }
}