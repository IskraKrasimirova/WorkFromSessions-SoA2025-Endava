namespace SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees;
            string? timeOfDay;

            while (true)
            {
                Console.Write("Enter degrees (integer number between 10 and 42): ");
                var isValidDegrees = int.TryParse(Console.ReadLine(), out degrees);

                if (isValidDegrees && degrees >= 10 && degrees <= 42)
                {
                    break;
                }

                Console.WriteLine("Invalid degrees. Please enter an integer value between 10 and 42.");
            }

            while (true)
            {
                Console.Write("Enter time of day (Morning / Afternoon / Evening): ");
                timeOfDay = Console.ReadLine()?.Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(timeOfDay) && (timeOfDay == "morning" || timeOfDay == "afternoon" || timeOfDay == "evening"))
                {
                    break;
                }

                Console.WriteLine("Invalid time of day. Please enter one of the values: Morning / Afternoon / Evening.");
            }

            string outfit;
            string shoes;

            if (timeOfDay == "morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees >= 19 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else // degrees >= 25
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfDay == "afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees >= 19 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else // degrees >= 25
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfDay == "evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                // This case should never be reached due to prior validation
                outfit = "Unknown";
                shoes = "Unknown";
            }

            Console.WriteLine($"It's {degrees} degrees in the {timeOfDay}, get your {outfit} and {shoes}.");
        }
    }
}
//2. Summer Clothing
//Victor needs help deciding what clothes to wear based on the time of day and the temperature.
//Write a program that reads two lines from the console:
//An integer representing the degrees (in the range [10...42])
//A string representing the time of day – one of: "Morning", "Afternoon", "Evening"
//Based on these inputs, the program should recommend an outfit and shoes according to the following rules:

//Time of Day	    10–18°C	                19–24°C	            25°C and above
//Morning	    Sweatshirt + Sneakers	Shirt + Moccasins	    T-Shirt + Sandals
//Afternoon	    Shirt + Moccasins	    T-Shirt + Sandals	    Swim Suit + Barefoot
//Evening	    Shirt + Moccasins	    Shirt + Moccasins	    Shirt + Moccasins

//Output Format
//Print exactly one line in the following format:
//It's {degrees} degrees, get your {outfit} and {shoes}.