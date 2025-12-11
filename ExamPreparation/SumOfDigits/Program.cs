namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        { 
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

            Console.WriteLine(sum);
        }
    }
}
//Task — Sum of Digits
// Description:
//Read an integer (positive or negative).
//Compute and print the sum of all its digits.
//(The minus sign does not count.)
// Example:
//Input:
//-3057
// Output:
//15
// Explanation:
//3 + 0 + 5 + 7 = 15
