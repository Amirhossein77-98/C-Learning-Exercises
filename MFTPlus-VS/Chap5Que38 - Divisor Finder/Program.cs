namespace Homework

{
    internal class DivisorFinder
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DivisorCounter(number));
        }

        static int DivisorCounter(int number)
        {
            int counter = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}