namespace ArrayCompressionWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicatedNumbers = [1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5];
            var initialLength = duplicatedNumbers.Length;

            int[] compressed = new int[initialLength];
            int index = 0;
            compressed[index++] = duplicatedNumbers[0];

            for (int i = 1; i < initialLength; i++)
            {
                if (duplicatedNumbers[i] != duplicatedNumbers[i - 1])
                {
                    compressed[index++] = duplicatedNumbers[i];
                }
            }

            // Resize the array to the actual number of non-zero elements at the start, removing the unused portion
            compressed = compressed[..index];

            //// Alternatively, we can use Array.Resize
            //int[] before = compressed;
            //Array.Resize(ref compressed, index);
            //Console.WriteLine(Object.ReferenceEquals(before, compressed)); // False

            //// Alternatively, we can use LINQ's Take method
            //compressed = compressed.Take(index).ToArray();

            //// Alternatively, we can use Array.Copy
            //int[] result = new int[index];
            //Array.Copy(compressed, 0, result, 0, index); // or Array.Copy(compressed, result, index);
            //compressed = result;

            Console.WriteLine($"Compressed array: {string.Join(", ", compressed)}");
        }
    }
}
