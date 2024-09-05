namespace Homework
{
    internal class PowerIterator
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first positive number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second positive number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < secondNum; i++)
            {
                result *= firstNum;
            }

            Console.WriteLine(result);
        }
    }
}