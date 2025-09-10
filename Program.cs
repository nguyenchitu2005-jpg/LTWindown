using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Trung", Age = 15 },
            new Student { Id = 2, Name = "Dung", Age = 21 },
            new Student { Id = 3, Name = "Linh", Age = 18 },
            new Student { Id = 4, Name = "An", Age = 20 },
            new Student { Id = 5, Name = "Minh", Age = 17 }
        };
        //a,in ds ra man hinh
        Console.WriteLine("Danh sach hoc sinh: ");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        //b, tim va in ds hs co tuoi 15-18
        Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:\n ");
        var studentsage15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in studentsage15to18)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");

        }
        //c,tim va in ra ten hs bat dau bang chu 'A'
        Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu 'A':\n ");
        var studentsnameA = students.Where(s => s.Name.StartsWith("A"));
        foreach (var student in studentsnameA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        //d, tinh tong tuoi cua tat ca hoc sinh trong danh sach
        int sumage = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca cac hoc sinh trong danh sach la: {sumage}\n");
        //e, Tim va in ra hoc sinh co tuoi lon nhat
        int agemax = students.Max(s => s.Age);
        var agemaxstudents = students.Where(s => s.Age == agemax);
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat trong danh sach la:\n");
        foreach (var student in agemaxstudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        //f, sap xep ds hs theo tuoi tang dan va in ra sau khi sap xep
        Console.WriteLine("\nDanh sach sau hoc sinh sau khi sap xep do tuoi tang dan:\n");
        var sapxepstudents = students.OrderBy(s => s.Age);
        foreach (var student in sapxepstudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}