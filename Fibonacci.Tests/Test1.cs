namespace Fibonacci.Tests;

[TestClass]
public sealed class FibonacciLibTest
{
    [TestMethod]
    public void GetFibonacci1()
    {
        int i = 0;
        int result = Fibonacci.Lib.Class1.GetFibonacci(i);
        Assert.AreEqual(0, result);
    }
    [TestMethod]
        public void GetFibonacci2()
    {
        int i = 1;
        int result = Fibonacci.Lib.Class1.GetFibonacci(i);
        Assert.AreEqual(1, result);
    }
    [TestMethod]
        public void GetFibonacci3()
    {
        int i = 2;
        int result = Fibonacci.Lib.Class1.GetFibonacci(i);
        Assert.AreEqual(1, result);
    }
}
