
namespace RotateArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rotate the array in place
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
            // k = 2 -> 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

            Console.Write("Enter the step for rotation: ");
            int k = int.Parse(Console.ReadLine()!);

            int n = numbers.Length;
            k = k % n; // In case k is greater than n

            // Reverse the array
            Reverse(numbers, 0, n - 1);
            // Reverse first k elements
            Reverse(numbers, 0, k - 1);
            // Reverse the remaining n-k elements
            Reverse(numbers, k, n - 1);

            Console.WriteLine($"Rotated array: {string.Join(", ", numbers)}");
        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                (arr[end], arr[start]) = (arr[start], arr[end]);
                start++;
                end--;
            }
        }
    }
}
