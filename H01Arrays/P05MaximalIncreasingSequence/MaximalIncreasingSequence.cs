//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4

using System;
using System.Linq;
using System.IO;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p05text.txt");
        //Console.SetIn(reader);

        int[] seqArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int start = 0;
        int sequence = 1;
        int maxSequence = 1;
        string[] tempIncrArr = new string[seqArr.Length];
        string[] maxIncrArr = new string[seqArr.Length];
        
        for (int i = 0; i < seqArr.Length - 1; i++)
        {
            if (seqArr[i] < seqArr[i + 1])
            {
                sequence++;
            }
            else
            {
                sequence = 1;
                start = 0;
                tempIncrArr = new string[seqArr.Length];
            }

            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                tempIncrArr[start] += seqArr[i] + ", ";
                maxIncrArr[start] = tempIncrArr[start];
                start++;
                maxIncrArr[start] += seqArr[i + 1];
            }
        }

        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(maxIncrArr[i]);
        }
        Console.WriteLine();
    }
}