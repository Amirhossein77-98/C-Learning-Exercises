namespace Homework
{
    internal class RevEvenArrMemPrinter
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 6; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Place {0}:  {1}", i, numbers[i]);
                }
            }
        }
    }
}