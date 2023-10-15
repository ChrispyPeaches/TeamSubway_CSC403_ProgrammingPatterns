using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC_403_DesignPatterns_Proxy_ElijahPayton;

namespace CSC_403_DesignPatterns_Proxy_ElijahPayton
{
    // Credit Card class acting as a proxy to control access to bank account
    public class CreditCard : IMoney
    {
        private BankAccount _bankAccount;
        private int _pin;

        public CreditCard(int pin)
        {
            _pin = pin;
        }

        public void Spend(int amount)
        {
            // Check if pin is correct
            if (CheckPin())
            {
                if (_bankAccount == null)
                {
                    _bankAccount = new BankAccount();
                }
                // Spend money from bank
                _bankAccount.Spend(amount);
            }
            else
            {
                // Reject request if pin check fails
                Console.WriteLine("\nInvalid Pin: Authorities alerted! :P");
            }
        }

        // Check if pin is valid
        private bool CheckPin()
        {
            // Check permission
            if (_pin == 1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
