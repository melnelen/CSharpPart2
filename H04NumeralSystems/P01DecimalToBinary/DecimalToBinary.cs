//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long decimalN = long.Parse(Console.ReadLine());
        string binaryN = "";

        do
        {
            if (decimalN % 2 == 0)
            {
                binaryN = "0" + binaryN;
            }
            else
            {
                binaryN = "1" + binaryN;
            }
            decimalN = decimalN / 2;
        } while (decimalN > 0);

        Console.WriteLine(binaryN);
    }
}