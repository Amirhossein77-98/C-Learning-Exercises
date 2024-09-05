namespace Homework
{
    internal class ThreeDigitPalindromePrinter
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int number = i;
                int reversedNumber = 0;
                while (number > 0)
                {
                    int remainder = number % 10;
                    reversedNumber = (reversedNumber * 10) + remainder;
                    number /= 10;
                }
                if (reversedNumber == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}