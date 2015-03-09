//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained 
//in a given text (perform case insensitive search).

//Example:
//The target sub-string is in
//The text is as follows: 
//We are living in an yellow submarine. We don't have anything else. 
//inside the submarine is very tight. So we are drinking all the day. 
//We will move out of it in 5 days.

//The result is: 9

using System;

class SubStringInText
{
    static void Main(string[] args)
    {
        string myStr = Console.ReadLine();
        string myWord = Console.ReadLine();
        Console.WriteLine(CountSubString(myStr, myWord));
    }

    public static int CountSubString(string str, string keyword)
    {
        int count = 0;
        for (int i = str.IndexOf(keyword); i != -1; i = str.IndexOf(keyword, ++i))
        {
            count++;
        }
        return count;
    }
}