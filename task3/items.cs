using System;
using System.Collections.Generic;

public class Items
{
    public List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
        Console.WriteLine($"'{item}' added.");
    }

    public void RemoveItem(string item)
    {
        if (items.Remove(item))
        {
            Console.WriteLine($"'{item}' removed.");
        }
        else
        {
            Console.WriteLine($"'{item}' not found.");
        }
    }

    public void DisplayItems()
    {
        Console.WriteLine("\nCurrent Items:");
        if (items.Count == 0)
        {
            Console.WriteLine("No items in the list.");
        }
        else
        {
            foreach (string item in items)
            {
                Console.WriteLine("- " + item.ToUpper());
            }
        }
    }
}
