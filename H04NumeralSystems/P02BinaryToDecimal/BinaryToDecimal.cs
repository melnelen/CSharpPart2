//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string binaryN = Console.ReadLine().Trim();
        long decimalN = 0;

        for (int bit = binaryN.Length - 1, pow = 0; bit >= 0; bit--, pow++)
        {
            decimalN += int.Parse(binaryN[bit].ToString()) * (int)myPowLoop(2, pow);
        }

        Console.WriteLine(decimalN);
    }

    //calculate the pow - much faster then Math.Pow()
    static BigInteger myPowLoop(int m, int n)
    {
        BigInteger pow = m;
        for (int i = 1; i < n; i++)
        {
            pow *= m;
        }
        return pow;
    }
}