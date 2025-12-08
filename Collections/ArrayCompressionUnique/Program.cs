namespace ArrayCompressionUnique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicatedNumbers = [1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5];

            // Using LINQ's Distinct method to remove all duplicates, not just consecutive ones
            var compressedNumbers = duplicatedNumbers.Distinct().ToArray();
            Console.WriteLine($"Compressed array: {string.Join(", ", compressedNumbers)}");

            // Using HashSet to store unique numbers
            HashSet<int> uniqueNumbers = new HashSet<int>(duplicatedNumbers);
            Console.WriteLine($"Unique numbers using HashSet: {string.Join(", ", uniqueNumbers)}");

        }
    }
}
