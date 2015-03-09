//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace 
//only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

class ReplaceWholeWord
{
    static void Main(string[] args)
    {
        string inputPath = @"..\..\..\txt\p08start.txt";
        string outputPath = @"..\..\..\txt\p08finish.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            StringBuilder currentLine;
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = new StringBuilder(reader.ReadLine());
                    writer.WriteLine(Replace(currentLine));
                }

                Console.WriteLine("DIRECTORY: " +
                Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                Console.WriteLine("A file {0} has been created with the replaced text.",
                    Path.GetFileName(outputPath));
            }
        }
    }

    private static string Replace(StringBuilder currentLine)
    {
        string word = "start";
        string replacement = "finish";
        int startIndex = 0;
        string checkLine = currentLine.ToString();
        while (startIndex < currentLine.Length &&
            checkLine.IndexOf(word, StringComparison.OrdinalIgnoreCase) != -1)
        {
            startIndex = checkLine.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            bool startOfWord = (startIndex == 0 ||
                !Char.IsLetterOrDigit(currentLine[startIndex - 1]));

            bool endOfWord = ((startIndex + word.Length) == currentLine.Length ||
                !Char.IsLetterOrDigit(currentLine[startIndex + word.Length]));

            if (startOfWord && endOfWord)
            {
                currentLine = currentLine
                    .Replace(currentLine.ToString()
                    .Substring(startIndex, word.Length),
                    replacement, startIndex, word.Length);
            }

            startIndex += replacement.Length;
            checkLine = currentLine.ToString().Substring(startIndex);
            checkLine = checkLine.PadLeft(currentLine.Length, '*');
        }

        return currentLine.ToString();
    }
}