namespace RotateArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
            // k = 2 -> 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

            Console.Write("Enter the step for rotation: ");
            int k = int.Parse(Console.ReadLine()!); 

            int n = numbers.Length;
            k = k % n; // In case k is greater than n

            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + k) % n;
                rotated[newIndex] = numbers[i];
            }

            Console.WriteLine($"Rotated array: {string.Join(", ", rotated)}");
        }
    }
}
