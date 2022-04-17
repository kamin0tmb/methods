using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string SomeName = "Евгения";
            byte SomeAge = 33;
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);
            GetName(ref SomeName);
            GetAge(out SomeName, out SomeAge);
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);

            static void GetName(ref string name)
            {
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
            }
            static void GetAge(out string name, out byte age)
            {
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите возрвст: ");
                age = byte.Parse(Console.ReadLine());
            }
        }
    }
}

