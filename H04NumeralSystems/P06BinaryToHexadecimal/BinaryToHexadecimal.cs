//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        string bin = Console.ReadLine();
        string hexnum = ConvertBinaryToHex(bin);
        Console.WriteLine(hexnum);
    }

    static int Pow(int numBase, int deg)
    {
        int res = 1;
        for (int i = 0; i < deg; i++)
        {
            res *= numBase;
        }
        return res;
    }

    static string ConvertBinaryToHex(string bin)
    {
        //fill with zeros if missing
        if (bin.Length % 4 != 0)
        {
            return ConvertBinaryToHex(new String('0', 4 - bin.Length % 4) + bin);
        }

        int res = 0;
        int hexDegree = 0;
        for (int i = bin.Length - 1; i >= 0; i -= 4)
        {
            //get portion of 4 bits
            int part = 0;
            int coef = 8;
            //convert it to decimal
            for (int j = 3; j >= 0; j--)
            {
                part += coef * (bin[i - j] - '0');
                coef /= 2;
            }
            //get hex rappresentation and add it to the result
            res += part * Pow(16, hexDegree);
            hexDegree++;
        }
        return res.ToString();
    }
}