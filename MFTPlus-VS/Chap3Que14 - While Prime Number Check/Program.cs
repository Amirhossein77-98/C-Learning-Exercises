namespace Homework
{
    internal class WhilePrimeNumCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            int counter = 1;
            while (counter <= number)
            {
                if (counter != number && counter != 1 && number % counter == 0)
                {
                    isPrime = false;
                    break;
                }
                counter++;
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is a prime number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number!", number);
            }
        }
    }
}