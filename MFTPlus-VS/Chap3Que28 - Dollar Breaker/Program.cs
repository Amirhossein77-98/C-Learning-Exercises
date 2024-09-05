namespace Homework
{
    internal class DollarBreaker
    {
        static void Main(string[] args)
        {
            int targetAmount = 100;
            Console.WriteLine("Possible ways to break a $100 bill:");

            for (int fifty = 0; fifty <= targetAmount / 50; fifty++)
            {
                for (int twenty = 0; twenty <= (targetAmount - fifty * 50) / 20; twenty++)
                {
                    for (int ten = 0; ten <= (targetAmount - fifty * 50 - twenty * 20) / 10; ten++)
                    {
                        for (int five = 0; five <= (targetAmount - fifty * 50 - twenty * 20 - ten * 10) / 5; five++)
                        {
                            for (int two = 0; two <= (targetAmount - fifty * 50 - twenty * 20 - ten * 10 - five * 5) / 2; two++)
                            {
                                int one = targetAmount - fifty * 50 - twenty * 20 - ten * 10 - five * 5 - two * 2;
                                if (one >= 0)
                                {
                                    if (fifty > 0) Console.Write($"{fifty} x $50 ");
                                    if (twenty > 0) Console.Write($"{twenty} x $20 ");
                                    if (ten > 0) Console.Write($"{ten} x $10 ");
                                    if (five > 0) Console.Write($"{five} x $5 ");
                                    if (two > 0) Console.Write($"{two} x $2 ");
                                    if (one > 0) Console.Write($"{one} x $1 ");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}