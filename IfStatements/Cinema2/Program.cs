namespace Cinema2
{
    internal class Program
    {
        private const decimal PremierePrice = 12.00m;
        private const decimal NormalPrice = 7.50m;
        private const decimal DiscountPrice = 5.00m;

        static void Main(string[] args)
        {
            string? screeningType;
            int rows;
            int columns;

            while (true)
            {
                Console.Write("Enter type of screening (Premiere / Normal / Discount): ");
                screeningType = Console.ReadLine();

                screeningType = screeningType?.Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(screeningType) && (screeningType == "premiere" || screeningType == "normal" || screeningType == "discount"))
                {
                    break;
                }

                Console.WriteLine("Invalid screening type.");
            }

            while (true)
            {
                Console.Write("Enter number of rows: ");
                var isValidRowNumber = int.TryParse(Console.ReadLine(), out rows);

                if (isValidRowNumber && rows > 0)
                {
                    break;
                }

                Console.WriteLine("Invalid number of rows.");
            }

            while (true)
            {
                Console.Write("Enter number of columns: ");
                var isValidColumnNumber = int.TryParse(Console.ReadLine(), out columns);

                if (isValidColumnNumber && columns > 0)
                {
                    break;
                }

                Console.WriteLine("Invalid number of columns.");
            }
 
            decimal ticketPrice = 0;

            switch (screeningType)
            {
                case "premiere":
                    ticketPrice = PremierePrice;
                    break;
                case "normal":
                    ticketPrice = NormalPrice;
                    break;
                case "discount":
                    ticketPrice = DiscountPrice;
                    break;
                default:
                    Console.WriteLine("Invalid screening type.");
                    return;
            }

            decimal totalRevenue = rows * columns * ticketPrice;

            Console.WriteLine($"Total ticket revenue: EUR {totalRevenue:F2}");
        }
    }
}
