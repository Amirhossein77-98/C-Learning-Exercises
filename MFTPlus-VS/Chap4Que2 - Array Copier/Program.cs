namespace Homework
{
    internal class ArrayCopier
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] secondArray = new int[firstArray.Length];

            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                secondArray[firstArray.Length - 1 - i] = firstArray[i];
            }
            foreach (int i in secondArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
