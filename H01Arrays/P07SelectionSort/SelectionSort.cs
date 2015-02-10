//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int min;
        for (int i = 0; i < myArr.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (myArr[j] < myArr[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                myArr[i] = myArr[i] + myArr[min];
                myArr[min] = myArr[i] - myArr[min];
                myArr[i] = myArr[i] - myArr[min];
            }
        }

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i] + " ");
        }
    }
}