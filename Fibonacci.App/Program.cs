namespace Fibonacci.App;
public static class Program{
    static void Main()
    {
        for(int i = 0; i < 10; ++i)
        {
            Console.WriteLine(Fibonacci.Lib.Class1.GetFibonacci(i));
        }
    }
}
