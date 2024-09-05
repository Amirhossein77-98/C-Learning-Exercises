namespace Homework
{
    internal class BaseTenDec
    {
        static void Main(string[] args)
        {
            int number = 100;
            while (number > 9)
            {
                Console.WriteLine(number);
                number -= 10;
            }
        }
    }
}