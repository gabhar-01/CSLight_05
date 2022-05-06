using System;
using System.Collections.Generic;

namespace CSLight210
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> combinedCollection = new List<int>();

            int[] array1 = new int[0];
            int[] array2 = new int[0];

            Fill(ref array1);
            Fill(ref array2);

            Write(array1);
            Write(array2);

            AddArrayToCollection(array1, combinedCollection);
            AddArrayToCollection(array2, combinedCollection);

            Write(combinedCollection);

            Console.ReadKey();
        }

        static void Fill(ref int[] array)
        {
            int length = 0;

            SetLength(ref length);
            GetUpdatedArray(length, ref array);

            Random random = new Random();
            int minAmount = 0;
            int maxAmount = 10;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minAmount, maxAmount);
            }
        }

        static void SetLength(ref int length)
        {
            Random random = new Random();
            int minAmount = 2;
            int maxAmount = 20;
            length = random.Next(minAmount, maxAmount);
        }

        static void GetUpdatedArray(int length, ref int[] array)
        {
            int[] temporaryArray = new int[length];
            array = temporaryArray;
        }

        static void Write (int[] array)
        {
            Console.Write("{ ");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("}");
        }
        
        static void AddArrayToCollection (int[] array, List<int> collection)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]))
                {
                    continue;
                }
                else
                {
                    collection.Add(array[i]);
                }
            }
        }

        static void Write (List<int> collection)
        {
            Console.Write("\nОбъединенная коллекция: { ");

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("}");
        }
    }
}
