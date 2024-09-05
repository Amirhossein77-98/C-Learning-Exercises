namespace Homework
{
    internal class SavePNumsInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[] primeNumbers = new int[n];
            int count = 0;

            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers[count] = i;
                    count++;
                }
            }

            Console.WriteLine("Prime numbers less than " + n + ":");
            for (int i = 0; i < count; i++)
            {
                Console.Write(primeNumbers[i] + " ");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}