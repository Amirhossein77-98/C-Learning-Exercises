namespace GPTSuggested
{
    internal class ArrayReverser
    {
        static void Main(string[] args)
        {
            int[] userArray = GetArray();
            Console.Write("User Array: ");
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write(userArray[i] + " ");
            }
            Console.WriteLine();

            int[] revArray = arrayReverser(userArray);
            Console.Write("Reversed Array: ");
            for (int i = 0; i < revArray.Length; i++)
            {
                Console.Write(revArray[i] + " ");
            }
        }

        static int[] GetArray()
        {
            Console.Write("How many numbers do you want to enter? ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Please enter number {i + 1}/{size}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return userArray;
        }

        static int[] arrayReverser(int[] userArray)
        {
            int[] revArray = new int[userArray.Length];

            for (int i = 0; i < userArray.Length; i++)
            {
                revArray[i] = userArray[userArray.Length - 1 - i];
            }

            return revArray;
        }
    }
}
