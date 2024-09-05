namespace Homework
{
    internal class SecStuGPA
    {
        static void Main(string[] args)
        {
            int firstGPA = 0;
            int secondGPA = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Please enter the GPA {0}: ", i + 1);
                int GPA = Convert.ToInt32(Console.ReadLine());

                if (GPA >= firstGPA)
                {
                    firstGPA = GPA;
                }
                if (GPA >= secondGPA && GPA < firstGPA)
                {
                    secondGPA = GPA;
                }
            }
            Console.WriteLine(secondGPA);
        }
    }
}