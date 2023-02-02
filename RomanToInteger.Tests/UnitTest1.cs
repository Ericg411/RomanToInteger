namespace RomanToInteger.Tests;

[TestClass]
public class RtoI
{
    private readonly RomanToInteger _romToInt;

    public RtoI()
    {
        _romToInt = new RomanToInteger();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int result = _romToInt.RomanToInt("III");

        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int result = _romToInt.RomanToInt("LVIII");

        Assert.AreEqual(58, result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int result = _romToInt.RomanToInt("MCMXCIV");

        Assert.AreEqual(1994, result);
    }
}