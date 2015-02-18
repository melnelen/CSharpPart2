//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:
//a)
//1	 5	 9	 13
//2	 6	 10	 14
//3	 7	 11	 15
//4	 8	 12	 16

//b)         
//1	 8	 9	 16
//2	 7	 10	 15
//3	 6	 11	 14
//4	 5	 12	 13

//c)         
//7	 11	 14	 16
//4	 8	 12	 15
//2	 5	 9	 13
//1	 3	 6	 10

//d)*                    
//1	 12	 11	 10
//2	 13	 16	 9
//3	 14	 15	 8
//4	 5	 6	 7

using System;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Choose a filling method: ");
        char myChoice = char.Parse(Console.ReadLine());
        int[,] myMatrix = new int[n, n];

        switch (myChoice)
        {
            case 'a': FillMatrixA(myMatrix, n); break;
            case 'b': FillMatrixB(myMatrix, n); break;
            case 'c': FillMatrixC(myMatrix, n); break;
            case 'd': FillMatrixD(myMatrix, n); break;
            default: Console.WriteLine("Invalid input!"); break;
        }

        PrintMatrix(myMatrix, n);
    }

    static void FillMatrixA(int[,] matrix, int n)
    {
        int i = 1;
        for (int col = 0; col < n; col++) //right
        {
            for (int row = 0; row < n; row++) //down
            {
                matrix[row, col] = i++;
            }
        }
    }

    static void FillMatrixB(int[,] matrix, int n)
    {
        int i = 1;
        for (int col = 0; col < n; col++) //right
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++) //down
                {
                    matrix[row, col] = i++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--) //up
                {
                    matrix[row, col] = i++;
                }
            }
        }
    }

    static void FillMatrixC(int[,] matrix, int n)
    {
        int i = 1;
        for (int row = n - 1; i <= n * n; row--) //up-right
        {
            if (row >= 0)
            {
                for (int col = 0, nextRow = row; col < n - row; col++, nextRow++) //right-down
                {
                    matrix[nextRow, col] = i++;
                }
            }
            else
            {
                for (int col = -row, nextRow = 0; col < n; col++, nextRow++) //second half right-down
                {
                    matrix[nextRow, col] = i++;
                }
            }
        }
    }

    static void FillMatrixD(int[,] matrix, int n)
    {
        int row = 0;
        int col = 0;
        string dir = "down";

        for (int i = 1; i <= n * n; i++)
        {
            if (dir == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                dir = "right";
                row--;
                col++;
            }
            if (dir == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                dir = "up";
                col--;
                row--;
            }
            if (dir == "up" && (row < 0 || matrix[row, col] != 0))
            {
                dir = "left";
                row++;
                col--;
            }
            if (dir == "left" && (col < 0 || matrix[row, col] != 0))
            {
                dir = "down";
                col++;
                row++;                
            }

            matrix[row, col] = i;

            if (dir == "down")
            {
                row++;
            }
            if (dir == "right")
            {
                col++;
            }
            if (dir == "up")
            {
                row--;
            }
            if (dir == "left")
            {
                col--;
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, -4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}