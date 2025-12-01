namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { -3, 5, 987654321, -2, int.MinValue, 1, 4, int.MaxValue, 0, -123456789 };
            double[] doubleArray = { 3.1, 4.1, double.MaxValue, 5.9, 2.6, double.MinValue, 5.3 };
            string[] stringArray = { "gama", "banana", "apple", "cherry", "beta", "delta", "date", "alfa", string.Empty };

            SortArrayDesc(intArray);
            SortArrayDesc(doubleArray);
            SortArrayDesc(stringArray);
        }

        private static void SortArrayDesc<T>(T[] array) where T : IComparable<T>
        {
            Array.Sort<T>(array);
            Array.Reverse(array);
            Console.WriteLine("Sorted descending array: " + string.Join(", ", array));
        }
    }
}
