﻿using System;

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
                favcolors[i] = ShowColor(anketa.name, anketa.age);
            Console.WriteLine("Напишите ваши любимые цвета: ");
            foreach (var color in favcolors)
                Console.WriteLine(color);
        }
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, в Ваши {1} лет какие ваши любимые цвета? Напишите цвет на английском с маленькой буквы", username, userage);
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
}
}
