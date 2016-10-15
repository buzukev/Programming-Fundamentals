using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class AverageGrades
{
    static void Main(string[] args)
    {
        string[] intput = File.ReadAllLines("input.txt");

        List<Student> students = new List<Student>();

        int studentCount = int.Parse(intput[0]);

        for (int i = 0; i < studentCount; i++)
        {
            string[] commandArgs = intput[i + 1 ].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = commandArgs[0];
            List<double> grades = commandArgs.Skip(1).Select(x => double.Parse(x)).ToList();

            Student student = new Student(name);
            student.Grades.AddRange(grades);
            students.Add(student);
        }

        var orderedStudent = students.Where(x => x.Grades.Average()>=5).OrderBy(x => x.Name).ThenByDescending(x => x.Grades.Average());

        foreach (var student in orderedStudent)
        {
            File.AppendAllText("output.txt", string.Format($"{student.Name} -> {student.Grades.Average():f2}" + Environment.NewLine));
        }
    }
}

class Student
{
    public Student(string name)
    {
        this.Name = name;
        this.Grades = new List<double>();
    }

    public string Name { get; set; }
    public List<double> Grades { get; set; }
}