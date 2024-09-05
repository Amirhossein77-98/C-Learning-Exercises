namespace Homework
{
    internal class Matrix
    {
        public static void Main(string[] args)
        {
            Human human = new Human();
            Console.Write("What is your first name? ");
            human.firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            human.lastName = Console.ReadLine();
            Console.Write("How old are you? ");
            human.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: {human.firstName} {human.lastName}, Age: {human.age}");
        }

        public class Human
        {
            public string firstName;
            public string lastName;
            public int age;
        }
    }
}