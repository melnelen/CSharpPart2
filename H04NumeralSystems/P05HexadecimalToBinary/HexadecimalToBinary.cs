//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{

    static char[] hex = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                  'A', 'B', 'C', 'D', 'E', 'F'};

    static void Main()
    {
        string bin = ConvertHexToBinary("15");
        Console.WriteLine(bin);
    }

    static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static int GetIndexOfHex(char c)
    {
        int res = -1;
        for (int i = 0; i < 16; i++)
        {
            if (hex[i] == c)
            {
                res = i;
                break;
            }
        }
        return res;
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

    static string ConvertHexToBinary(string str)
    {
        string res = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            int temp = GetIndexOfHex(str[i]);
            for (int j = 0; j < 4; j++)
            {
                res += temp % 2;
                temp /= 2;
            }

        }
        return ReverseString(res);
    }
}