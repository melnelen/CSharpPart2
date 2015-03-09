using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestMatchSen
{
    string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    string[] sentences = { "We are living in a yellow submarine", "We don't have anything else", "Inside the submarine is very tight", "So we are drinking all the day", "We will move out of it in 5 days" };
    string[] nosentences = { "We are living in a yellow submarine", "We don't have anything else" };
    string sentence = "We are living in a yellow submarine";
    string key = "In";
    string result = "We are living in a yellow submarine. We will move out of it in 5 days. ";

    [TestMethod]
    public void PassTestMatch1()
    {
        string[] actual = ExtractSentences.GetSentences(text);
        string[] expected = sentences;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PassTestMatch2()
    {
        bool actual = ExtractSentences.ExactMatch(sentence, key);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PassTestMatch3()
    {
        string actual = ExtractSentences.FindMatches
            (sentences, key);
        string expected = result;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestMatch1()
    {
        string[] actual = ExtractSentences.GetSentences(text);
        string[] expected = nosentences;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestMatch2()
    {
        bool actual = ExtractSentences.ExactMatch(sentence, key);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestMatch3()
    {
        string actual = ExtractSentences.FindMatches
            (sentences, key);
        string expected = text;

        Assert.AreEqual(expected, actual);
    }
}