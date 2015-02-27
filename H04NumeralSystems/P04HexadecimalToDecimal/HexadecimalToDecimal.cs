//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        string hexN = Console.ReadLine();

        long decimalN = 0;
        int pos = hexN.Length - 1;
        long temp = 1;
        for (int i = 0; i < hexN.Length; i++)
        {
            char symbol = hexN[i];
            int digit;
            switch (symbol)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': digit = int.Parse(symbol.ToString()); break;
                case 'A': digit = 10; break;
                case 'a': digit = 10; break;
                case 'B': digit = 11; break;
                case 'b': digit = 11; break;
                case 'C': digit = 12; break;
                case 'c': digit = 12; break;
                case 'D': digit = 13; break;
                case 'd': digit = 13; break;
                case 'E': digit = 14; break;
                case 'e': digit = 14; break;
                case 'F': digit = 15; break;
                case 'f': digit = 15; break;
                default: digit = 0; break;
            }
            for (int j = 0; j < pos; j++)
            {
                temp = temp * 16;
            }
            decimalN += digit * temp;
            temp = 1;
            pos--;
        }
        Console.WriteLine(decimalN);
    }
}