namespace FourDigitNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 4-digits integer number: ");

            var number = Console.ReadLine()!;

            int a = int.Parse(number[0].ToString());
            int b = int.Parse(number[1].ToString());
            int c = int.Parse(number[2].ToString());
            int d = int.Parse(number[3].ToString());

            int sum = a + b + c + d;
            Console.WriteLine($"The sum of digits is {sum}");

            string reversed = $"{d}{c}{b}{a}";
            Console.WriteLine($"Reversed: {reversed}");

            string lastFirst = $"{d}{a}{b}{c}";
            Console.WriteLine($"Last digit first: {lastFirst}");

            string swapSecondThird = $"{a}{c}{b}{d}";
            Console.WriteLine($"Swap 2nd and 3rd digit: {swapSecondThird}");
        }
    }
}
