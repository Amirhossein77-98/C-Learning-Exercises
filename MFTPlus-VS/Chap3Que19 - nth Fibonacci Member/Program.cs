namespace Homework
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1} ", a, b);

            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
