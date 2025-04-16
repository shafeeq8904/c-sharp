using System;

class Program
{
    static void Main()
    {
        Items item = new Items();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    Console.Write("Enter item to add: ");
                    string addItem = Console.ReadLine().Trim();
                    item.AddItem(addItem);
                    break;

                case "2":
                    Console.Write("Enter item to remove: ");
                    string removeItem = Console.ReadLine().Trim();
                    item.RemoveItem(removeItem);
                    break;

                case "3":
                    item.DisplayItems();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
