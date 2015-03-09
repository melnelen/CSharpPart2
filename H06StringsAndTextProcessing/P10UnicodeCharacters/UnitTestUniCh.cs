using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestBadWords
{
    [TestMethod]
    public void PassTestUniCh()
    {
        string actual = UnicodeCharacters.ConvertToUnicode("Hi!");
        string expected = "\u0048\u0069\u0021";

        Assert.AreEqual(expected, actual);
    }
}