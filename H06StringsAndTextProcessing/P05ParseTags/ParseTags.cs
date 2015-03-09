//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions 
//surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. 
//We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main(string[] args)
    {
        string myStr = Console.ReadLine();
        Console.WriteLine(ChangeToUpper(myStr));
    }

    public static string ChangeToUpper(string str)
    {
        Regex upcase = new Regex("<upcase>(.*?)</upcase>");

        MatchCollection matches = upcase.Matches(str);
        for (var i = 0; i < matches.Count; i++)
        {
            str = str.Replace(matches[i].ToString(), matches[i].Groups[1].ToString().ToUpper());
        }
        return str;
    }
}