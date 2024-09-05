namespace Homework
{
    internal class InfNumAdd
    {
        static void Main(string[] args)
        {
            int result = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 0)
                {
                    break;
                }
                result += userInput;
            }
            Console.WriteLine(result);
        }
    }
}