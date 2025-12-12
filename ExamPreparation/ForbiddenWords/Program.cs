namespace ForbiddenWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbiddenString = "C#,CLR,Microsoft";

            string[] forbiddenWords = forbiddenString
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var word in forbiddenWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
//5.A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks. Sample text:
// Example:
//Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.
//Sample string containing the forbidden words: "C#,CLR,Microsoft".
// Result:
//*********announced its next generation ** compiler today. It uses advanced parser and special optimizer for the ********* ***.
