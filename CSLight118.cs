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

                switch (Convert.ToInt32(Console.ReadLine()))
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
                        Console.WriteLine("ББ :)");
                        isRunning = false;
                        break;
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

            dossiers.Add(fullName, jobPosition);
            Console.WriteLine("\nДосье добавлено.");
        }

        static void OutputAllDossiers(Dictionary<string, string> dossiers)
        {
            if (dossiers.Count == 0)
            {
                Console.WriteLine("Досье отсутствуют.");
            }
            else
            {
                int i = 1;

                foreach (var thisOne in dossiers)
                {
                    Console.SetCursorPosition(70, i++);
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

                Console.WriteLine("\nДосье удалено.");

            }
        }

        static void DeleteByFullName(Dictionary<string, string> dossiers)
        {
            Console.Write("Введите ФИО: ");
            string userInput = Console.ReadLine();

            if (dossiers.ContainsKey(userInput))
            {
                dossiers.Remove(userInput);
            }
            else
            {
                Console.WriteLine("Сотрудник не найден.");
            }
        }
    }
}
