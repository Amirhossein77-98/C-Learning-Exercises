namespace Homework
{
    internal class HundredPrimeNumGen
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                bool isPrime = PrimeNumberCheck(i);
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool PrimeNumberCheck(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (i != 1 && i != number && number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}