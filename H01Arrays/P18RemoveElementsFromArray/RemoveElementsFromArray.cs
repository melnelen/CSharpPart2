﻿//Problem 18.* Remove elements from array

//Write a program that reads an array of integers and removes from it a minimal number of elements 
//in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.
//Example:

//input	                        result
//6, 1, 4, 3, 0, 3, 6, 4, 5	    1, 3, 3, 4, 5

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

class RemoveElementsFromArray
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p18text.txt");
        //Console.SetIn(reader);

        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        //Not resolved yet!
        //Something somewhere went trribly wrong!
        //I am so lost :(
    }

    
}