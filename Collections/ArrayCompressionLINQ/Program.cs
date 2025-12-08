namespace ArrayCompressionLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicatedNumbers = [1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5];

            var compressedNumbers = duplicatedNumbers
                .Where((number, index) => index == 0 || number != duplicatedNumbers[index - 1])
                .ToArray();

            Console.WriteLine($"Compressed array: {string.Join(", ", compressedNumbers)}");
        }
    }
}
