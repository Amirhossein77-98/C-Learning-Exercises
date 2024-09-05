namespace Homework
{
    internal class FirstPrimeNumAfterNPrinter
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int firstPrimeNumber = PrimeNumCheck(number);
            Console.WriteLine(firstPrimeNumber);
        }

        static int PrimeNumCheck(int number)
        {
            for (int i = number; i < number + 100; i++)
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
                if (isIPrime)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}