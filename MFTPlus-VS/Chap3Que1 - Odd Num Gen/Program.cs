namespace HomeWork
{
    internal class OddNumGen
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter any number: ");
            int thresholdNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < thresholdNum; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}