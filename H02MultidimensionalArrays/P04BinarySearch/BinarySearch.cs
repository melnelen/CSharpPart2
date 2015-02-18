//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        int maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArr);

        int index = Array.BinarySearch(myArr, k);

        if (index > 0)
        {
            Console.WriteLine(myArr[index]);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (myArr[i] < k)
                {
                    maxNumber = myArr[i];
                }
            }

            if (maxNumber != int.MinValue)
            {
                Console.WriteLine(myArr[~index - 1]);
            }
            else
            {
                Console.WriteLine("there is no match");
            }
            
        }
    }
}