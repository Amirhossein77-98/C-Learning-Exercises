namespace Homework
{
    internal class NumGuessGame
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int min = 0;
            int max = 1000000;
            int guess = 1;
            bool found = false;
            while (counter < 20)
            {
                Console.Write("Is it {0}? (say lower, higher, or yes) ", guess);
                string answer = Console.ReadLine();

                if (answer == "lower")
                {
                    guess /= 2;
                    if (guess < min)
                    {
                        guess = (min - guess) + min + 1;
                    }
                }
                if (answer == "higher")
                {
                    guess *= 2;
                    if (guess > max)
                    {
                        guess = (max - guess) - max - 1;
                    }
                }
                if (answer == "yes")
                {
                    Console.WriteLine("I won!!!");
                    found = true;
                }
                counter++;
            }
            if (!found)
            {
                Console.WriteLine("I Lost!!!");
            }
        }
    }
}
