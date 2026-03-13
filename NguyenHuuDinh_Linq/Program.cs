using System;
using System.Collections.Generic;
using System.Linq;

namespace NguyenHuuDinh_Linq
{
    internal class Program
    {
        // Thông tin sinh viên hiển thị ở đầu chương trình
        private const string StudentInfo = "Mã sinh viên: 23115053122305  Tên: Nguyễn Hữu Định  Lớp: 225LTC#01";

        static void Main(string[] args)
        {
            // Vòng lặp chính để hiện menu liên tục
            while (true)
            {
                Console.Clear();
                Console.WriteLine(StudentInfo);
                Console.WriteLine();
                Console.WriteLine("=== LINQ Exercises Menu ===");
                Console.WriteLine("1. Exercise 1 - Lọc số chẵn (từ danh sách 1-8)");
                Console.WriteLine("2. Exercise 2 - Filter numbers >5");
                Console.WriteLine("3. Exercise 3 - Sort ascending");
                Console.WriteLine("4. Exercise 4 - Sort descending");
                Console.WriteLine("5. Exercise 5 - Square numbers");
                Console.WriteLine("6. Exercise 6 - Count even numbers");
                Console.WriteLine("7. Exercise 7 - Any >10 check");
                Console.WriteLine("8. Exercise 8 - Filter students score>=8");
                Console.WriteLine("9. Exercise 9 - List student names");
                Console.WriteLine("10. Exercise 10 - Sort students by score desc");
                Console.WriteLine("11. Exercise 11 - Student with highest score");
                Console.WriteLine("12. Exercise 12 - Count students score>=7");
                Console.WriteLine("13. Exercise 13 - First student score>7");
                Console.WriteLine("14. Exercise 14 - Any student failed score<5");
                Console.WriteLine("15. Exercise 15 - Distinct numbers");
                Console.WriteLine("16. Exercise 16 - Sum of integers list");
                Console.WriteLine("17. Exercise 17 - Average student score");
                Console.WriteLine("18. Exercise 18 - Group students by classification");
                Console.WriteLine("19. Exercise 19 - Number that appears most");
                Console.WriteLine("20. Exercise 20 - Top 3 students by score");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an exercise: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Exercises.Exercise1();
                        break;
                    case 2:
                        Exercises.Exercise2();
                        break;
                    case 3:
                        Exercises.Exercise3();
                        break;
                    case 4:
                        Exercises.Exercise4();
                        break;
                    case 5:
                        Exercises.Exercise5();
                        break;
                    case 6:
                        Exercises.Exercise6();
                        break;
                    case 7:
                        Exercises.Exercise7();
                        break;
                    case 8:
                        Exercises.Exercise8();
                        break;
                    case 9:
                        Exercises.Exercise9();
                        break;
                    case 10:
                        Exercises.Exercise10();
                        break;
                    case 11:
                        Exercises.Exercise11();
                        break;
                    case 12:
                        Exercises.Exercise12();
                        break;
                    case 13:
                        Exercises.Exercise13();
                        break;
                    case 14:
                        Exercises.Exercise14();
                        break;
                    case 15:
                        Exercises.Exercise15();
                        break;
                    case 16:
                        Exercises.Exercise16();
                        break;
                    case 17:
                        Exercises.Exercise17();
                        break;
                    case 18:
                        Exercises.Exercise18();
                        break;
                    case 19:
                        Exercises.Exercise19();
                        break;
                    case 20:
                        Exercises.Exercise20();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Unknown choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public static class Exercises
    {
        // Trả về danh sách mẫu các sinh viên
        private static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7}
            };
        }
        public static void Exercise1()
        {
            // Bài 1: Lọc số chẵn từ danh sách
            Console.WriteLine("Bài 1 - Lọc số chẵn");
            var numbers = new List<int> {1,2,3,4,5,6,7,8};
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Các số chẵn:");
            Console.WriteLine(string.Join(", ", evens));
            Pause();
        }

        public static void Exercise2()
        {
            // Bài 2: Lọc số lớn hơn 5
            Console.WriteLine("Bài 2 - Lọc số > 5");
            var numbers = new List<int> {1,2,3,4,5,6,7,8};
            var greater = numbers.Where(n => n > 5);
            Console.WriteLine("Các số > 5:");
            Console.WriteLine(string.Join(", ", greater));
            Pause();
        }

        public static void Exercise3()
        {
            // Bài 3: Sắp xếp tăng dần
            Console.WriteLine("Bài 3 - Sắp xếp tăng dần");
            var numbers = new List<int> {8,3,5,1,7,2,6,4};
            var ordered = numbers.OrderBy(n => n);
            Console.WriteLine("Kết quả:");
            Console.WriteLine(string.Join(", ", ordered));
            Pause();
        }

