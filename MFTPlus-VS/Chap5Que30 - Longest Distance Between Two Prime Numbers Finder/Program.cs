namespace Homework
{
    internal class LstDistBetwTwoPNumberFinder
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Longest distance between two prime numbers less than 1000 is: {PrimeNumGen()}");
        }

        static int PrimeNumGen()
        {
            int prevPrimeNum = 2;
            int longestDistance = 0;

            for (int i = 3; i < 1000; i++)
            {
                if (IsPrime(i))
                {
                    int currentPrimeNum = i;
                    int distance = currentPrimeNum - prevPrimeNum;
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                    prevPrimeNum = currentPrimeNum;
                }
            }

            return longestDistance;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
