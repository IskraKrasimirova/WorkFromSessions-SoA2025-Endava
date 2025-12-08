namespace ArrayCompressionFromSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicatedNumbers = [1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 1, 1, 4, 5, 5];
            int[] result = new int[duplicatedNumbers.Length];

            int counter = 0;
            for (int i = 0; i < duplicatedNumbers.Length; i++)
            {
                int temp = duplicatedNumbers[i];
                for (int k = i; k < duplicatedNumbers.Length; k++)
                {
                    if (temp == duplicatedNumbers[k])
                    {
                        if (k + 1 == duplicatedNumbers.Length)
                        {
                            result[counter] = temp;
                            break;
                        }
                        else
                            continue;
                    }
                    else
                    {
                        result[counter] = temp;
                        i = k - 1;
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
