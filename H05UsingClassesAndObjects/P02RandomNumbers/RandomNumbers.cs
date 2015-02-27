//Problem 2. Random numbers

//Write a program that generates and prints to the console 
//10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static Random myRand = new Random();

    static void Main(string[] args)
    {
        double min = 100;
        double max = 200;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0:F2} ", myRand.NextDouble() * (max - min) + min);
        }
        Console.WriteLine();
    }
}