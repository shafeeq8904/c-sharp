using System;
using System.Collections.Generic;
using System.Linq;
using StudentManagement;

namespace StudentManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating list of students
            List<Student> students = new List<Student>
            {
                new Student("shafeeq", 90, 20),
                new Student("harish", 85, 22),
                new Student("wasim", 95, 21),
                new Student("sadiq", 58, 23),
                new Student("krithick", 48, 23),
            };

            double threshold = 75.0;

            // 1. Where() and OrderByDescending()
            var filteredSortedStudents = students
                .Where(s => s.Grade > threshold)
                .OrderByDescending(s => s.Grade);

            Console.WriteLine($"\nStudents with grade above {threshold} (sorted by grade):");
            foreach (var student in filteredSortedStudents)
            {
                Console.WriteLine($"{student.Name}, {student.Grade}, {student.Age}");
            }

            // 2. OrderBy() by Name
            var sortedByName = students.OrderBy(s => s.Name);
            Console.WriteLine("\nStudents sorted by name:");
            foreach (var student in sortedByName)
            {
                Console.WriteLine($"{student.Name}, {student.Grade}, {student.Age}");
            }

            // 3. Select() - Extract only Names
            var studentNames = students.Select(s => s.Name);
            Console.WriteLine("\nOnly student names:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            // 4. Count() - How many scored above 80
            int countAbove80 = students.Count(s => s.Grade > 80);
            Console.WriteLine($"Number of students with grade > 80: {countAbove80}");
        }
            
    }
}
