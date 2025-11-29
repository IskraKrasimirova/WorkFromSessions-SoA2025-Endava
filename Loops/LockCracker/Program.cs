namespace LockCracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] lockCode = [
                random.Next(0, 10),
                random.Next(0, 10),
                random.Next(0, 10),
                random.Next(0, 10)
            ];

            bool isHintUsed = false;

            while (true)
            {
                Console.Write("Enter 4-digit number from 0000 to 9999 or type hint: ");

                var userGuess = Console.ReadLine();

                if (userGuess != "hint")
                {
                    bool isLockCracked = true;

                    for (int i = 0; i < lockCode.Length; i++)
                    {
                        int userValue = int.Parse(userGuess![i].ToString());
                        int lockValue = lockCode[i];
                        isLockCracked &= CheckUserAndLockValue(i, userValue, lockValue);
                    }

                    if (isLockCracked)
                    {
                        Console.WriteLine("Congratulations! You have guessed the number. Lock cracked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }
                }
                else if (userGuess == "hint" && isHintUsed == false)
                {
                    int hintPosition = random.Next(0, lockCode.Length);
                    Console.WriteLine($"Hint: The digit at position {hintPosition} is {lockCode[hintPosition]}");
                    isHintUsed = true;
                }
                else
                {
                    Console.WriteLine("You have already used your hint.");
                    continue;
                }
            }
        }

        private static bool CheckUserAndLockValue(int index, int userValue, int lockValue)
        {
            var difference = Math.Abs(userValue - lockValue);
            bool isNumberGuessed = false;

            if (difference == 0)
            {
                Console.WriteLine($"Index {index} is correct.");
                isNumberGuessed = true;
            }
            else if (difference == 1)
            {
                Console.WriteLine($"Index {index} is close.");
            }
            else
            {
                Console.WriteLine($"Index {index} is wrong.");
            }

            return isNumberGuessed;
        }
    }
}
/*
 * Create a C# program that simulates cracking a 4-digit digital lock.
Each digit ranges from 0 to 9.
Requirements
1. Generate a Secret Code
Create an array of 4 digits.
Each digit should be a random number from 0–9.

2. Player Guessing Loop
The program should repeatedly ask the user to guess each of the 4 digits.
For each digit position:
Ask the user to enter a number 0–9
OR type "hint" (see hint rules below)

3. Hint System
The user can type "hint" instead of a number.
If they do, the program:
Reveals one random digit of the secret code (and its position).
Allows the user to continue guessing normally.
Only one hint is allowed during the whole game.
If the user tries to use hint again, show an error message.

4. Feedback for Each Digit
After the user inputs all 4 digits, the program should compare each guess to the secret code and show:
“Correct” → Digit is exactly right
“Close” → Digit is off by 1 (e.g., secret = 7, guess = 6 or 8)
“Wrong” → Digit is not correct or close

5. Repeating Until Unlocked
If all 4 digits are correct, the lock is cracked → show a success message.
If not, show feedback and allow the user to try again.
 */
