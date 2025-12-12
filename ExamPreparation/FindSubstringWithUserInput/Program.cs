namespace FindSubstringWithUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();

            Console.Write("Enter text to search for: ");
            var searchedSubstring = Console.ReadLine();

            int count = 0;
            int index = 0;

            while ((index = text!.IndexOf(searchedSubstring!, index, StringComparison.InvariantCultureIgnoreCase)) != -1)
            {
                count++;
                index += searchedSubstring!.Length;
            }

            Console.WriteLine($"The substring '{searchedSubstring}' occures {count} times in the text.");
        }
    }
}
