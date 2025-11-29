namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 51);

            int userGuess = 0;

            while (userGuess != numberToGuess)
            {
                Console.Write("Guess a number between 1 and 50: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    int difference = Math.Abs(userGuess - numberToGuess);

                    if (difference == 0)
                    {
                        Console.WriteLine("Correct! You've guessed the number!");
                    }
                    else if (difference <= 5)
                    {
                        Console.WriteLine("Hot!");
                    }
                    else if (difference <= 20)
                    {
                        Console.WriteLine("Warm");
                    }
                    else
                    {
                        Console.WriteLine("Cold");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}

//The program picks a random number 1–50.
//The user keeps guessing until correct.
//Use loops to tell them:
//“Cold” if far away
//“Warm” if somewhat close
//“Hot!” if very close
