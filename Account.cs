using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Account
    {
        private protected float balance;
        public float getbalance()
        {
            return balance;
        }
    }

    internal class SavingsAccount : Account 
    {
        public void set_b(float b)
        {
            balance = b;
        }
    }
}
