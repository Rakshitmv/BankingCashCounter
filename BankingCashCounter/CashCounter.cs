using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class CashCounter
    {
        public int TOTAL_BALANCE_AMT = 200000;
        public int deposit_Amt = 0;
        public int withdraw_Amt = 0;

        Queue queue = new Queue();

        public void Withdraw()
        {
            Console.WriteLine("Total Balance of your account : " + TOTAL_BALANCE_AMT);

            Console.WriteLine("Please Enter Amount for Withdraw :\n");
            withdraw_Amt = Convert.ToInt32(Console.ReadLine());

            if (withdraw_Amt > TOTAL_BALANCE_AMT)
            {
                Console.WriteLine("Insufficient balance in your account..");
            }
            else
            {
                TOTAL_BALANCE_AMT -= withdraw_Amt;
                Console.WriteLine(withdraw_Amt + " amount withdrawn from your account \n");
                Console.WriteLine("Your Avaialble Balance is :" + TOTAL_BALANCE_AMT);
            }
            queue.Dequeue();
        }

        public void Deposit()
        {
            Console.WriteLine("Total Balance of your account : " + TOTAL_BALANCE_AMT);
            Console.WriteLine("Please Enter Amount for Deposit :\n");
            deposit_Amt = Convert.ToInt32(Console.ReadLine());

            TOTAL_BALANCE_AMT += deposit_Amt;
            Console.WriteLine(deposit_Amt + " Money depositted in your account \n");
            Console.WriteLine("Now Your Avaialble Balance is :" + TOTAL_BALANCE_AMT);

            queue.Dequeue();

        }
    }
}
