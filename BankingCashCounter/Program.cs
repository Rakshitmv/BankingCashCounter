using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Banking Cash Counter");

            Console.WriteLine("Banking Services Are :\n" + "Enter 1: Withdraw\n" + "Enter 2: Deposit\n " + "Enter 3: Exit\n");

            CashCounter cashCounter = new CashCounter();
            Queue queue = new Queue();

            Random random = new Random();
            int user = random.Next(1, 11);
            Console.WriteLine(user + " Users are in Cash Counter queue ");
            for (int i = 1; i <= user; i++)
            {
                int option = random.Next(1, 3);

                switch (option)
                {
                    case 1:
                        queue.Enqueue(i);
                        cashCounter.Withdraw();
                        break;
                    case 2:
                        queue.Enqueue(i);
                        cashCounter.Deposit();
                        break;
                    default:
                        Console.WriteLine("please enter correct option");
                        break;
                }

            }
        }
    }
}
