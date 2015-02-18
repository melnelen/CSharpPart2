//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array 
//by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main(string[] args)
    {
        Console.Write("number of strings: ");
        int n = int.Parse(Console.ReadLine());
        string[] myArr = new string[n];

        //fill array
        for (int i = 0; i < n; i++)
        {
            myArr[i] = Console.ReadLine();
        }

        //save result from sorting
        string[] sortedArr = OrderByLenght(myArr);

        //print array
        foreach (string item in sortedArr)
        {
            Console.WriteLine(item);
        }
    }

    //sort array by lenght
    static string[] OrderByLenght(string[] strArr)
    {
        string[] result = strArr.OrderBy(x => x.Length).ToArray();

        return result;
    }
}