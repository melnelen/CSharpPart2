//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all 
//the combinations of K distinct elements from the set [1..N].

//Example:
//N	K	result
//5	2	{1, 2} 
//      {1, 3} 
//      {1, 4} 
//      {1, 5} 
//      {2, 3} 
//      {2, 4} 
//      {2, 5} 
//      {3, 4} 
//      {3, 5} 
//      {4, 5}

using System;

class CombinationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArr = new int[k];

        Combinations(myArr, n, k, 0);
    }

    static void Combinations(int[] array, int n, int k, int index)
    {
        if (index == k)
        {
            bool distinct = true;
            int[] sortedArr = (int[])array.Clone();
            Array.Sort(sortedArr);
            for (int i = 1; i < sortedArr.Length; i++)
            {
                if (sortedArr[i] == sortedArr[i - 1] || array[i] < array[i - 1])
                {
                    distinct = false;
                }
            }
            
            if (distinct)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
            }
            return;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, n, k, index + 1);
            }
        }
    }
}