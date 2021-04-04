using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 4.9");
            Console.WriteLine("Введите км в час");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите метры в секунду");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 3.6 * y)
                Console.WriteLine(x + "км/час больше чем " + y + "м/с.");
            else if (x == 3.6 * y)
                Console.WriteLine(x + " км/час равно " + y + "м/с.");
            else
                Console.WriteLine(y + "м/с больше чем " + x + "км/час.");
        }
    }
}