        public static void Exercise4()
        {
            // Bài 4: Sắp xếp giảm dần
            Console.WriteLine("Bài 4 - Sắp xếp giảm dần");
            var numbers = new List<int> {8,3,5,1,7,2,6,4};
            var ordered = numbers.OrderByDescending(n => n);
            Console.WriteLine("Kết quả:");
            Console.WriteLine(string.Join(", ", ordered));
            Pause();
        }

        public static void Exercise5()
        {
            // Bài 5: Bình phương các số
            Console.WriteLine("Bài 5 - Bình phương các số");
            var numbers = new List<int> {1,2,3};
            var squares = numbers.Select(n => n * n);
            Console.WriteLine("Kết quả:");
            Console.WriteLine(string.Join(", ", squares));
            Pause();
        }

        public static void Exercise6()
        {
            // Bài 6: Đếm số chẵn
            Console.WriteLine("Bài 6 - Đếm số chẵn");
            var numbers = new List<int> {1,2,3,4,5,6,7,8};
            var count = numbers.Count(n => n % 2 == 0);
            Console.WriteLine($"Số phần tử chẵn: {count}");
            Pause();
        }

        public static void Exercise7()
        {
            // Bài 7: Kiểm tra tồn tại số > 10
            Console.WriteLine("Bài 7 - Có số >10 không");
            var numbers = new List<int> {1,2,3,4,5,6,7,8};
            var any = numbers.Any(n => n > 10);
            Console.WriteLine(any ? "Có số lớn hơn 10" : "Không có");
            Pause();
        }

        public static void Exercise2()
        {
            Console.WriteLine("Exercise 2 - Select names starting with A");
            var names = new List<string> { "Alice", "Bob", "Angela", "David", "Andrew" };
            var aNames = names.Where(n => n.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Names that start with 'A':");
            foreach (var name in aNames)
            {
                Console.WriteLine(name);
            }
            Pause();
        }

        public static void Exercise3()
        {
            Console.WriteLine("Exercise 3 - Group words by first letter");
            var words = new[] { "apple", "banana", "avocado", "cherry", "apricot", "blueberry" };
            var groups = words.GroupBy(w => w[0]);
            foreach (var grp in groups)
            {
                Console.WriteLine($"Words starting with '{grp.Key}': {string.Join(", ", grp)}");
            }
            Pause();
        }

        public static void Exercise4()
        {
            Console.WriteLine("Exercise 4 - Sum numbers 1 to 100");
            var sum = Enumerable.Range(1, 100).Sum();
            Console.WriteLine($"Sum of numbers from 1 to 100: {sum}");
            Pause();
        }

        public static void Exercise5()
        {
            Console.WriteLine("Exercise 5 - Order names alphabetically");
            var names = new List<string> { "Charlie", "Alice", "Bob", "David" };
            var ordered = names.OrderBy(n => n);
            Console.WriteLine("Ordered names:");
            foreach (var name in ordered)
            {
                Console.WriteLine(name);
            }
            Pause();
        }

        public static void Exercise6()
        {
            Console.WriteLine("Exercise 6 - Join students with scores");
            var students = new[] { new { Id = 1, Name = "Alice" }, new { Id = 2, Name = "Bob" }, new { Id = 3, Name = "Charlie" } };
            var scores = new[] { new { StudentId = 1, Score = 95 }, new { StudentId = 2, Score = 88 }, new { StudentId = 3, Score = 76 } };
            var query = from s in students
                        join sc in scores on s.Id equals sc.StudentId
                        select new { s.Name, sc.Score };
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }
            Pause();
        }

        public static void Exercise7()
        {
            Console.WriteLine("Exercise 7 - Find max number 1-100");
            var max = Enumerable.Range(1, 100).Max();
            Console.WriteLine($"Maximum number from 1 to 100 is {max}");
            Pause();
        }

        public static void Exercise8()
        {
            // Bài 8: Lọc sinh viên điểm >= 8
            Console.WriteLine("Bài 8 - Sinh viên điểm >= 8");
            var students = GetStudents();
            var good = students.Where(s => s.Score >= 8);
            foreach (var s in good)
            {
                Console.WriteLine($"{s.Name} ({s.Score})");
            }
            Pause();
        }

        // Part 2 & 3 placeholders
        public static void Exercise9()
        {
            // Bài 9: Lấy danh sách tên sinh viên
            Console.WriteLine("Bài 9 - Danh sách tên sinh viên");
            var students = GetStudents();
            var names = students.Select(s => s.Name);
            Console.WriteLine(string.Join(" ", names));
            Pause();
        }

