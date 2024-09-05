namespace Homework
{
    internal class NumGenFunc
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            NumGen(number);
        }

        static void NumGen(int threshold)
        {
            for (int i = 0; i < threshold; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}