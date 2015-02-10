//Problem 16.* Subset with sum S

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:

//input array	            S	    result
//2, 1, 2, 4, 3, 5, 2, 6	14	    yes

using System;
using System.Linq;
using System.IO;

class SubsetWithSumS
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p16text.txt");
        //Console.SetIn(reader);

        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        int mySum = int.Parse(Console.ReadLine());

        int sum = 0;
        bool equal = false;
        int combinations = (int)Math.Pow(2, myArr.Length);

        for (int i = 0; i < combinations - 1; i++)
        {
            for (int j = 0; j < myArr.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sum += myArr[j];
                }

                if (sum == mySum)
                {
                    equal = true;
                }
            }
            sum = 0;
        }

        if (equal)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}