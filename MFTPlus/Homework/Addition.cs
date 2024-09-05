using System;

namespace Homework
{
    public class Addition
    {
        public static int Add()
        {
            Console.Write("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            return firstNum + secondNum;
        }
    }
}