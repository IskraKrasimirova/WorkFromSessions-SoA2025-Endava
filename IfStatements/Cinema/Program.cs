namespace Cinema
{
    internal class Program
    {
        private const decimal PremierePrice = 12.00m;
        private const decimal NormalPrice = 7.50m;
        private const decimal DiscountPrice = 5.00m;

        static void Main(string[] args)
        {
            Console.Write("Enter type of screening (Premiere / Normal / Discount): ");
            string? screeningType = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(screeningType))
            {
                Console.WriteLine("Screening type cannot be empty.");
                return;
            }

            screeningType = screeningType.Trim().ToLower();

            if (screeningType != "premiere" && screeningType != "normal" && screeningType != "discount")
            {
                Console.WriteLine("Invalid screening type.");
                return;
            }

            Console.Write("Enter number of rows: ");
            var isValidRowNumber = int.TryParse(Console.ReadLine(), out int rows);

            if (!isValidRowNumber || rows <= 0)
            {
                Console.WriteLine("Invalid number of rows.");
                return;
            }

            Console.Write("Enter number of columns: ");
            var isValidColumnNumber = int.TryParse(Console.ReadLine(), out int columns);

            if (!isValidColumnNumber || columns <= 0)
            {
                Console.WriteLine("Invalid number of columns.");
                return;
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
//1.Cinema
//In a movie theater, the chairs are arranged in a rectangular shape. The hall has r rows and c columns. There are three types of screenings with different ticket prices:
//Premiere – EUR 12.00
//Normal – EUR 7.50
//Discount – EUR 5.00
//Write a program that reads the type of screening (string), the number of rows and the number of columns (integers) in the hall, entered by the user. The program should calculate the total ticket revenue for a full house and print the result formatted to two decimal places.