//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Example:

//matrix	
//ha   fifi ho	hi
//fo   ha	hi	xx
//xxx  ho	ha	xx

//result		
//ha, ha, ha

//matrix	
//s	 qq	s
//pp pp	s
//pp qq	s

//result
//s, s, s

using System;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] myMatrix = new string[rows, cols];

        FillMatrix(myMatrix, rows, cols);

        int count = 1;
        int maxCount = 1;
        string maxValue = "";

        //Searching horizontally
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if ((myMatrix[row, col] == myMatrix[row, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = myMatrix[row, col].ToString();
                }
            }
            count = 1;
        }

        //Searching vertically
        for (int col = 0; col < cols; col++)                 
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if ((myMatrix[row, col] == myMatrix[row + 1, col]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = myMatrix[row, col].ToString();
                }
            }
            count = 1;
        }

        //Searching diagonally from left to right
        for (int row = 0, col = 0; row < rows - 1 && col < rows - 1; row++, col++)
        {
            if ((myMatrix[row, col] == myMatrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxValue = myMatrix[row, col].ToString();
            }
        }
        count = 1;

        //Searching diagonally from right to left
        for (int row = 0, col = 0; row < rows - 1 && col > 0; row++, col--)
        {
            if ((myMatrix[row, col] == myMatrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxValue = myMatrix[row, col].ToString();
            }
        }

        string[] result = new string[maxCount];
        if (maxCount > 1)
        {
            for (int i = 0; i < maxCount; i++)
            {
                result[i] = maxValue;
            }
                Console.WriteLine(String.Join(", ", result));
        }
        else
        {
            Console.WriteLine("No repeating strings!");
        }


    }

    //fill the matrix
    static void FillMatrix(string[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
    }
}