﻿using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
            
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i+1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            
            }
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
            return result;
        }
}
}
