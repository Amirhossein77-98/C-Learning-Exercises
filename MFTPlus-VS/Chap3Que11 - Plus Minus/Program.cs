using System;

namespace Homework
{
    internal class PlusMinus
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result -= i;
                }
                else
                {
                    result += i;
                }
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
