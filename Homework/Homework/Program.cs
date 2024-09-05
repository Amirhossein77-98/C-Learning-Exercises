using System;
using Microsoft.VisualBasic;

namespace Homework
{
    internal class HomeworkOne
    {
        static void Main(string[] args)
        {
            Jaygah.Reverse();
            Console.Write("Please enter the first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Addition.Add(firstNum, secondNum));
            Console.WriteLine(Subtraction.Minus(firstNum, secondNum));
            Console.WriteLine(Division.Divide(firstNum, secondNum));
            Console.WriteLine(Multiplication.Multiply(firstNum, secondNum));

            Console.WriteLine("-----------------------------");

            int year = 0;
            int month = 0;
            int day = 0;
            bool acceptableDate = false;
            do
            {
                Console.Write("Please enter your birthday (Format: YYYY-MM-DD): ");
                string? birthday = Console.ReadLine();
                if (birthday == "" || birthday == null)
                {
                    continue;
                }
                if (birthday.Length != 10)
                {
                    Console.WriteLine("Please enter the date in a valid format!");
                    continue;
                }

                try
                {
                    int newYear = Convert.ToInt32(birthday.Split("-")[0]);
                    if (newYear - 1000 >= 0)
                    {
                        year = newYear;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    int newMonth = Convert.ToInt32(birthday.Split("-")[1]);
                    if (newMonth - 12 >= -11 && newMonth - 12 <= 0)
                    {
                        month = newMonth;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    int newDay = Convert.ToInt32(birthday.Split("-")[2]);
                    if (newDay - 30 >= -29 && newMonth - 12 <= 0)
                    {
                        day = newDay;
                        acceptableDate = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter the date in a valid format!");
                    continue;
                }
                break;
            } while (true);

            if (acceptableDate)
            {
                string currentDate = Convert.ToString(DateTime.Now);
                int currentYear = Convert.ToInt32(currentDate.Split(" ")[0].Split("/")[2]);
                int currentMonth = Convert.ToInt32(currentDate.Split(" ")[0].Split("/")[0]);
                int currentDay = Convert.ToInt32(currentDate.Split(" ")[0].Split("/")[1]);

                int daysPassed = Math.Abs(day - currentDay);
                int monthsPassed = Math.Abs(month - currentMonth);
                int yearsPassed = Math.Abs(year - currentYear);

                int yearsInMinutes = yearsPassed * 365 * 24 * 60;
                int monthsInMinutes = monthsPassed * 30 * 24 * 60;
                int daysInMinutes = daysPassed * 24 * 60;

                int minutesPassed = yearsInMinutes + monthsInMinutes + daysInMinutes;

                Console.WriteLine("You Lived " + minutesPassed + " minutes!");
            }



            Console.ReadKey();
        }
    }
}