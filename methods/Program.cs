using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string SomeName = "Евгения";
            int SomeAge = 33;
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);
            GetName(ref SomeName);
            GetAge(SomeAge);
            Console.WriteLine(SomeName);
            Console.WriteLine(SomeAge);

            static void GetName(ref string name)
            {
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
            }
            static void GetAge(int age)
            {
                Console.WriteLine("Введите возрвст: ");
                age = Int32.Parse(Console.ReadLine());
            }
        }
    }
}

