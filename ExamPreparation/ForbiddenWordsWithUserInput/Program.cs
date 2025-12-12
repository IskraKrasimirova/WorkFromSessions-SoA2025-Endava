namespace ForbiddenWordsWithUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? text;
            string? forbiddenString;

            while (true)
            {
                Console.Write("Enter text: ");
                text = Console.ReadLine();
                Console.Write("Enter forbidden words separated by comma: ");
                forbiddenString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Text cannot be empty. Please try again.");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(forbiddenString))
                {
                    Console.WriteLine("Forbidden words cannot be empty. Please try again.");
                    continue;
                }

                break;
            }

            string[] forbiddenWords = forbiddenString
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.Trim())
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Distinct()
                .ToArray();

            if (forbiddenWords.Length == 0)
            {
                Console.WriteLine("No valid forbidden words entered.");
                return;
            }

            foreach (var word in forbiddenWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
