using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestTags
{
    [TestMethod]
    public void PassTestStars1()
    {
        string actual = StringLength.FillWithStars("Try this out now!");
        string expected = "Try this out now!***";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PassTestStars2()
    {
        string actual = StringLength.FillWithStars("Try this out now or never!");
        string expected = "The string is too long.";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestStars()
    {
        string actual = StringLength.FillWithStars
            ("Try this out now!");
        string expected = "Try this out now!";

        Assert.AreEqual(expected, actual);
    }
}