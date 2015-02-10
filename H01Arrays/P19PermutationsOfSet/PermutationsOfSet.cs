//Problem 19.* Permutations of set

//Write a program that reads a number N and generates and prints all 
//the permutations of the numbers [1 … N].

//Example:
//N	    result
//3	    {1, 2, 3} 
//      {1, 3, 2} 
//      {2, 1, 3} 
//      {2, 3, 1} 
//      {3, 1, 2} 
//      {3, 2, 1}

using System;

class PermutationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArr[i] = i + 1;
        }

        Permutation(n, myArr);

    }

    static void Permutation(int n, int[] array)
    {
        if (n == 0)
        {
            Console.WriteLine(string.Join(", ", array));
            return;
        }
        for (int i = 0; i < n - 1; i++)
        {
            int temp = array[i];
            array[i] = array[n - 1];
            array[n - 1] = temp;
            Permutation(n - 1, array);
            temp = array[i];
            array[i] = array[n - 1];
            array[n - 1] = temp;
        }
        Permutation(n - 1, array);
    }
}