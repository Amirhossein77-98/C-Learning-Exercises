using System;
using TestApp;

namespace App
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Please enter the first number: ");
            float firstNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            
            Console.WriteLine(TestApp.Calculator.Add(firstNum, secondNumber));
            Console.WriteLine(TestApp.Calculator.Subtract(firstNum, secondNumber));
            Console.WriteLine(TestApp.Calculator.Multiply(firstNum, secondNumber));
            Console.WriteLine(TestApp.Calculator.Divide(firstNum, secondNumber));
        }

    }

}