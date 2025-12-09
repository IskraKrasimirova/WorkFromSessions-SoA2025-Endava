namespace Cinema3
{
    internal class Program
    {
        private const decimal PremierePrice = 12.00m;
        private const decimal NormalPrice = 7.50m;
        private const decimal DiscountPrice = 5.00m;

        static void Main(string[] args)
        {
            string? screeningType = ReadValidScreeningType();
            int rows = ReadValidPositiveInteger("Enter number of rows: ");
            int columns = ReadValidPositiveInteger("Enter number of columns: ");

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

        private static int ReadValidPositiveInteger(string message)
        {
            while (true)
            {
                Console.Write(message);
                var isValidRowNumber = int.TryParse(Console.ReadLine(), out int rows);

                if (isValidRowNumber && rows > 0)
                {
                    return rows;
                }

                Console.WriteLine("Invalid number of rows.");
            } 
        }

        private static string ReadValidScreeningType()
        {
            while (true)
            {
                Console.Write("Enter type of screening (Premiere / Normal / Discount): ");
                var screeningType = Console.ReadLine()?.Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(screeningType) && (screeningType == "premiere" || screeningType == "normal" || screeningType == "discount"))
                {
                    return screeningType;
                }

                Console.WriteLine("Invalid screening type.");
            }
        }
    }
}
