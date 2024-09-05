namespace GPTSuggested
{
    internal class LeapYearChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && (year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine($"Year {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"Year {year} is not a leap year.");
            }
        }
    }
}