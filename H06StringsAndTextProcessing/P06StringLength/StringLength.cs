//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
    static void Main(string[] args)
    {
        string myStr = Console.ReadLine();
        Console.WriteLine(FillWithStars(myStr));
    }

    public static string FillWithStars(string str)
    {
        if (str.Length > 20)
        {
            return "The string is too long.";
        }
        else
        {
            return  str.PadRight(20, '\u002A');
        }
    }
}