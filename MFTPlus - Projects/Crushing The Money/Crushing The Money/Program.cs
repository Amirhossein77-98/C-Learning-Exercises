using static System.Net.Mime.MediaTypeNames;

namespace CrushingTheMoney
{
    internal class MoneyCrusher
    {

        // Defining a dictionary to hold denomination counts
        private static Dictionary<string, int> moneyCounts = new Dictionary<string, int>
        {
            { "$100", 0 },
            { "$50", 0 },
            { "$20", 0 },
            { "$10", 0 },
            { "$5", 0 },
            { "$2", 0 },
            { "$1", 0 }
        };

        // Main body of the application
        private static void Main(string[] args)
        {
            // Getting the input and setting the color of the entered money to green
            Console.Write("Please enter the money: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();


            foreach (var item in moneyCounts)
            {
                Crusher(money, new Dictionary<string, int> { { item.Key, item.Value } });
                // Setting the default color of the console text to yellow
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Printing each denomination colorfully and iteratively
                foreach (var crush in moneyCounts)
                {
                    PrintWithColor(crush.Value, crush.Key);
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------------------------");

                // Resetting the console text color
                Console.ResetColor();

                foreach (var member in moneyCounts)
                {
                    moneyCounts[member.Key] = 0;
                }
            }

            // Setting the color of the result header to blue and printing it
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Your money can be crushed into: ");


        }

        private static void Crusher(int money, Dictionary<string, int> Combination)
        {
            foreach (var item in Combination)
            {
                if (item.Key == "$100" && money > 100)
                {
                    moneyCounts["$100"] += money / 100;
                    money %= 100;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$50" && money > 50)
                {
                    moneyCounts["$50"] += money / 50;
                    money %= 50;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$20" && money > 20)
                {
                    moneyCounts["$20"] += money / 20;
                    money %= 20;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$10" && money > 10)
                {
                    moneyCounts["$10"] += money / 10;
                    money %= 10;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$5" && money > 5)
                {
                    moneyCounts["$5"] += money / 5;
                    money %= 5;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$2" && money > 2)
                {
                    moneyCounts["$2"] += money / 2;
                    money %= 2;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
                if (item.Key == "$1" && money > 1)
                {
                    moneyCounts["$1"] += money / 1;
                    money %= 1;

                    if (money != 0)
                    {
                        OtherCrushes(money);
                    }
                }
            }
        }

        private static void OtherCrushes(int money)
        {
            // Each if / else if condition checks if the remaining money is greater than each denomination
            // If it is greater than a denomination, it will be divided by it. The result would be the count of that denomination
            // The remainder of the division would be the remaining money
            // If it is not divisible it goes to the next condition
            if (money >= 100)
            {
                moneyCounts["$100"] += money / 100;
                money %= 100;
            }
            else if (money >= 50)
            {
                moneyCounts["$50"] += money / 50;
                money %= 50;
            }
            else if (money >= 20)
            {
                moneyCounts["$20"] += money / 20;
                money %= 20;
            }
            else if (money >= 10)
            {
                moneyCounts["$10"] += money / 10;
                money %= 10;
            }
            else if (money >= 5)
            {
                moneyCounts["$5"] += money / 5;
                money %= 5;
            }
            else if (money >= 2)
            {
                moneyCounts["$2"] += money / 2;
                money %= 2;
            }
            else
            {
                moneyCounts["$1"] += money;
                money = 0;
            }
        }

        // Function: prints each denomination and its count. If it is not zero, it will be printed in green color, else, yellow
        private static void PrintWithColor(int number, string denomination)
        {
            if (number != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{number} × {denomination}");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.WriteLine($"{number} × {denomination}");
            }
        }
    }
}