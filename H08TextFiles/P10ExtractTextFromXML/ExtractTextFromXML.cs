//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
//<interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    const char SPACE = ' ';

    static void Main(string[] args)
    {
        string inputPath = @"..\..\..\txt\p10pesho.xml";
        string outputPath = @"..\..\..\txt\p10peshoout.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string xml = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.Write(GetResult(xml));

                Console.WriteLine("DIRECTORY: " +
                    Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                Console.WriteLine("A file {0} with {1} text content has been created.",
                    Path.GetFileName(outputPath), Path.GetFileName(inputPath));
            }
        }
    }

    private static string GetResult(string xml)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder current = new StringBuilder();
        bool insideTag = false;

        foreach (var letter in xml)
        {
            if (insideTag)
            {
                if (letter == '>')
                {
                    insideTag = false;
                }
                continue;
            }
            else
            {
                if (letter == '<')
                {
                    if (current.Length > 0)
                    {
                        result.AppendLine(current.ToString());
                        current.Clear();
                    }
                    insideTag = true;
                }
                else
                {
                    current.Append(letter);
                }
                continue;
            }
        }
        return result.ToString();
    }
}