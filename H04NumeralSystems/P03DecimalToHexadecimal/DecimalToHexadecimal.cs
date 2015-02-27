//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        long decimalN = long.Parse(Console.ReadLine());

        long tempN = decimalN;
        string tempHexN = String.Empty;
        long rem = 0;
        while (tempN > 0)
        {
            rem = tempN % 16;
            tempN /= 16;
            switch (rem)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: tempHexN += rem; break;
                case 10: tempHexN += 'A'; break;
                case 11: tempHexN += 'B'; break;
                case 12: tempHexN += 'C'; break;
                case 13: tempHexN += 'D'; break;
                case 14: tempHexN += 'E'; break;
                case 15: tempHexN += 'F'; break;
                default: tempHexN += 0; break;
            }
        }

        string hexNumber = String.Empty;
        for (int i = tempHexN.Length - 1; i >= 0; i--)
        {
            hexNumber += tempHexN[i];
        }
        Console.WriteLine(hexNumber);
    }
}