using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ваших лет");
            int year = Convert.ToInt32(Console.ReadLine());
            string color = string.Empty;
            switch (((year + 6) % 10 + 2) / 2)
            {
                case 1:
                    color = "Green";
                    break;
                case 2:
                    color = "Red";
                    break;
                case 3:
                    color = "Yellow";
                    break;
                case 4:
                    color = "White";
                    break;
                case 5:
                    color = "Black";
                    break;
            }
            switch ((year - 3) % 12)
            {
                case 1:
                    Console.WriteLine($"{color} Mouse year");
                    break;
                case 2:
                    Console.WriteLine($"{color} Cow year");
                    break;
                case 3:
                    Console.WriteLine($"{color} Tiger year");
                    break;
                case 4:
                    Console.WriteLine($"{color} Rabbit year");
                    break;
                case 5:
                    Console.WriteLine($"{color} Dragon year");
                    break;
                case 6:
                    Console.WriteLine($"{color} Snake year");
                    break;
                case 7:
                    Console.WriteLine($"{color} Horse year");
                    break;
                case 8:
                    Console.WriteLine($"{color} Sheep year");
                    break;
                case 9:
                    Console.WriteLine($"{color} Monkey year");
                    break;
                case 10:
                    Console.WriteLine($"{ color} Cock year");
                    break;
                case 11:
                    Console.WriteLine($"{ color} Dog year");
                    break;
                case 0:
                    Console.WriteLine($"{color} Pig year");
                    break;
            }
        }
    }
}
