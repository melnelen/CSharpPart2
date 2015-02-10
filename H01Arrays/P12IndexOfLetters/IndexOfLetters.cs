//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Linq;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        char[] wordArr = word.ToCharArray();

        char[] letterArr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        for (int i = 0; i < wordArr.Length; i++)
        {
            for (int j = 0; j < letterArr.Length; j++)
            {
                if (letterArr[j] == wordArr[i])
                {
                    Console.WriteLine(@"""{0}"" has an index: {1}", wordArr[i], j);
                }
            }
        }
    }
}