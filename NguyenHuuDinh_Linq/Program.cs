// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; }
    public double GPA { get; set; }
    public int Year { get; set; }
    public double Tuition { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Thông tin sinh viên hiển thị ở đầu chương trình
        const string StudentInfo = "Mã sinh viên: 23115053122305  Tên: Nguyễn Hữu Định  Lớp: 225LTC#01";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(StudentInfo);
            Console.WriteLine();
            Console.WriteLine("=== Menu bài tập List và Dictionary ===");
            Console.WriteLine("PHẦN 1 – BÀI TẬP CƠ BẢN (1–7)");
            Console.WriteLine("1. Tạo danh sách số nguyên");
            Console.WriteLine("2. Tính tổng các phần tử");
            Console.WriteLine("3. Tìm số lớn nhất");
            Console.WriteLine("4. Đếm số chẵn");
            Console.WriteLine("5. Xóa phần tử khỏi List");
            Console.WriteLine("6. Kiểm tra phần tử tồn tại");
            Console.WriteLine("7. Sắp xếp danh sách");
            Console.WriteLine("PHẦN 2 – BÀI TẬP TRUNG BÌNH (8–14)");
            Console.WriteLine("8. Đảo ngược danh sách");
            Console.WriteLine("9. Loại bỏ phần tử trùng lặp");
            Console.WriteLine("10. Tìm phần tử nhỏ nhất");
            Console.WriteLine("11. Lưu danh sách sinh viên");
            Console.WriteLine("12. Tìm sinh viên theo tên");
            Console.WriteLine("13. Đếm số sinh viên");
            Console.WriteLine("14. Xóa sinh viên theo ID");
            Console.WriteLine("PHẦN 3 – BÀI TẬP NÂNG CAO (15–18)");
            Console.WriteLine("15. Sử dụng Dictionary");
            Console.WriteLine("16. Đếm số lần xuất hiện");
            Console.WriteLine("17. Tìm phần tử xuất hiện nhiều nhất");
            Console.WriteLine("18. Quản lý điểm sinh viên");
            Console.WriteLine("PHẦN 4 – BÀI TẬP LINQ & CLASS (19–21)");
            Console.WriteLine("19. Tìm số xuất hiện nhiều nhất");
            Console.WriteLine("20. Top 3 sinh viên điểm cao nhất");
            Console.WriteLine("21. Bài tập trên lớp (List SV ngẫu nhiên, tuổi max/min, kt khoa CNS, top 10 GPA, học phí)");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài tập (0-21): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Nhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                case 4:
                    Exercise4();
                    break;
                case 5:
                    Exercise5();
                    break;
                case 6:
                    Exercise6();
                    break;
                case 7:
                    Exercise7();
                    break;
                case 8:
                    Exercise8();
                    break;
                case 9:
                    Exercise9();
                    break;
                case 10:
                    Exercise10();
                    break;
                case 11:
                    Exercise11();
                    break;
                case 12:
                    Exercise12();
                    break;
                case 13:
                    Exercise13();
                    break;
                case 14:
                    Exercise14();
                    break;
                case 15:
                    Exercise15();
                    break;
                case 16:
                    Exercise16();
                    break;
                case 17:
                    Exercise17();
                    break;
                case 18:
                    Exercise18();
                    break;
                case 19:
                    Exercise19();
                    break;
                case 20:
                    Exercise20();
                    break;
                case 21:
                    Exercise21();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Nhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void Exercise1()
    {
        Console.WriteLine("Bài 1. Tạo danh sách số nguyên:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine("Danh sách: " + string.Join(", ", numbers));
        Pause();
    }

    static void Exercise2()
    {
        Console.WriteLine("Bài 2. Tính tổng các phần tử:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int sum = numbers.Sum();
        Console.WriteLine("Tổng: " + sum);
        Pause();
    }

    static void Exercise3()
    {
        Console.WriteLine("Bài 3. Tìm số lớn nhất:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int max = numbers.Max();
        Console.WriteLine("Số lớn nhất: " + max);
        Pause();
    }

    static void Exercise4()
    {
        Console.WriteLine("Bài 4. Đếm số chẵn:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int evenCount = numbers.Count(n => n % 2 == 0);
        Console.WriteLine("Số lượng số chẵn: " + evenCount);
        Pause();
    }

    static void Exercise5()
    {
        Console.WriteLine("Bài 5. Xóa phần tử khỏi List:");
        List<string> studentNames = new List<string> { "An", "Binh", "Chi", "Dung" };
        Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", studentNames));
        Console.Write("Nhập tên cần xóa: ");
        string nameToRemove = Console.ReadLine();
        if (studentNames.Remove(nameToRemove))
        {
            Console.WriteLine("Đã xóa '" + nameToRemove + "'");
        }
        else
        {
            Console.WriteLine("Không tìm thấy '" + nameToRemove + "'");
        }
        Console.WriteLine("Danh sách sau: " + string.Join(", ", studentNames));
        Pause();
    }

    static void Exercise6()
    {
        Console.WriteLine("Bài 6. Kiểm tra phần tử tồn tại:");
        List<string> studentNames = new List<string> { "An", "Binh", "Chi", "Dung" };
        Console.Write("Nhập tên cần kiểm tra: ");
        string nameToCheck = Console.ReadLine();
        bool exists = studentNames.Contains(nameToCheck);
        Console.WriteLine("'" + nameToCheck + "' có tồn tại: " + exists);
        Pause();
    }

    static void Exercise7()
    {
        Console.WriteLine("Bài 7. Sắp xếp danh sách:");
        List<int> unsortedNumbers = new List<int> { 5, 2, 8, 1, 9 };
        Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", unsortedNumbers));
        unsortedNumbers.Sort();
        Console.WriteLine("Sắp xếp tăng dần: " + string.Join(", ", unsortedNumbers));
        Pause();
    }

    static void Exercise8()
    {
        Console.WriteLine("Bài 8. Đảo ngược danh sách:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", numbers));
        numbers.Reverse();
        Console.WriteLine("Đảo ngược: " + string.Join(", ", numbers));
        Pause();
    }

    static void Exercise9()
    {
        Console.WriteLine("Bài 9. Loại bỏ phần tử trùng lặp:");
        List<int> numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", numbersWithDuplicates));
        List<int> distinctNumbers = numbersWithDuplicates.Distinct().ToList();
        Console.WriteLine("Không trùng: " + string.Join(", ", distinctNumbers));
        Pause();
    }

    static void Exercise10()
    {
        Console.WriteLine("Bài 10. Tìm phần tử nhỏ nhất:");
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int min = numbers.Min();
        Console.WriteLine("Số nhỏ nhất: " + min);
        Pause();
    }

    static void Exercise11()
    {
        Console.WriteLine("Bài 11. Lưu danh sách sinh viên:");
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "An" },
            new Student { Id = 2, Name = "Binh" },
            new Student { Id = 3, Name = "Chi" }
        };
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
        }
        Pause();
    }

    static void Exercise12()
    {
        Console.WriteLine("Bài 12. Tìm sinh viên theo tên:");
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "An" },
            new Student { Id = 2, Name = "Binh" },
            new Student { Id = 3, Name = "Chi" }
        };
        Console.Write("Nhập tên sinh viên: ");
        string searchName = Console.ReadLine();
        var foundStudent = students.Find(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
        if (foundStudent != null)
        {
            Console.WriteLine($"Tìm thấy: Id: {foundStudent.Id}, Name: {foundStudent.Name}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có tên '" + searchName + "'");
        }
        Pause();
    }

    static void Exercise13()
    {
        Console.WriteLine("Bài 13. Đếm số sinh viên:");
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "An" },
            new Student { Id = 2, Name = "Binh" },
            new Student { Id = 3, Name = "Chi" }
        };
        int studentCount = students.Count;
        Console.WriteLine("Tổng số sinh viên: " + studentCount);
        Pause();
    }

    static void Exercise14()
    {
        Console.WriteLine("Bài 14. Xóa sinh viên theo ID:");
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "An" },
            new Student { Id = 2, Name = "Binh" },
            new Student { Id = 3, Name = "Chi" }
        };
        Console.Write("Nhập ID sinh viên cần xóa: ");
        if (int.TryParse(Console.ReadLine(), out int removeId))
        {
            var studentToRemove = students.Find(s => s.Id == removeId);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Đã xóa sinh viên có Id: " + removeId);
                Console.WriteLine("Danh sách còn lại:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có Id: " + removeId);
            }
        }
        else
        {
            Console.WriteLine("ID không hợp lệ.");
        }
        Pause();
    }

    static void Exercise15()
    {
        Console.WriteLine("Bài 15. Sử dụng Dictionary:");
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "hello", "xin chào" },
            { "world", "thế giới" },
            { "computer", "máy tính" }
        };
        Console.Write("Nhập từ tiếng Anh: ");
        string word = Console.ReadLine().ToLower();
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine($"{word} nghĩa là: {dictionary[word]}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy từ '" + word + "' trong từ điển.");
        }
        Pause();
    }

    static void Exercise16()
    {
        Console.WriteLine("Bài 16. Đếm số lần xuất hiện:");
        Console.Write("Nhập chuỗi: ");
        string inputString = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in inputString)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        foreach (var pair in charCount)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
        Pause();
    }

    static void Exercise17()
    {
        Console.WriteLine("Bài 17. Tìm phần tử xuất hiện nhiều nhất:");
        List<int> freqList = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
        Console.WriteLine("Danh sách: " + string.Join(", ", freqList));
        Dictionary<int, int> freqDict = new Dictionary<int, int>();
        foreach (int num in freqList)
        {
            if (freqDict.ContainsKey(num))
            {
                freqDict[num]++;
            }
            else
            {
                freqDict[num] = 1;
            }
        }
        var mostFrequent = freqDict.OrderByDescending(pair => pair.Value).First();
        Console.WriteLine("Số xuất hiện nhiều nhất: " + mostFrequent.Key + " (xuất hiện " + mostFrequent.Value + " lần)");
        Pause();
    }

    static void Exercise18()
    {
        Console.WriteLine("Bài 18. Quản lý điểm sinh viên:");
        List<Student> scoredStudents = new List<Student>
        {
            new Student { Name = "An", Score = 8.5 },
            new Student { Name = "Binh", Score = 9.0 },
            new Student { Name = "Chi", Score = 7.5 }
        };
        foreach (var student in scoredStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
        }
        var highestScoreStudent = scoredStudents.OrderByDescending(s => s.Score).First();
        Console.WriteLine($"Sinh viên điểm cao nhất: {highestScoreStudent.Name} - {highestScoreStudent.Score}");
        Pause();
    }

    static void Exercise19()
    {
        Console.WriteLine("Bài 19. Tìm số xuất hiện nhiều nhất:");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5 };
        Console.WriteLine("Danh sách: " + string.Join(", ", numbers));

        var mostFrequent = numbers.GroupBy(n => n)
                                 .OrderByDescending(g => g.Count())
                                 .First();

        Console.WriteLine($"Số xuất hiện nhiều nhất: {mostFrequent.Key} (xuất hiện {mostFrequent.Count()} lần)");
        Pause();
    }

    static void Exercise20()
    {
        Console.WriteLine("Bài 20. Top 3 sinh viên điểm cao nhất:");
        List<Student> students = new List<Student>
        {
            new Student { Name = "An", Score = 8.5 },
            new Student { Name = "Binh", Score = 9.0 },
            new Student { Name = "Chi", Score = 7.5 },
            new Student { Name = "Dung", Score = 9.2 },
            new Student { Name = "Em", Score = 8.8 }
        };

        var top3Students = students.OrderByDescending(s => s.Score)
                                  .Take(3)
                                  .ToList();

        Console.WriteLine("Top 3 sinh viên điểm cao nhất:");
        for (int i = 0; i < top3Students.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {top3Students[i].Name} - {top3Students[i].Score}");
        }
        Pause();
    }

    static void Exercise21()
    {
        Console.WriteLine("Bài 21. Bài tập trên lớp:");
        
        // 1. Tạo danh sách sinh viên ngẫu nhiên
        Console.WriteLine("1. Tạo danh sách sinh viên ngẫu nhiên:");
        Random random = new Random();
        int studentCount = random.Next(15, 26); // Random 15-25 students
        List<Student> students = new List<Student>();

        string[] names = { "An", "Binh", "Chi", "Dung", "Em", "Giang", "Hanh", "Khoa", "Lan", "Minh", "Nam", "Oanh", "Phuong", "Quang", "Rin" };
        string[] faculties = { "CNTT", "KT", "KH", "NN", "CNS" };

        for (int i = 0; i < studentCount; i++)
        {
            students.Add(new Student
            {
                Id = i + 1,
                Name = names[random.Next(names.Length)],
                Age = random.Next(18, 25),
                Faculty = faculties[random.Next(faculties.Length)],
                GPA = Math.Round(random.NextDouble() * 4 + 1, 2), // 1.0 - 5.0
                Year = random.Next(1, 5),
                Tuition = random.Next(10000000, 20000001) // 10M - 20M VND
            });
        }

        Console.WriteLine($"Đã tạo {studentCount} sinh viên ngẫu nhiên:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}, Khoa: {student.Faculty}, GPA: {student.GPA}, Năm: {student.Year}, Học phí: {student.Tuition:N0} VND");
        }
        Console.WriteLine();

        // 2. Max tuổi, Min tuổi
        Console.WriteLine("2. Tìm tuổi max/min:");
        int maxAge = students.Max(s => s.Age);
        int minAge = students.Min(s => s.Age);
        var oldestStudent = students.First(s => s.Age == maxAge);
        var youngestStudent = students.First(s => s.Age == minAge);
        Console.WriteLine($"Sinh viên lớn tuổi nhất: {oldestStudent.Name} - {maxAge} tuổi");
        Console.WriteLine($"Sinh viên trẻ tuổi nhất: {youngestStudent.Name} - {minAge} tuổi");
        Console.WriteLine();

        // 3. Kiểm tra sinh viên thuộc khoa CNS
        Console.WriteLine("3. Kiểm tra sinh viên thuộc khoa CNS:");
        var cnsStudents = students.Where(s => s.Faculty == "CNS").ToList();
        if (cnsStudents.Any())
        {
            Console.WriteLine("Sinh viên khoa CNS:");
            foreach (var student in cnsStudents)
            {
                Console.WriteLine($"- {student.Name} (ID: {student.Id})");
            }
        }
        else
        {
            Console.WriteLine("Không có sinh viên nào thuộc khoa CNS.");
        }
        Console.WriteLine();

        // 4. Lấy 10 SV có điểm TB cao nhất khoa
        Console.WriteLine("4. Top 10 sinh viên có GPA cao nhất:");
        var top10GPA = students.OrderByDescending(s => s.GPA).Take(10).ToList();
        for (int i = 0; i < top10GPA.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {top10GPA[i].Name} - GPA: {top10GPA[i].GPA} (Khoa: {top10GPA[i].Faculty})");
        }
        Console.WriteLine();

        // 5. Bỏ qua các SV năm cuối → lấy ds SV còn lại tính học phí
        Console.WriteLine("5. Tính tổng học phí sinh viên không phải năm cuối:");
        var nonFinalYearStudents = students.Where(s => s.Year != 4).ToList();
        double totalTuition = nonFinalYearStudents.Sum(s => s.Tuition);
        Console.WriteLine($"Số sinh viên không phải năm cuối: {nonFinalYearStudents.Count}");
        Console.WriteLine($"Tổng học phí: {totalTuition:N0} VND");
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var student in nonFinalYearStudents)
        {
            Console.WriteLine($"- {student.Name} (Năm {student.Year}): {student.Tuition:N0} VND");
        }
        
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
        Console.ReadKey();
    }
}
