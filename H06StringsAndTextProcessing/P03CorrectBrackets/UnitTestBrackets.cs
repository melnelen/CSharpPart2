using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestBrackets
{
    [TestMethod]
    public void PassTestBrackets1()
    {
        bool actual = CorrectBrackets.CheckBrackets("((a+b)/5-d)");
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PassTestBrackets2()
    {
        bool actual = CorrectBrackets.CheckBrackets(")(a+b))");
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestBrackets1()
    {
        bool actual = CorrectBrackets.CheckBrackets("((a+b)/5-d)");
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestBrackets2()
    {
        bool actual = CorrectBrackets.CheckBrackets(")(a+b))");
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }
}
