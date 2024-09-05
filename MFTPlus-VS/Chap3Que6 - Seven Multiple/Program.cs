namespace Homework
{
    internal class SevMul
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the minimum number: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the maximum number: ");
            int max = Convert.ToInt32(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("You've entered the numbers reversed! I'll fix that.");
                int temp = max;
                max = min;
                min = temp;
            }

            for (int i = min; i < max; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}