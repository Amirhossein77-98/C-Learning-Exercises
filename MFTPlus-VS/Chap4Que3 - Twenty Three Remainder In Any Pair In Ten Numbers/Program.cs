namespace Homework
{
    internal class TwentyThreeRemInFivePairs
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in numbers)
            {
                if (numbers[i] % numbers[i + 1] == 23)
                {
                    Console.WriteLine("{0} divided by {1} has a remainder of {2}", numbers[i], numbers[i + 1], (numbers[i] % numbers[i + 1]));
                }
            }
        }
    }
}