using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"D:\SimpliLearn Course\Day13\Practice Project\students.txt.txt";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Create a list to store student objects
            var students = new List<Student>();

            foreach (string line in lines.Skip(1)) // Skip the header line
            {
                string[] data = line.Split(',');
                int studentID = int.Parse(data[0]);
                string name = data[1];
                string className = data[2];
                string section = data[3];

                // Create a new Student object and add it to the list
                var student = new Student(studentID, name, className, section);
                students.Add(student);
            }

            // Display the data
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.StudentID}, Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found. Make sure the 'students.txt' file exists in the project directory.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
