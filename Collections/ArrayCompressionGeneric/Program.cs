namespace ArrayCompressionGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example with int array
            int[] arr1 = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5 };
            int[] compressed1 = CompressArray(arr1);
            Console.WriteLine("Int compressed: " + string.Join(", ", compressed1));

            // Example with string array
            string[] arr2 = { "ab", "ab", "bc", "bc", "c", "ab", "ab" };
            string[] compressed2 = CompressArray(arr2);
            Console.WriteLine("String compressed: " + string.Join(", ", compressed2));

            // Example with char array
            char[] arr3 = { 'x', 'x', 'y', 'y', 'z', 'z', 'z', 'x' };
            char[] compressed3 = CompressArray(arr3);
            Console.WriteLine("Char compressed: " + string.Join(", ", compressed3));
        }

        static T[] CompressArray<T>(T[] arr)
        {
            if (arr.Length == 0) return new T[0];

            T[] compressed = new T[arr.Length];
            int index = 0;

            compressed[index++] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (!arr[i]!.Equals(arr[i - 1]))
                {
                    compressed[index++] = arr[i];
                }
            }

            compressed = compressed[..index];

            return compressed;

            //T[] result = new T[index];
            //for (int i = 0; i < index; i++)
            //{
            //    result[i] = compressed[i];
            //}

            //return result;
        }
    }
}
