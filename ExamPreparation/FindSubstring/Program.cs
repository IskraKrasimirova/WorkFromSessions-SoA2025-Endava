namespace FindSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string searchedSubstring = "in";

            int count = 0;
            int index;

            while (true)
            {
                if (!text.Contains(searchedSubstring, StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                index = text.IndexOf(searchedSubstring, StringComparison.InvariantCultureIgnoreCase);
                text = text.Substring(index + searchedSubstring.Length);
                count++;
            }

            Console.WriteLine($"The substring '{searchedSubstring}' occures {count} times in the text.");
        }
    }
}
//4.Write a program that detects how many times a substring is contained in the text. For example, let’s look for the substring "in" in the text:
//Example:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
// The result is 9 occurrences. 
// drinking contains 'in' 2 times !!! so decision with string[] words is not appropriate
