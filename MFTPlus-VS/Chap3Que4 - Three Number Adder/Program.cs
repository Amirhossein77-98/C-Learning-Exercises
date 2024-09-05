namespace Homework
{
    internal class ThreeNumAdd
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNum + secondNum + thirdNum);
        }
    }
}