        public static void Exercise10()
        {
            // Bài 10: Sắp xếp sinh viên theo điểm giảm dần
            Console.WriteLine("Bài 10 - Sắp xếp sinh viên theo điểm");
            var students = GetStudents().OrderByDescending(s => s.Score);
            foreach (var s in students)
                Console.WriteLine($"{s.Name}: {s.Score}");
            Pause();
        }

        public static void Exercise11()
        {
            // Bài 11: Sinh viên có điểm cao nhất
            Console.WriteLine("Bài 11 - Sinh viên điểm cao nhất");
            var top = GetStudents().OrderByDescending(s => s.Score).FirstOrDefault();
            if (top != null) Console.WriteLine($"{top.Name}: {top.Score}");
            Pause();
        }

        public static void Exercise12()
        {
            // Bài 12: Đếm số sinh viên điểm >=7
            Console.WriteLine("Bài 12 - Đếm sinh viên đạt");
            var count = GetStudents().Count(s => s.Score >= 7);
            Console.WriteLine($"Số sinh viên đạt: {count}");
            Pause();
        }

        public static void Exercise13()
        {
            // Bài 13: Sinh viên đầu tiên có điểm >7
            Console.WriteLine("Bài 13 - Sinh viên đầu tiên điểm >7");
            var first = GetStudents().FirstOrDefault(s => s.Score > 7);
            if (first != null) Console.WriteLine($"{first.Name}: {first.Score}");
            else Console.WriteLine("Không có");
            Pause();
        }

        public static void Exercise14()
        {
            // Bài 14: Kiểm tra có sinh viên rớt (score <5)
            Console.WriteLine("Bài 14 - Có sinh viên rớt không");
            var anyFail = GetStudents().Any(s => s.Score < 5);
            Console.WriteLine(anyFail ? "Có sinh viên rớt" : "Không có sinh viên rớt");
            Pause();
        }
        public static void Exercise15()
        {
            // Bài 15: Loại bỏ phần tử trùng
            Console.WriteLine("Bài 15 - Loại bỏ số trùng");
            var numbers = new List<int> {1,2,2,3,4,4,5};
            var distinct = numbers.Distinct();
            Console.WriteLine(string.Join(", ", distinct));
            Pause();
        }

        public static void Exercise16()
        {
            // Bài 16: Tính tổng
            Console.WriteLine("Bài 16 - Tính tổng danh sách");
            var numbers = new List<int> {1,2,3,4,5};
            Console.WriteLine($"Tổng: {numbers.Sum()}");
            Pause();
        }

        public static void Exercise17()
        {
            // Bài 17: Tính điểm trung bình sinh viên
            Console.WriteLine("Bài 17 - Điểm trung bình sinh viên");
            var avg = GetStudents().Average(s => s.Score);
            Console.WriteLine($"Điểm TB: {avg}");
            Pause();
        }

        public static void Exercise18()
        {
            // Bài 18: Nhóm sinh viên theo xếp loại
            Console.WriteLine("Bài 18 - Nhóm theo xếp loại");
            var groups = GetStudents().GroupBy(s =>
            {
                if (s.Score >= 8) return "Giỏi";
                if (s.Score >= 6) return "Khá";
                return "Trung bình";
            });
            foreach (var grp in groups)
            {
                Console.WriteLine($"{grp.Key}:");
                foreach (var s in grp)
                    Console.WriteLine($"  {s.Name} ({s.Score})");
            }
            Pause();
        }

        public static void Exercise19()
        {
            // Bài 19: Tìm số xuất hiện nhiều nhất
            Console.WriteLine("Bài 19 - Số xuất hiện nhiều nhất");
            var numbers = new List<int> {1,2,2,3,4,4,4,5,2};
            var most = numbers.GroupBy(n => n)
                              .OrderByDescending(g => g.Count())
                              .First().Key;
            Console.WriteLine($"Số xuất hiện nhiều nhất: {most}");
            Pause();
        }

        public static void Exercise20()
        {
            // Bài 20: Lấy top 3 sinh viên điểm cao nhất
            Console.WriteLine("Bài 20 - Top 3 sinh viên");
            var top3 = GetStudents().OrderByDescending(s => s.Score).Take(3);
            foreach (var s in top3)
                Console.WriteLine($"{s.Name}: {s.Score}");
            Pause();
        }

        // Dừng lại chờ người dùng nhấn phím
        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Nhấn phím bất kỳ để về menu...");
            Console.ReadKey();
        }
    }

    // Định nghĩa lớp sinh viên dùng trong bài tập
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
}
