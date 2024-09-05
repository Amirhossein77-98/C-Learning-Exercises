namespace Homework
{
    internal class ArraysComparator
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] A = new int[50];
            int[] B = new int[50];
            int[] C = new int[50];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(0, 9);
                B[i] = random.Next(0, 9);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > B[i])
                {
                    C[i] = 1;
                }
                else if (A[i] < B[i])
                {
                    C[i] = -1;
                }
                else if (A[i] == B[i])
                {
                    C[i] = 0;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < C.Length; i++)
            {
                Console.Write(C[i]);
            }
        }
    }
}