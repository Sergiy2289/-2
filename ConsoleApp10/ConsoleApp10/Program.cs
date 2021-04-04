using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.46");
            Console.WriteLine("Введите длину a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину c:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c & a + c > b & b + c > a)
            {
                Console.WriteLine("Создание треугольника возможно");
                
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
