namespace GPTSuggested
{
    internal class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a grade number: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade <= 100 && grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade < 80 && grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade < 70 && grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade < 60 && grade >= 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Out of Range!");
            }
        }
    }
}