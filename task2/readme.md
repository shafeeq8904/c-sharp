#  Task 2: Simple Object-Oriented Programming in C#

This project demonstrates the basics of **Object-Oriented Programming (OOP)** in C# by defining and using a `Person` class. The program collects user input to create instances of `Person` and allows them to introduce themselves using a method.

---

##  Concepts Learned

-  Create a `Person` class with properties (`Name`, `Age`)
-  Take user input using `Console.ReadLine()`
-  Instantiate multiple `Person` objects
-  Use the `Introduce()` method to print personalized greetings
-  Demonstrates fundamental concepts: **Classes**, **Objects**, **Constructors**, and **Nullable types**

---


---

##  Concepts Explained

```csharp
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
        // Create and read input for first person
        Person p1 = new Person();
        Console.WriteLine("Enter name for Person 1:");
        p1.name = Console.ReadLine();

        Console.WriteLine("Enter age for Person 1:");
        while (!int.TryParse(Console.ReadLine(), out p1.age) || p1.age < 0)
        {
            Console.WriteLine("Please enter a valid positive integer for age:");
        }
        p1.introduce();

        // Repeat for second person
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

```

### Class
A **class** is a blueprint for creating objects. It defines properties (data) and methods (behavior).
```csharp
class Person
{
    public string? name;
    public int age;
}
```

###  Object
An **object** is an instance of a class. You create and use it like this:
```csharp
Person p1 = new Person();
```

### Nullable Types

- C# warns about null values for non-nullable types. Use ? to make a type nullable.
```csharp
public string? name; // means name can be null
```

### Method
A method is a function defined inside a class.

```csharp
public void introduce() { ... }
```

### Constructor
A **constructor** is a special method that runs when an object is created. It's used to initialize the object.

```csharp
public Person(string name, int age)
{
    this.name = name;
    this.age = age;
}
```

## Output

```
Enter name for Person 1:
shafeeq
Enter age for Person 1:
21
Hello, my name is shafeeq and I am 21 years old.
...
```


