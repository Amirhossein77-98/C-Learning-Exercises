namespace Homework
{
    internal class NumGen
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            for (int i = firstNum + 1; i != secondNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}