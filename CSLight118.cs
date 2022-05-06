using System;
using System.Collections.Generic;

namespace CSLight118
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossiers = new Dictionary<string, string>();
            bool isRunning = true;

            while (isRunning)
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine(" 1 - Добавить досье." +
                "\n 2 - Вывести все досье." +
                "\n 3 - Удалить досье." +
                "\n 4 - Выход.");
                Console.SetCursorPosition(0, 0);

                string userInput = Console.ReadLine();
                int inputNumber;
                bool isUserInputCorrect;
                isUserInputCorrect = int.TryParse(userInput, out inputNumber);

                if (isUserInputCorrect)
                {
                    switch (inputNumber)
                    {
                        case 1:
                            AddDossier(dossiers);
                            break;
                        case 2:
                            OutputAllDossiers(dossiers);
                            break;
                        case 3:
                            DeleteDossier(dossiers);
                            break;
                        case 4:
                            Console.WriteLine("\nББ :)");
                            isRunning = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nОшибка ввода. Пожалуйста, введите число.");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddDossier(Dictionary<string, string> dossiers)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.Write("Введите должность: ");
            string jobPosition = Console.ReadLine();

            if (IsKeyFree(dossiers, fullName) == false)
            {
                Console.WriteLine("\nТакой сотрудник уже есть в базе.");
            }
            else
            {
                dossiers.Add(fullName, jobPosition);
                Console.WriteLine("\nДосье добавлено.");
            }
        }

        static bool IsKeyFree (Dictionary<string, string> dossiers, string fullName)
        {
            if (dossiers.ContainsKey(fullName) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void OutputAllDossiers(Dictionary<string, string> dossiers)
        {
            if (dossiers.Count == 0)
            {
                Console.WriteLine("Досье отсутствуют.");
            }
            else
            {
                int dossiersPositionX = 70;
                int dossiersPositionY = 1;

                foreach (var thisOne in dossiers)
                {
                    Console.SetCursorPosition(dossiersPositionX, dossiersPositionY++);
                    Console.WriteLine(thisOne.Key + " - " + thisOne.Value);
                }
            }
        }

        static void DeleteDossier(Dictionary<string, string> dossiers)
        {
            if (dossiers.Count == 0)
            {
                Console.WriteLine("Досье отсутствуют.");
            }
            else
            {
                Console.WriteLine("Удалить досье по фамилии.");

                DeleteByFullName(dossiers);
            }
        }

        static void DeleteByFullName(Dictionary<string, string> dossiers)
        {
            Console.Write("Введите ФИО: ");
            string userInput = Console.ReadLine();

            if (dossiers.ContainsKey(userInput))
            {
                dossiers.Remove(userInput);

                Console.WriteLine("\nДосье удалено.");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден.");
            }
        }
    }
}
