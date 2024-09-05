namespace Homework
{
    internal class AnyNumEqualToUnitNumsAddition
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("{0}. Please enter a number: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int unitsNumberAdded = 0;
            foreach (int i in numbers)
            {
                unitsNumberAdded += i % 10;
            }

            foreach (int i in numbers)
            {
                if (i == unitsNumberAdded)
                {
                    Console.WriteLine("{0} is equal to {1} member.", unitsNumberAdded, i);
                }
            }
        }
    }
}