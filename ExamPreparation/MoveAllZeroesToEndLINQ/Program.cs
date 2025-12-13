namespace MoveAllZeroesToEndLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ decision is not "in-place"
            int[] numbers = Console.ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = numbers
                .Where(x => x != 0)
                .Concat(numbers.Where(x => x == 0))
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
