namespace Homework
{
    internal class FourMulWithOneTwoThreeAsOne
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 100; i <= 200; i++)
            {
                if ((i % 4 == 0) && (i % 10 == 0 || i % 10 == 1 || i % 10 == 2))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}