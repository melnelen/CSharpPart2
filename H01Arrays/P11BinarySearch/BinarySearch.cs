//Problem 11. Binary search

//Write a program that finds the index of given element in 
//a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        int myKey = int.Parse(Console.ReadLine());

        Array.Sort(myArr);
        int min = 0;
        int max = myArr.Length - 1;
        int mid = min + ((max - min) / 2);
        bool found = false;

        while (min <= max)
        {
            mid = min + ((max - min) / 2);
            if (myArr[mid] < myKey)
            {
                min = mid + 1;
                continue;
            }
            else if (myArr[mid] > myKey)
            {
                max = mid - 1;
                continue;
            }
            else if (myArr[mid] == myKey)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine(mid);
        }
        else
        {
            Console.WriteLine("Value not found!");
        }
    }
}