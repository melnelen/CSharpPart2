//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main(string[] args)
    {
        string inputPath = @"..\..\..\txt\p03loremipsum.txt";
        string outputPath = @"..\..\..\txt\p03loremipsumnumbers.txt";

        StringBuilder result = new StringBuilder();
        using (StreamReader stream = new StreamReader(inputPath))
        {
            string line;
            int lineNumber = 1;
            while ((line = stream.ReadLine()) != null)
            {
                result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
                ++lineNumber;
            }

            if (result.Length == 0)
            {
                result.AppendLine("Sorry, no text!");
            }

            File.WriteAllLines(outputPath, result.ToString().Split('\n'));
            Console.WriteLine("Directory: " +
                Path.GetFullPath(inputPath)
                .Replace(Path.GetFileName(inputPath), String.Empty));

            Console.WriteLine("File without line numbers: " +
                Path.GetFileNameWithoutExtension(inputPath));

            Console.WriteLine("File with line numbers created: "
                + Path.GetFileNameWithoutExtension(outputPath));
        }
    }
}