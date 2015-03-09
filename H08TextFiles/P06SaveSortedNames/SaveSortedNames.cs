//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file.

//Example:

//input.txt
//Ivan 
//Peter 
//Maria 
//George	

//output.txt
//George 
//Ivan 
//Maria 
//Peter

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SaveSortedNames
{
    static void Main(string[] args)
    {
        string inputPath = @"..\..\..\txt\p06names.txt";
        string outputPath = @"..\..\..\txt\p06sorted.txt";

        List<string> names = new List<string>();

        using (StreamReader stream = new StreamReader(inputPath))
        {
            names = stream.ReadToEnd()
                .Split('\n')
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            File.WriteAllLines(outputPath, names);

            Console.WriteLine("DIRECTORY: " +
                Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

            Console.WriteLine("A file {0} has been created with the sorted names.",
                Path.GetFileName(outputPath));
        }
    }
}