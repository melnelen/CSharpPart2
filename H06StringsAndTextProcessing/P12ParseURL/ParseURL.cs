//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]:
////[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Example:
//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


class ParseURL
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\p12text.txt");
        //Console.SetIn(reader);

        string URL = Console.ReadLine();
        var match = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("[protocol] = {0}", match[1]);
        Console.WriteLine("[server] = {0}", match[2]);
        Console.WriteLine("[resource] = {0}", match[3]);
    }
}