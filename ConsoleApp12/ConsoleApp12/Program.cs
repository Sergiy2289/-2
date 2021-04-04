using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Звдвния 4.124");
            Console.WriteLine("Введите длину a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину c:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c & a + c > b & b + c > a)
            {
                Console.WriteLine("Создание треугольника возможно");
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    Console.WriteLine("Треугольник — прямоугольный");
                else
                {
                    if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
                        Console.WriteLine("Треугольник — тупоугольный");
                    else
                        Console.WriteLine("Треугольник — остроугольный");
                }
                if (a == b & a == c & b == c)
                    Console.WriteLine("Треугольник — равносторонний");
                else
                   if (a == b || a == c || b == c)
                    Console.WriteLine("Треугольник — равнобедренный");
                else
                    Console.WriteLine("Треугольник — разносторонний");
            }
            else
                Console.WriteLine("Создание треугольника невозможно");
            Console.ReadKey();
        }
    }
}
