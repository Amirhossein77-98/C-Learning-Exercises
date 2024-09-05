namespace Homework
{
    internal class FiveZeroTerminator
    {
        static void Main(string[] args)
        {
            int zeroCounter = 0;
            while (true)
            {
                Console.Write("Please enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    zeroCounter++;
                }
                if (zeroCounter == 5)
                {
                    break;
                }
            }
        }
    }
}