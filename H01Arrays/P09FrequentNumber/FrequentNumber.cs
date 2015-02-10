//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

//Example:
//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

using System;
using System.Linq;
using System.IO;

class FrequentNumber
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p09text.txt");
        //Console.SetIn(reader);

        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int maxElement = myArr[0];
        int maxFrequency = 1;

        for (int i = 0; i < myArr.Length; i++)
        {
            int element = myArr[i];
            int frequency = 1;

            for (int j = 1; j < myArr.Length; j++)
            {
                if (element == myArr[j])
                {
                    frequency++;
                }
            }

            if (frequency > maxFrequency)
            {
                maxElement = element;
                maxFrequency = frequency;
            }
        }
        Console.WriteLine("{0} ({1} times)", maxElement, maxFrequency);
    }
}