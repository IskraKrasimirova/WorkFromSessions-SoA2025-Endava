namespace ArrayCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicatedNumbers = [1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5];

            var initialLength = duplicatedNumbers.Length;
            List<int> compressedNumbers = new List<int>(initialLength);

            compressedNumbers.Add(duplicatedNumbers[0]);

            for (int i = 1; i < initialLength; i++)
            {
                if (duplicatedNumbers[i] != duplicatedNumbers[i-1])
                {
                    compressedNumbers.Add(duplicatedNumbers[i]);
                }
            }

            Console.WriteLine($"Compressed array: {string.Join(", ", compressedNumbers)}");
        }
    }
}
// 3. “Array Compression”
// Given an array, remove consecutive duplicates:
// [1, 1, 2, 2, 2, 3, 1, 1] → [1, 2, 3, 1]