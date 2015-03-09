//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;


class ReverseString
{
    static void Main(string[] args)
    {
        string myString = Console.ReadLine();

        StringBuilder strb = new StringBuilder();
        for (int i = myString.Length -1; i >= 0; i--)
        {
            strb.Append(myString[i]);
        }
        Console.WriteLine(strb);
    }
}