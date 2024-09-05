namespace Homework
{
    internal class FiFoEvNuThMul
    {
        static void Main(string[] args)
        {
            int evenNumCounter = 0;
            int threeMultiplyCounter = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput % 2 == 0 && evenNumCounter < 4)
                {
                    evenNumCounter++;
                    if (userInput % 3 == 0)
                    {
                        threeMultiplyCounter++;
                    }
                }
            }
            Console.WriteLine("Even numbers: {0}", evenNumCounter);
            Console.WriteLine("Three Multiplies: {0}", threeMultiplyCounter);
        }
    }
}