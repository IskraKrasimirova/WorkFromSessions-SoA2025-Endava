namespace PositionOfElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //if (numbers.Length < 3)
            //{
            //    Console.WriteLine("There is no such element found. The result is -1");
            //    return;
            //}

            //int result = -1;

            //for (int i = 1; i < numbers.Length -1; i++)
            //{
            //    if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i + 1])
            //    {
            //        result = i;
            //        break;
            //    }
            //}

            int result = FindElementPosition(numbers);

            if (result != -1)
            {
                Console.WriteLine($"The position of the first occurrence of an element greater than its neighbours is {result}");
            }
            else 
            {
                Console.WriteLine($"There is no such element found. The result is {result}");
            }
            
        }

        private static int FindElementPosition(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                return -1;
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
//3. Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbours simultaneously. Otherwise, the result must be -1.
// Let the input is 1, 2, 3, 6, 0, 9, 4, 7, 5 -> 3
// 1, 2, 0, 6, 0, 9, 4, 7, 5 -> 1
// 1, 2, 2, 1, 0, 1, 4, 4, 5 -> -1
// 1, 2, 2, 1, 0, 1, 3, 4, 3 -> 7