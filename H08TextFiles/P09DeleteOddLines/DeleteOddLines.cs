//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        string path = @"..\..\..\txt\p09loremipsum.txt";

        StringBuilder result = new StringBuilder();
        result.AppendLine(Environment.NewLine + "RESULT");
        using (StreamReader reader = File.OpenText(path))
        {
            string currentLine;
            int line = 0;

            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                ++line;
                if (line % 2 == 0)
                {
                    result.AppendLine(currentLine);
                }
            }

        }

        using (StreamWriter writer = File.AppendText(path))
        {
            writer.WriteLine(result);
        }

        Console.WriteLine("DIRECTORY: " +
            Path.GetFullPath(path).Replace(Path.GetFileName(path), String.Empty));

        Console.WriteLine("The file {0} has been modified.",
            Path.GetFileName(path));
    }
}