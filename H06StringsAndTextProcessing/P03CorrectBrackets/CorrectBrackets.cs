//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections;

class CorrectBrackets
{
    static void Main(string[] args)
    {
        string myExpression = Console.ReadLine();
        Console.WriteLine(CheckBrackets(myExpression));
    }

    public static bool CheckBrackets(string expression)
    {
        Stack brackets = new Stack();
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets.Push("(");
            }
            else if (expression[i] == ')')
            {
                try
                {
                    brackets.Pop();
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
            }
        }
        if (brackets.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}