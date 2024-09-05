namespace Homework
{
    internal class FirNFacGreThanFiveTTPowOfNPrinter
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                if (FactorielCalc(number) > PowerCalc(number))
                {
                    break;
                }
                number++;
            }
            Console.WriteLine(number);
        }

        static int FactorielCalc(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static int PowerCalc(int number)
        {
            int result = 1;
            for (int i = 0; i < number; i++)
            {
                result *= 5;
            }
            return result;
        }
    }
}