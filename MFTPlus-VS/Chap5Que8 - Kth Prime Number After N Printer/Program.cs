namespace Homework
{
    internal class KthPrimeNumAfterNPrinter
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the base number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the position number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int kthPrimeNumber = PrimeNumCheck(number, k);
            Console.WriteLine(kthPrimeNumber);
        }
        static int PrimeNumCheck(int number, int K)
        {
            int counter = 0;
            for (int i = number; i < number * K; i++)
            {
                bool isIPrime = true;
                for (int j = 1; j < i; j++)
                {
                    if (j != 1 && j != i && i % j == 0)
                    {
                        isIPrime = false;
                        break;
                    }
                }

                if (isIPrime == true)
                {
                    counter++;
                }
                if (counter == K)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}