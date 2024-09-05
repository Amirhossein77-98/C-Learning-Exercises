using System;

namespace Homework
{
    internal class MostPNumInHundRangeBetwHundAndTenThous
    {
        static void Main(string[] args)
        {
            int min = 100;
            int limit = 200;
            int max = 10000;
            int maxPrimeNumFoundInARange = 0;
            int rangeWithMaxPrimeNumsMin = 0;
            int rangeWithMaxPrimeNumsMax = 0;

            while (limit <= max)
            {
                int counter = 0;
                for (int i = min; i <= limit; i++)
                {
                    if (PrimeNumberCheck(i))
                    {
                        counter++;
                    }
                }

                if (counter > maxPrimeNumFoundInARange)
                {
                    maxPrimeNumFoundInARange = counter;
                    rangeWithMaxPrimeNumsMax = limit;
                    rangeWithMaxPrimeNumsMin = min;
                }

                min += 100;
                limit += 100;
            }

            Console.WriteLine("The range with the most prime numbers is between {0} and {1}: {2} Prime Numbers.",
                rangeWithMaxPrimeNumsMin,
                rangeWithMaxPrimeNumsMax,
                maxPrimeNumFoundInARange);
        }

        static bool PrimeNumberCheck(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
