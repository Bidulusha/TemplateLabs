using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tasks
    {
        static public void Solve1()
        {
            char st = (Console.ReadLine().ToString())[0];
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            string result = "";
            switch (st)
            {
                case '+': result = $"{a}{st}{b} = {a + b}"; break;
                case '-': result = $"{a}{st}{b} = {a + b}"; break;
                case 'x': result = $"{a}{st}{b} = {a + b}"; break;
                case '/': result = $"{a}{st}{b} = {a + b}"; break;

            }
            Console.WriteLine(result);
        }
        static public void Solve2()
        {
            unsafe { 
                int[] numbers = new int[10];

                Console.WriteLine("Input 10");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                fixed (int* ptr = numbers)
                {
                    Console.WriteLine("ODD NUMBERS;");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currentValue = *(ptr + i);
                        if (currentValue % 2 == 0)
                        {
                            Console.Write($"{currentValue} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        internal static void Solve3()
        {
            unsafe
            {
                int[,] grades = new int[2, 5];

                Console.WriteLine("Enter 10 grades (5 for Group 1, then 5 for Group 2):");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        grades[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                fixed (int* ptr = grades)
                {
                    for (int group = 0; group < 2; group++)
                    {
                        int sum = 0;
                        for (int student = 0; student < 5; student++)
                        {
                            sum += *(ptr + group * 5 + student);
                        }
                        double average = sum / 5.0;
                        Console.WriteLine($"Group {group + 1}: {average:F1}");
                    }
                }
            }
        }
    }
    class Program {

        static void Main(string[] args)
        {
            Tasks.Solve1();
            Tasks.Solve2();
            Tasks.Solve3();
            
        }

    }
}
