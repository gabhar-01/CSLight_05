using System;
using System.Collections.Generic;

namespace CSLight108
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> glossary = new Dictionary<string, string>();
            Fill(glossary);

            FindTerm(glossary);

            Console.ReadKey();
        }

        static void Fill(Dictionary<string, string> glossary)
        {
            glossary.Add("Алгоритм", "это конечная совокупность точно заданных правил решения некоторого класса задач " +
                "или набор инструкций, описывающих порядок действий исполнителя для решения определённой задачи.");
            glossary.Add("Буткемп", "это интенсивное очное обучение программированию, во время которого " +
                "учащийся полностью погружается в разработку и овладевает ключевыми навыками за короткий срок.");
            glossary.Add("Инкапсуляция", "нужна для того, что бы пользователь не мог использовать не предназначенный для него функционал.");
            glossary.Add("Полиморфизм", "способность функции обрабатывать данные разных типов.");
            glossary.Add("Метод", "это блок кода, содержащий ряд инструкций.");
        }

        static void FindTerm(Dictionary<string, string> glossary)
        {
            bool isFound = false;
            
            Console.Write("Введите термин: ");

            string userInput;
            userInput = Console.ReadLine();
            string value;

            if (glossary.TryGetValue(userInput, out value))
            {
                Console.WriteLine(userInput + " — " + value);
                isFound = true;
            }

            CheckFor(isFound);
        }

        static void CheckFor(bool isFound)
        {
            if (isFound == false)
            {
                Console.Write("Такого понятия в словаре нет.");
            }
        }
    }
}
