using System;
using System.Collections.Generic;
using System.Linq;

class LargestAreaInMatrix
{
    static int[,] matrix = {{ 1, 3, 2, 2, 2, 4},
                            { 3, 3, 3, 2, 4, 4},
                            { 4, 3, 1, 2, 3, 3},
                            { 4, 3, 1, 3, 3, 1},
                            { 4, 3, 3, 3, 1, 1}};
    static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    static void Main(string[] args)
    {
        int result = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DFS(row, col, matrix[row, col]));
            }
        }

        Console.WriteLine(result);
    }

    static int DFS(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }
        if (visited[row, col])
        {
            return 0;
        }
        if (matrix[row, col] != value)
        {
            return 0;
        }
        visited[row, col] = true;

        return DFS(row, col + 1, value) + DFS(row, col - 1, value) +
            DFS(row + 1, col, value) + DFS(row - 1, col, value) + 1;
    }
}