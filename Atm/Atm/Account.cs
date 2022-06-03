using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    class Account
    {
        public String AccountNo;
        public String OpeningDate;
        public Double Balance;

        public Account()
        {

        }
        public double Deposit(double ammount)
        {
            return Balance + ammount;
        }

        public double Withdraw(double ammount)
        {
            return Balance - ammount;
        }
    }
}
