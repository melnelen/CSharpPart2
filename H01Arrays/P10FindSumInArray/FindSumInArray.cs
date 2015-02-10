//Problem 10. Find sum in array

//Write a program that finds in given array of integers 
//a sequence of given sum S (if present).

//Example:
//array	                    S	    result
//4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5

using System;
using System.Linq;
using System.IO;

class FindSumInArray
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p10text.txt");
        //Console.SetIn(reader);

        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        int mySum = int.Parse(Console.ReadLine());

        int start = 0;
        int sum = 0;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            start = i;
            sum += myArr[i];

            for (int j = i + 1; j < myArr.Length; j++)
            {
                sum += myArr[j];

                if (sum == mySum)
                {
                    Console.Write("sequence: ");
                    for (int k = start; k <= j; k++)
                    {
                        Console.Write(myArr[k] + " ");
                    }
                }
            }
            sum = 0;
        }
        Console.WriteLine();
        Console.WriteLine("sum: {0}", mySum);
    }
}