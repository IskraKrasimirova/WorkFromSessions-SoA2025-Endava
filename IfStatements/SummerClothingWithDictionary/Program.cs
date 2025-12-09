namespace SummerClothingWithDictionary
{
    internal class Program
    {
        private const int MinDegrees = 10;
        private const int MaxDegrees = 42;

        static void Main(string[] args)
        {
            int degrees = ReadValidDegrees($"Enter degrees (integer number between {MinDegrees} and {MaxDegrees}): ");
            string timeOfDay = ReadValidTimeOfDay("Enter time of day (Morning / Afternoon / Evening): ");

            // Key: (timeOfDay, range), Value: (outfit, shoes)
            var clothingRules = new Dictionary<(string, string), (string outfit, string shoes)>
            {
                { ("morning", "10-18"), ("Sweatshirt", "Sneakers") },
                { ("morning", "19-24"), ("Shirt", "Moccasins") },
                { ("morning", "25+"), ("T-Shirt", "Sandals") },

                { ("afternoon", "10-18"), ("Shirt", "Moccasins") },
                { ("afternoon", "19-24"), ("T-Shirt", "Sandals") },
                { ("afternoon", "25+"), ("Swim Suit", "Barefoot") },

                { ("evening", "any"), ("Shirt", "Moccasins") }
            };

            string range = GetRange(degrees, timeOfDay);
            var (outfit, shoes) = clothingRules[(timeOfDay, range)];

            Console.WriteLine($"It's {degrees} degrees in the {timeOfDay}, get your {outfit} and {shoes}.");
        }

        private static string GetRange(int degrees, string timeOfDay)
        {
            if (timeOfDay == "evening")
            {
                return "any";
            }

            if (degrees <= 18)
            {
                return "10-18";
            }
            else if (degrees <= 24)
            {
                return "19-24";
            }
            else
            {
                return "25+";
            }
        }

        private static string ReadValidTimeOfDay(string message)
        {
            while (true)
            {
                Console.Write(message);
                var timeOfDay = Console.ReadLine()?.Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(timeOfDay) && (timeOfDay == "morning" || timeOfDay == "afternoon" || timeOfDay == "evening"))
                {
                    return timeOfDay;
                }

                Console.WriteLine("Invalid time of day. Please enter one of the values: Morning / Afternoon / Evening.");
            }
        }

        private static int ReadValidDegrees(string message)
        {
            while (true)
            {
                Console.Write(message);
                var isValidDegrees = int.TryParse(Console.ReadLine(), out int degrees);

                if (isValidDegrees && degrees >= MinDegrees && degrees <= MaxDegrees)
                {
                    return degrees;
                }

                Console.WriteLine($"Invalid degrees. Please enter an integer value between {MinDegrees} and {MaxDegrees}.");
            }
        }
    }
}
