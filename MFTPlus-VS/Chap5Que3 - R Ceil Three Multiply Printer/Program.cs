namespace Homework
{
    internal class RThreeMulPrinter
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            RThresholdThreeMultiplyPrinter(number);
        }

        static void RThresholdThreeMultiplyPrinter(int r)
        {
            for (int i = 3; i < r; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}