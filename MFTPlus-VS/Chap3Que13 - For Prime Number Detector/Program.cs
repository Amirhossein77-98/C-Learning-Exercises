namespace Homework
{
    internal class ForPriNumCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrimeNum = true;
            for (int i = 1; i <= number; i++)
            {
                if (i != number && i != 1 && number % i == 0)
                {
                    isPrimeNum = false;
                    break;
                }
            }

            if (isPrimeNum)
            {
                Console.WriteLine("{0} is a Prime number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number!", number);
            }
        }
    }
}