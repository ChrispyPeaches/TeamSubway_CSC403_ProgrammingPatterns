using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC_403_DesignPatterns_Proxy_ElijahPayton;

namespace CSC_403_DesignPatterns_Proxy_ElijahPayton
{
    // BankAccount class representing the obfuscated object
    public class BankAccount : IMoney
    {
        int money = 12345;

        // Subtract amount from money and print old/new balance
        public void Spend(int amount)
        {
            int oldBalance = money;
            money -= amount;
            Console.WriteLine("Transaction Succeeded.");
            Console.WriteLine("Amount Spent: $" + amount.ToString());
            Console.WriteLine("Old Balance: $" + oldBalance.ToString());
            Console.WriteLine("New Balance: $" + money.ToString());
        }
    }
}
