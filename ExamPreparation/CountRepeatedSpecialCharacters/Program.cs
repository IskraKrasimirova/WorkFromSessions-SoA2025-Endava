namespace CountRepeatedSpecialCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text including symbols: ");
            string text = Console.ReadLine()!;

            string[] specialChars = { "!", "@", "#", "$", "%", "^", "*", "(", ")", "-", "_", "=", "+", "[", "]", "{", "}", ";", "'", "\"", ",", ".", "/", "?", "\\", "|", "<", ">" };

            int[] symbolsCounts = new int[specialChars.Length];

            foreach (var ch in text)
            {
                if (specialChars.Contains(ch.ToString()))
                {
                    int index = Array.IndexOf(specialChars, ch.ToString());
                    symbolsCounts[index]++;
                }
            }

            var counter = 0;

            foreach (var count in symbolsCounts)
            {
                if (count > 1)
                {
                    counter++;
                }
            }

            // Using LINQ
            var countOfExistingChars = symbolsCounts.Where(x => x > 1).Count();

            Console.WriteLine($"The count of special characters that appear more than once in the text is: {counter}");
            Console.WriteLine($"The count of special characters that appear more than once in the text is: {countOfExistingChars}");

            for (int i = 0; i < specialChars.Length; i++)
            {
                Console.WriteLine($"Symbol '{specialChars[i]}' has occured {symbolsCounts[i]} times");
            }
        }
    }
}
//Task — Count Repeated Special Characters
// Description:
//Read a text line as input.
//Count how many distinct special characters (non-letter, non-digit) appear more than once.
//Also print the frequency of each special character found.
// Special characters include things like:
//! @ # $ % ^ & * ( ) - _ = + [ ] { } ; : ' " , . / ? \ | < >
// You must not use LINQ or collections — only arrays or fixed-size buffers.
