using System.Dynamic;

namespace Fibonacci.Lib;

public class Class1
{
    public static int GetFibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        int prev = 0;
        int curr = 1;
        int temp = 0;
        for(int i = 1; i < n; ++i)
        {
            temp = curr;
            curr = curr + prev;
            prev = temp;
        }
        return curr;
    }
}
