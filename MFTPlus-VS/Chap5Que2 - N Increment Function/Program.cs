namespace Homework
{
    internal class NIncFunc
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Incrementor(number);
        }

        static void Incrementor(int number)
        {
            Console.WriteLine(number + 1);
        }
    }
}