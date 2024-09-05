using System;

namespace Contacts
{
    internal class Contacts
    {
        static void Main(string[] args)
        {
            Console.Write("How many contacts do you want to add? ");
            int contactsCount = Convert.ToInt32(Console.ReadLine());

            string[][] contacts = new string[contactsCount][];

            for (int i = 0; i < contactsCount; i++)
            {
                string?[] tempContact = new string?[4];

                Console.Write($"{i + 1}. Enter the name of the contact: ");
                tempContact[0] = Console.ReadLine();

                Console.Write($"{i + 1}. Enter the phone number of {((tempContact[0] == "") ? "the contact" : tempContact[0])}: ");
                tempContact[1] = Console.ReadLine();

                Console.Write($"{i + 1}. Enter the Email address of {((tempContact[0] == "") ? "the contact" : tempContact[0])}: ");
                tempContact[2] = Console.ReadLine();

                Console.Write($"{i + 1}. Enter the address of {((tempContact[0] == "") ? "the contact" : tempContact[0])}: ");
                tempContact[3] = Console.ReadLine();

                int numberOfInformationEntered = 0;

                for (int j = 0; j < tempContact.Length; j++)
                {
                    if (tempContact[j] == "")
                    {
                        numberOfInformationEntered++;
                    }
                }

                contacts[i] = new string[numberOfInformationEntered];

                int currentIndex = 0;
                for (int j = 0; j < tempContact.Length; j++)
                {
                    if (tempContact[j] == "")
                    {
                        contacts[i][currentIndex] = tempContact[j];
                        currentIndex++;
                    }
                }
            }

            for (int i = 0; i < contacts.Length; i++)
            {
                Console.WriteLine($"\nContact {i + 1}:");
                for (int j = 0; j < contacts[i].Length; j++)
                {
                    Console.WriteLine(contacts[i][j]);
                }
            }
        }
    }
}
