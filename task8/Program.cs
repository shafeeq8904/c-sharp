using System;

class Program
{
    static void Main()
    {
        IRepository<Student> repository = new InMemoryRepository<Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Add Student\n2. View Student\n3. Update Student\n4. Delete Student\n5. View All Students\n6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    repository.Add(new Student { Id = id, Name = name });
                    break;

                case "2":
                    Console.Write("Enter ID to view: ");
                    int viewId = int.Parse(Console.ReadLine());
                    var Student = repository.Get(viewId);
                    Console.WriteLine(Student != null ? $"ID: {Student.Id}, Name: {Student.Name}" : "Student not found.");
                    break;

                case "3":
                    Console.Write("Enter ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Name: ");
                    string newName = Console.ReadLine();
                    repository.Update(new Student { Id = updateId, Name = newName });
                    break;

                case "4":
                    Console.Write("Enter ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    repository.Delete(deleteId);
                    break;

                case "5":
                    var Students = repository.GetAll();
                    foreach (var p in Students)
                    {
                        Console.WriteLine($"ID: {p.Id}, Name: {p.Name}");
                    }
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
