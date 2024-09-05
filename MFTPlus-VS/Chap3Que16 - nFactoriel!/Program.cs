namespace Homework
{
    internal class NFactoriel
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}