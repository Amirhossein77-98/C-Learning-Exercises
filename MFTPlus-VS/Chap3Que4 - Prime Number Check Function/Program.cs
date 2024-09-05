namespace Homework
{
    internal class PrimeNumCheckFunc
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = PrimeNumberCheck(number);
            if (isPrime)
            {
                Console.WriteLine("{0} is a prime number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number!", number);
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