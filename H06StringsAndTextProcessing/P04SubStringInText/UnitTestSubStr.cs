using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestSubStr
{
    [TestMethod]
    public void PasslTestSubStr()
    {
        int actual = SubStringInText.CountSubString
            ("We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", 
            "in");
        int expected = 9;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestSubStr()
    {
        int actual = SubStringInText.CountSubString
            ("We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
            "in");
        int expected = 22;

        Assert.AreEqual(expected, actual);
    }
}
