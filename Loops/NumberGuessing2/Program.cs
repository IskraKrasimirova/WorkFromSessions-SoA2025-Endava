namespace NumberGuessingFromSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 51);
            int numberOfAttempts = 5;

            bool isGuessed = false;

            while (numberOfAttempts != 0)
            {
                int inputNumber = int.Parse(Console.ReadLine()!);
                var difference = Math.Abs(inputNumber - randomNumber);

                if (difference == 0)
                {
                    isGuessed = true;
                    break;
                }
                else if (difference > 15)
                {
                    Console.WriteLine("Cold");
                }
                else if (difference >= 5 && difference <= 15)
                {
                    Console.WriteLine("Warm");
                }
                else
                {
                    Console.WriteLine("Hot!");
                }

                numberOfAttempts--;
            }

            if (numberOfAttempts != 0 && isGuessed)
            {
                Console.WriteLine("Congratulations! You've guessed the number!");
            }
            else
            {
                Console.WriteLine($"Sorry, you've used all attempts. The number was {randomNumber}.");
            }
        }
    }
}
