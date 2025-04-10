#  Factorial Calculator in C#

This is a beginner-level **C# Console Application** that calculates the factorial of a positive integer entered by the user.

---

##  Features

- Accepts user input via the console
- Validates the input to ensure it's a non-negative integer
- Uses a loop to calculate the factorial
- Outputs the result in a user-friendly format
- Demonstrates basic and essential C# concepts

---

## 🗂️ Folder Structure

```
C#/
└── Task1/
    └── Program.cs
```

---

##  What You’ll Learn

|  Concept |  Description |
|-----------|----------------|
| `namespace` | Organizes classes and avoids naming conflicts |
| `class` | The building block of object-oriented programming |
| `static void Main(string[] args)` | Entry point of the program |
| `Console.ReadLine()` | Reads user input as a string |
| `string?` | Nullable reference type (C# 8.0+) to handle null input safely |
| `int.TryParse()` | Safely parses a string to an integer |
| `for` loop | Used to repeatedly multiply numbers up to the input |
| `Console.WriteLine()` | Displays output to the console |
| String Interpolation `$""` | Embeds variables in strings easily |
| Nullable Safety `?` | Helps avoid runtime errors due to null values |

---

## 📋 Code Example

```csharp
using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
                return;
            }

            int factorial = 1;
            for(int i=number;i>= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }
}
```

---

##  Sample Output

```
Enter a number to calculate its factorial:
5
The factorial of 5 is 120.
```

---

##  How to Run

### Option 1: Using Visual Studio
1. Open Visual Studio
2. Create a new **Console Application** project
3. Replace `Program.cs` with the code above
4. Click **Run** or press `Ctrl + F5`

### Option 2: Using .NET CLI
> Make sure .NET SDK is installed  
> Check it using: `dotnet --version`

```bash
mkdir Task1
cd Task1
dotnet new console
# Replace Program.cs content with the factorial code
dotnet run
```

---

##  Additional Notes

-  **Input Validation:** The use of `int.TryParse()` ensures the app doesn't crash on invalid input
-  **Null Safety:** The `string?` ensures that null values are handled gracefully
-  **Code Readability:** String interpolation makes the output clear and modern

