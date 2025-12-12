using System.Text.RegularExpressions;

namespace FindSubstring2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string searchedSubstring = "in";

            int count = Regex.Matches(text, searchedSubstring, RegexOptions.IgnoreCase).Count;

            Console.WriteLine($"The substring '{searchedSubstring}' occurs {count} times in the text.");
        }
    }
}
