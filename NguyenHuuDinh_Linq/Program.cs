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
            // TODO: implement exercise 2
            Pause();
        }

        public static void Exercise3()
        {
            // TODO: implement exercise 3
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
