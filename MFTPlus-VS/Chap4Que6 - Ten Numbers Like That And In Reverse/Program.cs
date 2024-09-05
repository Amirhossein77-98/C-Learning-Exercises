namespace Homework
{
    internal class TenNumsRevNotRevSaver
    {
        static void Main(string[] args)
        {
            int[] lastArray = new int[20];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                lastArray[9 - i] = userInput;
                lastArray[i + 10] = userInput;
            }

            foreach (int i in lastArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}