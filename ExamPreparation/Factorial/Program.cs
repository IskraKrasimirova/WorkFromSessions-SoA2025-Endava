using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer number: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second integer number bigger than first: ");
            int n = int.Parse(Console.ReadLine()!);

            k = Math.Abs(k);
            n = Math.Abs(n);

            BigInteger result = 1;

            for (int i = k+1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine($"{n}!/{k}! = {result}");
        }
    }
}
//2.Write a program that calculates N!/K! for given N and K (1<K<N).
// n! = 1*2*...*k*(k+1)*...*n = k!*(k+1)*...*n