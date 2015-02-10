//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates 
//all the variations of K elements from the set [1..N].

//Example:
//N	K	result
//3	2	{1, 1} 
//      {1, 2} 
//      {1, 3} 
//      {2, 1} 
//      {2, 2} 
//      {2, 3} 
//      {3, 1} 
//      {3, 2} 
//      {3, 3}

using System;

class VariationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArr = new int[k];

        Variations(myArr, n, k, 0);
    }

    static void Variations(int[] array, int n, int k, int index)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(", ", array));
            return;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variations(array, n, k, index + 1);
            }
        }
    }
}