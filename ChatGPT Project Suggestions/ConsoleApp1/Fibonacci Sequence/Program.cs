namespace GPTSuggest
{
    internal class FibonacciSeqPrinter
    {
        static void Main(string[] args)
        {

            int prevPrevNum = 0;
            int prevNum = 1;
            Console.Write("0 1 ");

            for (int i = 0; i < 18; i++)
            {
                int currentNum = prevPrevNum + prevNum;
                Console.Write($"{currentNum} ");
                prevPrevNum = prevNum;
                prevNum = currentNum;
            }
        }
    }
}