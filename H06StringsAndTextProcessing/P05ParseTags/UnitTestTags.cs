using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestTags
{
    [TestMethod]
    public void PassTestTags()
    {
        string actual = ParseTags.ChangeToUpper
            ("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");
        string expected = "We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestTags()
    {
        string actual = ParseTags.ChangeToUpper
            ("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");
        string expected = "We are living in a yellow submarine. We don't have anything else.";

        Assert.AreEqual(expected, actual);
    }
}
