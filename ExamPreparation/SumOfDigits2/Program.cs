namespace SumOfDigits2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine()!);

            number = Math.Abs(number);
            int sum = 0;
            //int numberLength = number.ToString().Length;

            //for (int i = 0; i < numberLength; i++)
            //{
            //    int numberToAdd = number % 10; // take the last digit
            //    sum += numberToAdd;
            //    number = number / 10; // remove the last digit
            //}

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"The sum of digits is {sum}");
        }
    }
}
