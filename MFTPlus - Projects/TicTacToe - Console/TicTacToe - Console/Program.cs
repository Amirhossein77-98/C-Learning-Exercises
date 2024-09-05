using System.Numerics;
using System.Security;

namespace TicTacToeProject
{
    internal class TicTacToe
    {
        // Initializing the parameters
        const string userSymbol = "X";
        const string AISymbol = "O";
        private static int roundsCount = 0;
        private static int userWinsCount = 0;
        private static int AIWinsCount = 0;

        // Initializing a dictionary to hold the rooms and their values
        static readonly Dictionary<string, string> rooms = new Dictionary<string, string>();

        // Initializing a list to hold the enable rooms
        static List<string> availableRooms = new List<string>();

        // Initializing a random object in order to use for the CPU room selection
        static readonly Random random = new();

        private static void Main(string[] args)
        {
            // Initializing the rooms and their values at launch
            Initializer();

            // Starting the game loop
            while (true)
            {
                //Generating the UI
                BoardGen();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                ColorSetter("Question");
                Console.Write("What room you want to cross (q: quit)? ");
                string userChoice = Console.ReadLine()!;
                Console.ResetColor();

                // Checking the user input and reacting to it properly (only changing the rooms that are not chosen already)
                if (userChoice == "1" && rooms["room1"] == "1")
                {
                    // assigning the value to the room and making it unavailable for future selection
                    rooms["room1"] = userSymbol;
                    availableRooms.Remove("room1");
                }
                else if (userChoice == "2" && rooms["room2"] == "2")
                {
                    rooms["room2"] = userSymbol;
                    availableRooms.Remove("room2");
                }
                else if (userChoice == "3" && rooms["room3"] == "3")
                {
                    rooms["room3"] = userSymbol;
                    availableRooms.Remove("room3");
                }
                else if (userChoice == "4" && rooms["room4"] == "4")
                {
                    rooms["room4"] = userSymbol;
                    availableRooms.Remove("room4");
                }
                else if (userChoice == "5" && rooms["room5"] == "5")
                {
                    rooms["room5"] = userSymbol;
                    availableRooms.Remove("room5");
                }
                else if (userChoice == "6" && rooms["room6"] == "6")
                {
                    rooms["room6"] = userSymbol;
                    availableRooms.Remove("room6");
                }
                else if (userChoice == "7" && rooms["room7"] == "7")
                {
                    rooms["room7"] = userSymbol;
                    availableRooms.Remove("room7");
                }
                else if (userChoice == "8" && rooms["room8"] == "8")
                {
                    rooms["room8"] = userSymbol;
                    availableRooms.Remove("room8");
                }
                else if (userChoice == "9" && rooms["room9"] == "9")
                {
                    rooms["room9"] = userSymbol;
                    availableRooms.Remove("room9");
                }

                // Handling the quit logic
                else if (userChoice == "q")
                {
                    Console.WriteLine();
                    QuitMessage();
                    break;
                }

                // Handling invalid inputs, if invalid, asks for the input again
                else
                {
                    Console.WriteLine("Invalid Choice! Please select between available rooms!\n\nEnter any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                // Checking if the user wins (if yes, do some operations and then go to the next round)
                if (winnerCheck())
                {
                    WinCondition("User");
                    continue;
                }

                // Checking if the game is Draw after the user's move (if yes, do some operations and then go to the next round)
                if (DrawCheck())
                {
                    DrawCondition();
                    continue;
                }

                // Launching CPU's turn
                int index = random.Next(availableRooms.Count);
                rooms[availableRooms[index]] = AISymbol;
                availableRooms.Remove(availableRooms[index]);

                // Checking if the CPU wins (if yes, do some operations and then go to the next round)
                if (winnerCheck())
                {
                    WinCondition("AI");
                    continue;
                }

                // Checking if the game is Draw after the user's move (if yes, do some operations and then go to the next round)
                if (DrawCheck())
                {
                    DrawCondition();
                    continue;
                }
            }
        }

        // Rooms initializer
        private static void Initializer()
        {
            for (int i = 1; i <= 9; i++)
            {
                rooms[$"room{i}"] = $"{i}";
            }
            availableRooms = ["room1", "room2", "room3", "room4", "room5", "room6", "room7", "room8", "room9",];
        }

        // Designer: Setting colors to make the game more eye-catching
        private static void ColorSetter(string value)
        {
            if (value == userSymbol || value == "User")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (value == AISymbol || value == "AI")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (value == "Round")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (value == "Question")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }

        // Game Board Generator
        private static void BoardGen()
        {
            // Refreshing the console
            Console.Clear();

            // Showing game stats
            ColorSetter("Round");
            Console.Write($"Round: {roundsCount}");
            Console.ResetColor();
            Console.Write(" | ");

            ColorSetter("User");
            Console.Write($"User Wins: {userWinsCount}");
            Console.ResetColor();
            Console.Write(" | ");

            ColorSetter("AI");
            Console.Write($"AI Wins: {AIWinsCount}");
            Console.ResetColor();

            // Blank for separation of the parts
            Console.WriteLine("\n\n");

            // Generating the board's lines and visualizing each room's value
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (RowSeparatorLineCheck(i) || RowSeparatorLineCheck(i))
                    {
                        if (j == 7 || j == 15)
                        {
                            Console.Write('+');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }
                    else if (j == 7 || j == 15)
                    {
                        Console.Write("|");
                    }
                    else if (i == 1 && j == 3)
                    {
                        ColorSetter(rooms["room1"]);
                        Console.Write(rooms["room1"]);
                        Console.ResetColor();
                    }
                    else if (i == 1 && j == 11)
                    {
                        ColorSetter(rooms["room2"]);
                        Console.Write(rooms["room2"]);
                        Console.ResetColor();
                    }
                    else if (i == 1 && j == 19)
                    {
                        ColorSetter(rooms["room3"]);
                        Console.Write(rooms["room3"]);
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 3)
                    {
                        ColorSetter(rooms["room4"]);
                        Console.Write(rooms["room4"]);
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 11)
                    {
                        ColorSetter(rooms["room5"]);
                        Console.Write(rooms["room5"]);
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 19)
                    {
                        ColorSetter(rooms["room6"]);
                        Console.Write(rooms["room6"]);
                        Console.ResetColor();
                    }
                    else if (i == 9 && j == 3)
                    {
                        ColorSetter(rooms["room7"]);
                        Console.Write(rooms["room7"]);
                        Console.ResetColor();
                    }
                    else if (i == 9 && j == 11)
                    {
                        ColorSetter(rooms["room8"]);
                        Console.Write(rooms["room8"]);
                        Console.ResetColor();
                    }
                    else if (i == 9 && j == 19)
                    {
                        ColorSetter(rooms["room9"]);
                        Console.Write(rooms["room9"]);
                        Console.ResetColor();
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            // Checks for the positions that the lines should be drawn
            static bool RowSeparatorLineCheck(int index)
            {
                if (index <= 2 || index == 5) return false;
                for (int i = 2; i * i <= index; i++)
                {
                    if (index % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        // Winner checker caller (separated for re-usability and readability)
        private static bool winnerCheck()
        {
            return (winnerChecker(userSymbol) || winnerChecker(AISymbol));
        }

        // Winner checking logic (Checks row-wise, column-wise, and diagonally for 3 same symbols in a row)
        private static bool winnerChecker(string symbol)
        {
            if (rooms["room1"] == symbol && rooms["room2"] == symbol && rooms["room3"] == symbol
                || rooms["room4"] == symbol && rooms["room5"] == symbol && rooms["room6"] == symbol
                || rooms["room7"] == symbol && rooms["room8"] == symbol && rooms["room9"] == symbol
                || rooms["room1"] == symbol && rooms["room4"] == symbol && rooms["room7"] == symbol
                || rooms["room2"] == symbol && rooms["room5"] == symbol && rooms["room8"] == symbol
                || rooms["room3"] == symbol && rooms["room6"] == symbol && rooms["room9"] == symbol
                || rooms["room1"] == symbol && rooms["room5"] == symbol && rooms["room9"] == symbol
                || rooms["room3"] == symbol && rooms["room5"] == symbol && rooms["room7"] == symbol)
            {
                return true;
            }
            return false;
        }

        // Operations to do when someone wins
        private static void WinCondition(string winner)
        {

            // Incrementing the winner's win counts
            if (winner == "User")
            {
                userWinsCount++;
            }
            else
            {
                AIWinsCount++;
            }

            // Incrementing rounds
            roundsCount++;

            // Regenerating the board with the latest result
            Console.Clear();
            BoardGen();

            // Separating the board from the below messages
            Console.WriteLine("\n\n");

            // Setting the appropriate text color for the winner (Green for the user and Red for the AI)
            if (winner == "User")
            {
                ColorSetter("User");
            }
            else
            {
                ColorSetter("AI");
            }

            // Announcing the winner
            Console.WriteLine($"{winner} Wins!");
            // Reseting console text color to its default color 
            Console.ResetColor();

            // Making a wait function in order the user can see the result befor going to the next round
            Console.WriteLine("\nEnter any key to continue to the next round...");
            Console.ReadKey();

            // Re initializing the board and rooms and their values
            Initializer();
        }

        // Draw Checker
        private static bool DrawCheck()
        {
            if (availableRooms.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Operations to do when the game draws
        private static void DrawCondition()
        {
            // Incrementing the round
            roundsCount++;

            // Refreshing the console with the latest results
            Console.Clear();
            BoardGen();

            // Separating the board from the below messages
            Console.WriteLine("\n\n");

            // Setting a color to show the Tie message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tie!");
            Console.ResetColor();

            // Making a wait for the user to see the results before the next round
            Console.WriteLine("\nEnter any key to continue to the next round...");
            Console.ReadKey();

            // Re initializing the board and rooms and their values
            Initializer();
        }

        // Generating and displaying a message when the user wants to quit
        // There are a lot of Console.Write's in order to make the final text colorful.
        private static void QuitMessage()
        {
            Console.Write($"OK! You've played ");
            ColorSetter("Round");
            Console.Write(roundsCount);
            Console.ResetColor();
            Console.Write(" times and you won ");
            ColorSetter("User");
            Console.Write(userWinsCount);
            Console.ResetColor();
            Console.Write(" times. You lost ");
            ColorSetter("AI");
            Console.Write(AIWinsCount);
            Console.ResetColor();
            Console.Write(" times. Plus you had ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(roundsCount - (userWinsCount + AIWinsCount));
            Console.ResetColor();
            Console.Write(" Ties.");
            Console.WriteLine();
            Console.WriteLine();
            ColorSetter("Question");
            Console.WriteLine("Have a good Time!");
            Console.ResetColor();

        }

    }
}