//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("array of {0} elements:", n);
        int[] myArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        int sum = 0;
        for (int i = n - 1; i >= n - k; i--)
        {
            sum += myArr[i];
        }
        Console.WriteLine(sum);
    }
}