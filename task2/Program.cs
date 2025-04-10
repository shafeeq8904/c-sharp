using System;

namespace Task2
{
    class Person 
    {
        public string? name;
        public int age;

        public void introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter name for Person 1:");
            p1.name = Console.ReadLine();

            Console.WriteLine("Enter age for Person 1:");
            if (!int.TryParse(Console.ReadLine(), out p1.age) || p1.age < 0)
            {
                Console.WriteLine("Please enter a valid positive integer for age:");
            }
            p1.introduce();

            Person p2 = new Person();
            Console.WriteLine("Enter name for Person 2:");
            p2.name = Console.ReadLine();

            Console.WriteLine("Enter age for Person 2:");
            while (!int.TryParse(Console.ReadLine(), out p2.age) || p2.age < 0)
            {
                Console.WriteLine("Please enter a valid positive integer for age:");
            }

            p2.introduce();
        }
    }
}
