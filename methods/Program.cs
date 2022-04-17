using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var SomeName = "Евгения";
            var SomeAge = 33;
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);
            GetName(SomeName);
            GetAge(SomeAge);
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);

            static void GetName(string name)
            {
                Console.WriteLine("Введите имя: ");
                Console.ReadLine();
            }
            static void GetAge(int age)
            {
                Console.WriteLine("Введите возрвст: ");
                Console.ReadLine();
            }
        }
    }
}

