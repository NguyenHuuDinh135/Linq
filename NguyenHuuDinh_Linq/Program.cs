using System;
using System.Collections.Generic;
using System.Linq;

namespace NguyenHuuDinh_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== LINQ Exercises Menu ===");
                Console.WriteLine("1. Exercise 1 - Filter even numbers");
                Console.WriteLine("2. Exercise 2 - Select names starting with A");
                Console.WriteLine("3. Exercise 3 - Group words by first letter");
                Console.WriteLine("4. Exercise 4 - Sum numbers 1 to 100");
                Console.WriteLine("5. Exercise 5 - Order names alphabetically");
                Console.WriteLine("6. Exercise 6 - Join students with scores");
                Console.WriteLine("7. Exercise 7 - Find max number 1-100");
                Console.WriteLine("8. Exercise 8 - Group names by length");
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
        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1 - Filter even numbers");
            var numbers = Enumerable.Range(1, 20);
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers from 1 to 20:");
            Console.WriteLine(string.Join(", ", evens));
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
            Console.WriteLine("Exercise 8 - Group names by length");
            var names = new[] { "Anna", "Bob", "Christine", "David", "Eve" };
            var groups = names.GroupBy(n => n.Length);
            foreach (var grp in groups)
            {
                Console.WriteLine($"Names of length {grp.Key}: {string.Join(", ", grp)}");
            }
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}
