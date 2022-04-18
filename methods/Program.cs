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
            Console.WriteLine("Введите число 1: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            int num2 = Int32.Parse(Console.ReadLine());
            int num3;
            int num4 = 2;
            int summ = SumNumbers(ref num1, in num2, out num3, num4);
            Console.WriteLine(summ);
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

            static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
            {
                
                num3 = num1 + num2;
                var result = num3 * num4;
                return result;
            }
        }
    }
}

