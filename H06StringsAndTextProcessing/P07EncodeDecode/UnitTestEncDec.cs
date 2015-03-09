using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestEncDec
{
    [TestMethod]
    public void PassTestEncDec1()
    {
        string actual = EncodeDecode.EncriptDecript
            ("Test", "ab");
        string expected = "\u0035\u0007\u0012\u0016";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PassTestEncDec2()
    {
        string actual = EncodeDecode.EncriptDecript
            ("\u0035\u0007\u0012\u0016", "ab");
        string expected = "Test";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTestEncDec()
    {
        string actual = EncodeDecode.EncriptDecript
            ("Test", "ab");
        string expected = "Test";

        Assert.AreEqual(expected, actual);
    }
}