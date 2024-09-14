namespace NumberGuessingGame
{
    internal class Guesser
    {
        static void Main(string[] args)
        {
            // Getting the input
            Console.Write("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Initializing the values
            int lowerBound = 0;
            int upperBound = 1_000_000;
            bool isFound = false;

            // Starting the guess iteration
            for (int i = 0; i < 20; i++)
            {
                // Applying Binary Search: halving the range of possibilities each time
                int guess = (lowerBound + upperBound) / 2;
                Console.WriteLine($"Try {i + 1}: Guessed {guess}");

                // Proximity Check Conditions
                if (guess < userInput)
                {
                    lowerBound = guess + 1;
                }
                else if (guess > userInput)
                {
                    upperBound = guess - 1;
                }
                else // If the number is found
                {
                    isFound = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Found the number in {i + 1} tries! It's {guess}.");
                    Console.ResetColor();
                    break;
                }
            }

            // If the number is not found in 20 iterations
            if (!isFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wow, I couldn't find the number in 20 tries!");
                Console.ResetColor();
            }
        }
    }
}
