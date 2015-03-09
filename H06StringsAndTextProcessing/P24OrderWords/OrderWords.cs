//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces 
//and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine();
        Array.Sort(input);

        foreach (var word in input)
        {
            Console.WriteLine(word);
        }
    }
}