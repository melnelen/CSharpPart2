//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] myMatrix = new int[rows, cols];

        FillMatrix(myMatrix, rows, cols);

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < myMatrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1) - 2; col++)
            {
                int sum = myMatrix[row, col] + myMatrix[row, col + 1] + myMatrix[row, col + 2] + 
                    myMatrix[row + 1, col] + myMatrix[row + 1, col + 1] + myMatrix[row + 1, col + 2] + 
                    myMatrix[row + 2, col] + myMatrix[row + 2, col + 1] + myMatrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        PrintResult(bestSum, myMatrix, bestRow, bestCol);
    }

    //fill the matrix
    static void FillMatrix(int[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    //print the result
    static void PrintResult(int bSum, int[,] matrix, int bRow, int bCol)
    {
        Console.WriteLine("maximal sum: {0}", bSum);
        Console.WriteLine("best platform:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0, -4}", matrix[bRow, bCol++]);
            }
            Console.WriteLine();
            bRow++;
            bCol -= 3;
        }
    }
}