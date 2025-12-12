namespace MoveAllZeroesToEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers[index] = numbers[i];
                    numbers[i] = 0;
                    index++;
                }
            }

            //// Another decision by swapping elements (tuple swap)
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] != 0)
            //    {
            //        //// Swap elements, classic
            //        //var temp = numbers[index];
            //        //numbers[index] = numbers[i];
            //        //numbers[i] = temp;
                    
            //        (numbers[index], numbers[i]) = (numbers[i], numbers[index]);
            //        index++;
            //    }
            //}

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//4.Task 8 — Move All Zeroes to the End (In-Place)
// Description:
//Given an array of N integers, move all the zeroes
//to the end of the array, without changing the order of the non-zero elements.
//The operation should be performed in place by swapping elements.
//Print the updated array.
// Example:
// Input:
//7
//0 1 0 3 12 0 5
// Output:
//1 3 12 5 0 0 0
