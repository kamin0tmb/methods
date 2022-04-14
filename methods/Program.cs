﻿using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var array = GetArrayFromConsole();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(array[i]);
                Console.WriteLine();
            array = SortArray(array);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(array[i]);
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
            return result;
            
        }
        static int [] SortArray(int [] result)
        {
            
            int temp = 0;
                for (int i = 0; i < result.Length; i++)
                {
                    for (int j = i + 1; j < result.Length; j++)
                        if (result[i] > result[j])
                        {
                            temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }

                }
                
                return result;
        }

        }
}

