//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Linq;

class MergeSort
{
    static void Main(string[] args)
    {
        int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        SortMerge(myArr, 0, myArr.Length - 1);

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();
    }

    static public void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, eol, num, pos;

        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);

        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[pos++] = numbers[left++];
            else
                temp[pos++] = numbers[mid++];
        }

        while (left <= eol)
            temp[pos++] = numbers[left++];

        while (mid <= right)
            temp[pos++] = numbers[mid++];

        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void SortMerge(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);

            Merge(numbers, left, (mid + 1), right);
        }
    }
}