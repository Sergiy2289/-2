using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000, a, b, c;
            while (n > 999)
            {
               Console.Write("Задания 4.31");
               Console.Write("Введите трьехзначное число: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            a = n / 100;
            b = n % 100 / 10;
            c = n % 10;
            if (a == b && b == c && a == c)
                Console.WriteLine("Все цифры равны!");
            else
            {
                Console.WriteLine("Вместе цифры не равны!");
                if (a == b)
                    Console.WriteLine("Первая и вторая цифры одинаковы!");
                else if (b == c)
                    Console.WriteLine("Вторая и третья одинаковы!");
                else if (a == c)
                    Console.WriteLine("Первая и третья одинаковы!");
                else
                    Console.WriteLine("Здесь нет равных цифр!");

            }
        }
}
}
