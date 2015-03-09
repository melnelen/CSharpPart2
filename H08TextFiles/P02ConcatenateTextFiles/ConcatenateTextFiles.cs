//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        string firstPath = @"..\..\..\txt\p01loremipsum.txt";
        string secondPath = @"..\..\..\txt\p02loremipsum.txt";
        string concatenatedPath = @"..\..\..\txt\p02loremipsumconcat.txt";

        string firstString = File.ReadAllText(firstPath);
        string secondString = File.ReadAllText(secondPath);

        File.WriteAllText(concatenatedPath, firstString + secondString);

        Console.WriteLine("A {0} file named {1} has been created.", Path.GetExtension(concatenatedPath), Path.GetFileNameWithoutExtension(concatenatedPath));
        Console.WriteLine("You can find it at " + Path.GetFullPath(concatenatedPath));
    }
}