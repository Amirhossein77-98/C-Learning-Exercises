namespace Homework
{
    internal class BiggerDecPrinter
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 100; i++)
            {
                int tens = i / 10;
                int units = i % 10;

                if (units > tens)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}