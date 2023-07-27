using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public string Section { get; set; }

    public Student(int studentID, string name, string className, string section)
    {
        StudentID = studentID;
        Name = name;
        Class = className;
        Section = section;
    }
}
