using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestBadWords
{
    string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
    string[] words = { "PHP", "CLR", "Microsoft" };
    string result = "********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.";

    [TestMethod]
    public void PassTestBadWord()
    {
        string actual = ForbiddenWords.HideForbidenWords(text, words);
        string expected = result;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestBadWord()
    {
        string actual = ForbiddenWords.HideForbidenWords(text, words);
        string expected = text;

        Assert.AreEqual(expected, actual);
    }
}