using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Test._1
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        public BankAccount(){}

        public BankAccount(string customerName, double balance) {
            m_balance = balance;
            m_customerName = customerName;
        }


        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance;  }
        }

        public void Debit(double amount)
        {
            if(amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }


        public void Credit(double amount)
        {
            if(amount < 0) 
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);

        }

    }
}
