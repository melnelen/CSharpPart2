﻿//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<char, int> letters = new Dictionary<char, int>();
        CountLetters(input, letters);
        foreach (var letter in letters)
        {
            Console.WriteLine("[{0}]    {1}", letter.Key, letter.Value);
        }
    }

    static void CountLetters(string input, Dictionary<char, int> letters)
    {
        foreach (var character in input)
        {
            if (!letters.ContainsKey(character))
            {
                letters.Add(character, 1);
            }
            else
            {
                letters[character] += 1;
            }
        }
    }
}