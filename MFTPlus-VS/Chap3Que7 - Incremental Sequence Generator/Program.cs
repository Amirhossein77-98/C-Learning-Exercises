namespace Homework
{
    internal class IncSeqGen
    {
        static void Main(string[] args)
        {
            int incrementor = 0;
            int number = 1;

            while (number < 1000)
            {
                number += incrementor;
                if (number >= 1000)
                {
                    break;
                }
                Console.WriteLine(number);
                incrementor++;

            }
        }
    }
}