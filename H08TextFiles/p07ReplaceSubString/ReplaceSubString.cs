//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string 
//start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubString
{
    static void Main(string[] args)
    {
        string inputPath = @"..\..\..\txt\p07start.txt";
        string outputPath = @"..\..\..\txt\p07finish.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string currentLine;
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = reader.ReadLine();
                    currentLine = Regex
                        .Replace(currentLine, "start", "finish", RegexOptions.IgnoreCase);

                    writer.WriteLine(currentLine);
                }

                Console.WriteLine("DIRECTORY: " +
                Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                Console.WriteLine("A file {0} has been created with the replaced text.",
                    Path.GetFileName(outputPath));
            }
        }
    }
}