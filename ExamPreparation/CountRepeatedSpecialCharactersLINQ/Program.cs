using System.Diagnostics.Metrics;

namespace CountRepeatedSpecialCharactersLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text including symbols: ");
            string text = Console.ReadLine()!;

            string[] specialChars = { "!", "@", "#", "$", "%", "^", "*", "(", ")", "-", "_", "=", "+", "[", "]", "{", "}", ";", "'", "\"", ",", ".", "/", "?", "\\", "|", "<", ">" };

            // This takes only the symbols that occurs more than once
            var symbolsCounts = text
                .Where(x => specialChars.Contains(x.ToString()))
                .GroupBy(c => c)
                .Select(g => new { Symbol = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1)
                .ToList();

            Console.WriteLine($"Distinct special characters repeated: {symbolsCounts.Count}");

            foreach (var item in symbolsCounts)
            {
                Console.WriteLine($"'{item.Symbol}' -> {item.Count}");
            }

            //// Full decision with LINQ
            //var counts = specialChars
            //    .Select(s => new
            //    {
            //        Symbol = s,
            //        Count = text.Count(c => c.ToString() == s)
            //    })
            //    .ToList();

            //int repeatedCount = counts.Count(x => x.Count > 1);
            //Console.WriteLine($"Distinct special characters repeated: {repeatedCount}");

            //foreach (var item in counts)
            //{
            //    Console.WriteLine($"'{item.Symbol}' -> {item.Count}");
            //}
        }
    }
}
