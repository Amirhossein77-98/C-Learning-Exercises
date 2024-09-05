namespace GPTSuggested
{
    internal class PrimeNumCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number)) { Console.WriteLine($"{number} IS a prime number."); } else { Console.WriteLine($"{number} is NOT a prime number!"); }
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}