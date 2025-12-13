namespace MoveAllZeroesToEndWithList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //// Decision with Lists, not "in-place"
            //List<int> nonZeroes = new List<int>();
            //List<int> zeroes = new List<int>();

            //foreach (int number in numbers) 
            //{
            //    if (number == 0)
            //    {
            //        zeroes.Add(number);
            //    }
            //    else
            //    {
            //        nonZeroes.Add(number);
            //    }
            //}

            //var result = nonZeroes.Concat(zeroes).ToArray();

            // Decision with array, not "in-place"
            int[] result = new int[numbers.Length];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    result[index++] = numbers[i];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
