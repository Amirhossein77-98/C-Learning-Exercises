namespace GPTSuggested
{
    internal class ArraySorter
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 6, 9, 8, 2, 4, 5, 3, 1, 7 };

            int[] sortedArray = new int[array.Length];

            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int tempMin = 0;
                    if (array[i] < array[j])
                    {
                        tempMin = array[i];
                    }
                    Console.WriteLine(i);
                    sortedArray[counter] = tempMin;
                    counter++;
                }
            }
        }
    }
}