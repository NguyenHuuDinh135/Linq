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
        // Danh sách số cho phần 1 và một số bài nâng cao
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Danh sách sinh viên cho phần 2
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 }
        };

        // Danh sách số có trùng cho bài 15 và 19
        List<int> numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        Console.WriteLine("PHẦN 1 – LINQ CƠ BẢN (1–7)");
        Console.WriteLine();

        // Bài 1. Lọc số chẵn
        Console.WriteLine("Bài 1. Lọc số chẵn:");
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Các số chẵn: " + string.Join(", ", evenNumbers));
        Console.WriteLine();

        // Bài 2. Lọc số lớn hơn 5
        Console.WriteLine("Bài 2. Lọc số lớn hơn 5:");
        var numbersGreaterThan5 = numbers.Where(n => n > 5);
        Console.WriteLine("Các số > 5: " + string.Join(", ", numbersGreaterThan5));
        Console.WriteLine();

        // Bài 3. Sắp xếp tăng dần
        Console.WriteLine("Bài 3. Sắp xếp tăng dần:");
        var sortedAscending = numbers.OrderBy(n => n);
        Console.WriteLine("Sắp xếp tăng dần: " + string.Join(", ", sortedAscending));
        Console.WriteLine();

        // Bài 4. Sắp xếp giảm dần
        Console.WriteLine("Bài 4. Sắp xếp giảm dần:");
        var sortedDescending = numbers.OrderByDescending(n => n);
        Console.WriteLine("Sắp xếp giảm dần: " + string.Join(", ", sortedDescending));
        Console.WriteLine();

        // Bài 5. Bình phương các số
        Console.WriteLine("Bài 5. Bình phương các số:");
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Bình phương: " + string.Join(", ", squaredNumbers));
        Console.WriteLine();

        // Bài 6. Đếm số chẵn
        Console.WriteLine("Bài 6. Đếm số chẵn:");
        var evenCount = numbers.Count(n => n % 2 == 0);
        Console.WriteLine("Số lượng số chẵn: " + evenCount);
        Console.WriteLine();

        // Bài 7. Kiểm tra có số lớn hơn 10 không
        Console.WriteLine("Bài 7. Kiểm tra có số lớn hơn 10 không:");
        var hasNumberGreaterThan10 = numbers.Any(n => n > 10);
        Console.WriteLine("Có số > 10: " + hasNumberGreaterThan10);
        Console.WriteLine();

        Console.WriteLine("PHẦN 2 – LINQ VỚI OBJECT (8–14)");
        Console.WriteLine();

        // Bài 8. Lọc sinh viên điểm >= 8
        Console.WriteLine("Bài 8. Lọc sinh viên điểm >= 8:");
        var excellentStudents = students.Where(s => s.Score >= 8);
        foreach (var student in excellentStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
        }
        Console.WriteLine();

        // Bài 9. Lấy danh sách tên sinh viên
        Console.WriteLine("Bài 9. Lấy danh sách tên sinh viên:");
        var studentNames = students.Select(s => s.Name);
        Console.WriteLine("Tên sinh viên: " + string.Join(" ", studentNames));
        Console.WriteLine();

        // Bài 10. Sắp xếp theo điểm
        Console.WriteLine("Bài 10. Sắp xếp theo điểm giảm dần:");
        var studentsSortedByScore = students.OrderByDescending(s => s.Score);
        foreach (var student in studentsSortedByScore)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
        }
        Console.WriteLine();

        // Bài 11. Lấy sinh viên điểm cao nhất
        Console.WriteLine("Bài 11. Lấy sinh viên điểm cao nhất:");
        var highestScoreStudent = students.OrderByDescending(s => s.Score).FirstOrDefault();
        if (highestScoreStudent != null)
        {
            Console.WriteLine($"Id: {highestScoreStudent.Id}, Name: {highestScoreStudent.Name}, Score: {highestScoreStudent.Score}");
        }
        Console.WriteLine();

        // Bài 12. Đếm số sinh viên đạt
        Console.WriteLine("Bài 12. Đếm số sinh viên đạt (Score >= 7):");
        var passingStudentsCount = students.Count(s => s.Score >= 7);
        Console.WriteLine("Số sinh viên đạt: " + passingStudentsCount);
        Console.WriteLine();

        // Bài 13. Lấy sinh viên đầu tiên có điểm > 7
        Console.WriteLine("Bài 13. Lấy sinh viên đầu tiên có điểm > 7:");
        var firstStudentAbove7 = students.FirstOrDefault(s => s.Score > 7);
        if (firstStudentAbove7 != null)
        {
            Console.WriteLine($"Id: {firstStudentAbove7.Id}, Name: {firstStudentAbove7.Name}, Score: {firstStudentAbove7.Score}");
        }
        Console.WriteLine();

        // Bài 14. Kiểm tra có sinh viên rớt không
        Console.WriteLine("Bài 14. Kiểm tra có sinh viên rớt không (Score < 5):");
        var hasFailingStudent = students.Any(s => s.Score < 5);
        Console.WriteLine("Có sinh viên rớt: " + hasFailingStudent);
        Console.WriteLine();

        Console.WriteLine("PHẦN 3 – LINQ NÂNG CAO (15–20)");
        Console.WriteLine();

        // Bài 15. Loại bỏ phần tử trùng
        Console.WriteLine("Bài 15. Loại bỏ phần tử trùng:");
        var distinctNumbers = numbersWithDuplicates.Distinct();
        Console.WriteLine("Số không trùng: " + string.Join(", ", distinctNumbers));
        Console.WriteLine();

        // Bài 16. Tính tổng
        Console.WriteLine("Bài 16. Tính tổng:");
        var sum = numbers.Sum();
        Console.WriteLine("Tổng: " + sum);
        Console.WriteLine();

        // Bài 17. Tính trung bình
        Console.WriteLine("Bài 17. Tính trung bình điểm sinh viên:");
        var averageScore = students.Average(s => s.Score);
        Console.WriteLine("Điểm trung bình: " + averageScore);
        Console.WriteLine();

        // Bài 18. Nhóm sinh viên theo xếp loại
        Console.WriteLine("Bài 18. Nhóm sinh viên theo xếp loại:");
        var groupedStudents = students.GroupBy(s =>
        {
            if (s.Score >= 8) return "Giỏi";
            else if (s.Score >= 6) return "Khá";
            else return "Trung bình";
        });
        foreach (var group in groupedStudents)
        {
            Console.WriteLine($"Xếp loại: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"  Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
            }
        }
        Console.WriteLine();

        // Bài 19. Tìm số xuất hiện nhiều nhất
        Console.WriteLine("Bài 19. Tìm số xuất hiện nhiều nhất:");
        var mostFrequentNumber = numbersWithDuplicates
            .GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault()?.Key;
        Console.WriteLine("Số xuất hiện nhiều nhất: " + mostFrequentNumber);
        Console.WriteLine();

        // Bài 20. Top 3 sinh viên điểm cao nhất
        Console.WriteLine("Bài 20. Top 3 sinh viên điểm cao nhất:");
        var top3Students = students.OrderByDescending(s => s.Score).Take(3);
        foreach (var student in top3Students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
        }
        Console.WriteLine();

        // Thông tin sinh viên
        Console.WriteLine("Mã sinh viên: 23115053122305");
        Console.WriteLine("Tên: Nguyễn Hữu Định");
        Console.WriteLine("Lớp: 225LTC#01");
    }
}
