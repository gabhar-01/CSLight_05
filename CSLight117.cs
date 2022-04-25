using System;
using System.Collections.Generic;

namespace CSLight117
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dynamicArray = new List<int>();

            Console.WriteLine("Введите числа для добавления их в массив." +
                "\nВведите команду sum для вывода суммы всех введенных чисел." +
                "\nВведите команду exit для выхода из программы.\n");

            ReadList(dynamicArray);
        }

        static void ReadList (List<int> dynamicArray)
        {
            string userInput;
            bool isRunning = true;

            string sumCommand = "sum";
            string exitCommand = "exit";

            while (isRunning)
            {
                userInput = Console.ReadLine();

                if (userInput == sumCommand)
                {
                    int sum = 0;

                    foreach (int number in dynamicArray)
                    {
                        sum += number;
                    }

                    Console.WriteLine(sum);
                }
                else if (userInput == exitCommand)
                {
                    isRunning = false;
                }
                else
                {
                    dynamicArray.Add(Convert.ToInt32(userInput));
                }
            }
        }
    }
}
