using System;

namespace Homework
{
    internal class FirstPNumAfterN
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine()) + 1;
            int input = number - 1;

            while (true)
            {
                bool isPrime = true;

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("The first Prime Number after {0} is {1}.", input, number);
                    break;
                }

                number++;
            }
        }
    }
}
