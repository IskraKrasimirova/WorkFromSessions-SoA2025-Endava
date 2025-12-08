namespace RotateArrayFromSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
            // k = 2 -> 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

            Console.Write("Enter the step for rotation: ");
            int k = int.Parse(Console.ReadLine()!); // k = 2
            // k has to be less than array length

            int arrLength = numbers.Length;
            int[] rotatedArray = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                int rotationIndex = i + k; // 0+2, 1+2, 2+2, 3+2, 4+2, 5+2, 6+2, 7+2, 8+2, 9+2, 10+2, 11+2

                if (rotationIndex < arrLength)
                {
                    rotatedArray[rotationIndex] = numbers[i];
                }
                else
                {
                    rotatedArray[rotationIndex - arrLength] = numbers[i];
                }
            }

            Console.WriteLine($"Rotated array: {string.Join(", ", rotatedArray)}");
        }
    }
}
//2. “Rotate the Array”
// Rotate an array to the right by k positions.
// Example:
// [1, 2, 3, 4, 5], k = 2 → [4, 5, 1, 2, 3]