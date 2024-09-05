namespace Homework
{
    internal class SeqCal
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstMem = 1;
            int secondMem = 2;
            int result = 0;
            for (int i = 2; i <= number; i++)
            {
                result += firstMem * secondMem;
                Console.Write("{0} * {1} + ", firstMem, secondMem);

                firstMem = secondMem;
                secondMem = i + 1;

            }
            Console.Write("\b\b= {0}", result);
        }
    }
}