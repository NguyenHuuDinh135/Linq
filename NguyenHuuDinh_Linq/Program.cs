// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Bài 1. Lọc số chẵn
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Các số chẵn: " + string.Join(", ", evenNumbers));

        // Bài 2. Lọc số lớn hơn 5
        var numbersGreaterThan5 = numbers.Where(n => n > 5);
        Console.WriteLine("Các số > 5: " + string.Join(", ", numbersGreaterThan5));

        // Bài 3. Sắp xếp tăng dần
        var sortedAscending = numbers.OrderBy(n => n);
        Console.WriteLine("Sắp xếp tăng dần: " + string.Join(", ", sortedAscending));

        // Bài 4. Sắp xếp giảm dần
        var sortedDescending = numbers.OrderByDescending(n => n);
        Console.WriteLine("Sắp xếp giảm dần: " + string.Join(", ", sortedDescending));

        // Bài 5. Bình phương các số
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Bình phương: " + string.Join(", ", squaredNumbers));

        // Bài 6. Đếm số chẵn
        var evenCount = numbers.Count(n => n % 2 == 0);
        Console.WriteLine("Số lượng số chẵn: " + evenCount);

        // Bài 7. Kiểm tra có số lớn hơn 10 không
        var hasNumberGreaterThan10 = numbers.Any(n => n > 10);
        Console.WriteLine("Có số > 10: " + hasNumberGreaterThan10);

        // Danh sách sinh viên
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 }
        };

        // Bài 8. Lọc sinh viên điểm >= 8
        var excellentStudents = students.Where(s => s.Score >= 8);
        Console.WriteLine("Sinh viên giỏi:");
        foreach (var student in excellentStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
        }

        // Bài 9. Lấy danh sách tên sinh viên
        var studentNames = students.Select(s => s.Name);
        Console.WriteLine("Tên sinh viên: " + string.Join(" ", studentNames));
    }
}
