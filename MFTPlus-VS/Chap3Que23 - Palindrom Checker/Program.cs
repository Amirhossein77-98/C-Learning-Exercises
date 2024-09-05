namespace Homework
{
    internal class PalindromCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number /= 10;
            }

            if (reversedNumber == originalNumber)
            {
                Console.WriteLine("{0} is a Palindrome.", originalNumber);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome.", originalNumber);
            }
        }
    }
}