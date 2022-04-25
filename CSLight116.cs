using System;
using System.Collections.Generic;

namespace CSLight116
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> purchaseAmount = new Queue<int>();
            int income = 0;

            Fill(purchaseAmount);

            ServeTheCustomer(ref income, purchaseAmount);
        }

        static void Fill (Queue<int> purchaseAmount)
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                purchaseAmount.Enqueue(random.Next(100, 10000));
            }
        }

        static void ServeTheCustomer (ref int income, Queue<int> purchaseAmount)
        {
            while (purchaseAmount.Count != 0)
            {
                Console.WriteLine("Клиент совершил покупку на сумму " + purchaseAmount.Peek() + " рублей.");

                income += purchaseAmount.Dequeue();
                Console.WriteLine("Выручка за день составляет " + income + " рублей.");

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
