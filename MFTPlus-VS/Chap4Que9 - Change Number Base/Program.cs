namespace Homework
{
    internal class NumBaseChanger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int[] binaryArray = ConvertToBinary(decimalNumber);
            Console.Write("Binary representation: ");
            foreach (int bit in binaryArray)
            {
                Console.Write(bit);
            }
        }

        static int[] ConvertToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return new int[] { 0 };
            }

            int[] binary = new int[32]; // Assuming a maximum of 32 bits for simplicity
            int index = binary.Length - 1;

            while (decimalNumber > 0)
            {
                binary[index] = decimalNumber % 2;
                decimalNumber /= 2;
                index--;
            }

            // Remove leading zeros
            int[] trimmedBinary = new int[binary.Length - index - 1];
            Array.Copy(binary, index + 1, trimmedBinary, 0, trimmedBinary.Length);

            return trimmedBinary;
        }
    }
}