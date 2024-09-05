namespace Homework
{
    internal class WholeNumCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int divisor = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisor += i;
                }
            }
            if (number == divisor)
            {
                Console.WriteLine("{0} is a whole number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a whole number.", number);
            }
        }
    }
}