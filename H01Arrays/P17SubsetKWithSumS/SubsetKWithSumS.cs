//Problem 17.* Subset K with sum S

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetKWithSumS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int N = int.Parse(Console.ReadLine());
            int[] myArr = new int[N];
            Console.WriteLine("K: ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("S: ");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("array: ");
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            bool equal = false;
            int combinations = (int)Math.Pow(2, myArr.Length);
            
            for (int i = 0; i < combinations - 1; i++)
            {
                int sum = 0;
                int counter = 0;
                for (int j = 0; j < myArr.Length && !equal; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = (nAndMask >> j);
                    if (bit == 1)
                    {
                        sum += myArr[j];
                        counter++;
                    }
                }
                if (counter == K && sum == S)
                {
                    equal = true;
                    count += counter;
                }
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