using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = GetArrayFromConsole();
            int[] sorteddesc;
            int[] sortedasc;
            SortArray(in array, out sorteddesc, out sortedasc);
            Console.WriteLine("Исходный массив: ");
            ShowArray(array);
            Console.WriteLine("Отсортированный массив от меньшего к большему: ");
            ShowArray(sortedasc);
            Console.WriteLine("Отсортированный массив от большего к меньшему: ");
            ShowArray(sorteddesc);


        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return result;

        }
        static int[] SortArrayAsc(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
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
        static int[] SortArrayDesc(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            }

            return result;
        }
        static void SortArray (in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sortedasc = SortArrayAsc(array);
            sorteddesc = SortArrayDesc(array);
            
        }
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine();

        }
    }
}

