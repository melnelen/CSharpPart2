//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first array:");
        string inputStr1 = Console.ReadLine();
        char[] charArr1 = inputStr1.ToCharArray();
        Console.WriteLine("Please enter the second array:");
        string inputStr2 = Console.ReadLine();
        char[] charArr2 = inputStr1.ToCharArray();

        bool areTheSame = false;
        if (charArr1.Length == charArr2.Length)
        {
            for (int i = 0; i < charArr1.Length; i++)
            {
                if (charArr1[i] == charArr2[i])
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