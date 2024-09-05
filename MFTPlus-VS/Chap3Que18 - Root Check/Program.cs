namespace Homework
{
    internal class RootCheck
    {
        static void Main(string[] arg)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < +(number / 2); i++)
            {
                if (Math.Pow(i, 2) < number && Math.Pow(i + 1, 2) >= number)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

