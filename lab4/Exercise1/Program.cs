using System;

public class Person
{
    public string Name { get; set; }

    public Person()
    {
        Name = null;
    }

    public Person(string name)
    {
        Name = name;
    }
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public string Program { get; set; }

    public Student() : base()
    {
        RegNo = null;
        Age = 0;
        Program = null;
    }

    public Student(string name, string regNo, int age, string program) : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        Student student2 = new Student("John", "BSCS123", 20, "Computer Science");

        student1.Name = "Alice";
        student1.RegNo = "BSIT456";
        student1.Age = 21;
        student1.Program = "Information Technology";

        Console.WriteLine($"Student 1: Name = {student1.Name}, RegNo = {student1.RegNo}, Age = {student1.Age}, Program = {student1.Program}");
        Console.WriteLine($"Student 2: Name = {student2.Name}, RegNo = {student2.RegNo}, Age = {student2.Age}, Program = {student2.Program}");
    }
}

