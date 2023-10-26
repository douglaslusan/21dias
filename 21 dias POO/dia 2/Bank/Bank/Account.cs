using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        private double Ballance { get; set; }

        public Account()
        {
        }

        public Account(double inicialDeposit)
        {
            Ballance = inicialDeposit;
        }

        public void DepositFunds(double funds)
        {
            Ballance += funds;
        }

        public void WithdrawFunds(double funds)
        {
            if (funds > Ballance)
            {
                funds = Ballance;
                Ballance -= funds;
            }
            else
                Ballance -= funds;
        }

        public double GetBalance()
        {
            return Ballance;
        }
    }
}
