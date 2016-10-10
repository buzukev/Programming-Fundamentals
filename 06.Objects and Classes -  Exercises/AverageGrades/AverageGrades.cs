using System;
using System.Collections.Generic;
using System.Linq;


public class AverageGrades
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Student> list = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> grades = input.Skip(1).Select(double.Parse).ToList();
            list.Add(new Student(input[0], grades));

        }
        list = list.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

        foreach (var student in list)
        {
            if (student.AverageGrade >= 5.00)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade { get; set; }

    public Student(string name, List<double> grades)
    {
        this.Name = name;
        this.Grades = grades;
        this.AverageGrade = grades.Average();
    }
}