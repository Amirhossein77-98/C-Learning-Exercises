namespace Homework
{
    internal class NthFiboMemPrinter
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0}th Fibonacci member of the series is: {1}", number, NthFibonacciMemberCalc(number));
        }
        static int NthFibonacciMemberCalc(int number)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1} ", a, b);

            for (int i = 1; i < number; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
            return c;
        }
    }
}