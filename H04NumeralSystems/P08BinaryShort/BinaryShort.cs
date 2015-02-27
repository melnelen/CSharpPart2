//Problem 8. Binary short

//Write a program that shows the binary representation of given 
//16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main(string[] args)
    {
        short num = 21;
        Console.WriteLine(ShortToBinary(num));
    }

    static string ShortToBinary(short num)
    {
        string result = "";
        int mask = 0;
        for (int i = 0; i < 16; i++)
        {
            mask = (num >> i) & 1;
            result = mask.ToString() + result;
        }
        return result;
    }
}
