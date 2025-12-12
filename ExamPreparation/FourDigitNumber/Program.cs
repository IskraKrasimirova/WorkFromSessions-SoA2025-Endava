using System.Text;

namespace FourDigitNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 4-digits integer number: ");

            // Calculates the sum of the digits
            var number = Console.ReadLine()!;

            if (number[0] == '-')
            {
                number = number.Substring(1);
            }

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            Console.WriteLine($"The sum of digits is {sum}");

            // Prints on the console the number in reversed order

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

            Console.WriteLine();

            // Puts the last digit in the first position
            string changedNumber = string.Empty;
            changedNumber += number[3];
            changedNumber += number[1];
            changedNumber += number[2];
            changedNumber += number[0];

            Console.WriteLine(changedNumber);
            // Another decision
            var middleDigits = number.Substring(1, 2);
            Console.WriteLine(number[3] + middleDigits + number[0]);

            // Exchanges the second and the third digits
            var sb = new StringBuilder();
            sb.Append(number[0]);
            sb.Append(number[2]);
            sb.Append(number[1]);
            sb.Append(number[3]);

            Console.WriteLine(sb.ToString());
        }
    }
}
//1.Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
//-Calculates the sum of the digits (in our example 2+0+1+1 = 4). --> See SumOfDigits
//-Prints on the console the number in reversed order: dcba(in our example 1102).
//- Puts the last digit in the first position: dabc(in our example 1201).
//- Exchanges the second and the third digits: acbd(in our example 2101).
