namespace Homework
{
    internal class AnagramPrinter
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number /= 10;
            }

            Console.WriteLine("Anagram of the number: " + reversedNumber);
        }
    }
}