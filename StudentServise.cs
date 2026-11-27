using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

public class StudentService : IStudentServise
{
    List<Student> students = [];

    public object Grades { get; private set; }
    public object Id { get; private set; }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void Dalete(int Id)
    {
        students.RemoveAt(Id - 1);
    }

    public double GetAvg(int id)
    {
        foreach (var item in students)
        {
            if (id == item.Id)
            {
                double sum = 0;
                for (int i = 0; i < item.Grades.Length; i++)
                {
                    sum += item.Grades[i];
                }
                return sum / item.Grades.Length;
            }
        }
        return 0;
    }

    public void GetSudent()
    {
        foreach (var item in students)
        {
            System.Console.WriteLine($"ID:{item.Id}");
            System.Console.WriteLine($"Name:{item.Name}");
            System.Console.WriteLine($"Age: {item.Age}");
            System.Console.WriteLine($"Adress: {item.Adress}");
            System.Console.WriteLine($"Average of student: {GetAvg(item.Id)}");
        }
    }

    public void UpDate(Student id)
    {
        foreach (var item in students)
        {
            if (id.Id == item.Id)
            {
                item.Name = id.Name;
                item.Age = id.Age;
                item.Adress = id.Adress;
                item.Grades = id.Grades;
            }
        }
    }
}