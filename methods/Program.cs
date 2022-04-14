using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
                favcolors[i] = ShowColor();
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
                Console.WriteLine(color);
            ShowColors(anketa.name, favcolors);
        }
        static string ShowColor(params string[] favcolors)
        {
            Console.WriteLine("Напишите Ваш любимый цвет на английском с маленькой буквы: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static void ShowColors(string username, params string[] favcolors)
        {
            Console.WriteLine("{0}, ваши любимые цвета:", username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}

