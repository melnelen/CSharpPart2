//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first array splitting it's elements with a space:");
        int[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Please enter the second array splitting it's elements with a space:");
        int[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        bool areTheSame = false;
        if (firstArr.Length == secondArr.Length)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    areTheSame = true;
                }
            }
            if (areTheSame)
            {
                Console.WriteLine("The arrays are the same!");
            }
            else
            {
                Console.WriteLine("The arrays are different!");
            }
        }
        else
        {
            Console.WriteLine("The arrays are not comparable!");
        }
    }
}