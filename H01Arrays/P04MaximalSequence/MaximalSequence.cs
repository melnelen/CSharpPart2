//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

using System;
using System.Linq;
using System.IO;

class MaximalSequence
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p04text.txt");
        //Console.SetIn(reader);

        char[] seqArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x)).ToArray();

        int sequence = 1;
        int maxSequence = 1;
        char element = seqArr[0];

        for (int i = 0; i < seqArr.Length - 1; i++)
        {
            if (seqArr[i] == seqArr[i + 1])
            {
                sequence++;
            }
            else
            {
                sequence = 1;
            }

            if (sequence > maxSequence)
            {
                element = seqArr[i];
                maxSequence = sequence;
            }
        }
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(element + ", ");
        }
        Console.WriteLine();
    }
}