namespace Homework
{
    internal class ThreeDigitPrimeNumPrinter
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                bool isPrime = true;
                for (int j = 1; j <= 999; j++)
                {
                    if (j != i && j != 1 && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}