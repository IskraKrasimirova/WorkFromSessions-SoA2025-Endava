namespace PrintNumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
    }
}
//Task — Print a Number Pyramid
// Description:
//Given a number N, use nested loops to print a number pyramid.
// Example:
// Input:
//4
// Output:
//1
//1 2
//1 2 3
//1 2 3 4
