namespace Homework
{
    internal class DiceSimulationCounter
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] counter = new int[6];

            for (int i = 0; i < 200; i++)
            {
                int randomDice = random.Next(1, 7);

                if (randomDice == 1)
                {
                    counter[0]++;
                }
                if (randomDice == 2)
                {
                    counter[1]++;
                }
                if (randomDice == 3)
                {
                    counter[2]++;
                }
                if (randomDice == 4)
                {
                    counter[3]++;
                }
                if (randomDice == 5)
                {
                    counter[4]++;
                }
                if (randomDice == 6)
                {
                    counter[5]++;
                }
            }

            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine("{0} is repeated {1} times.", i + 1, counter[i]);
            }
        }
    }
}