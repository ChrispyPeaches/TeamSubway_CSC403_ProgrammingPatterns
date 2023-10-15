using System;
using CSC_403_DesignPatterns_Proxy_ElijahPayton;

// Coder: Elijah Payton
// Design Pattern: Proxy

class Program
{
    static void Main(string[] args)
    {
        // Create CreditCard object with correct pin
        IMoney creditCard1 = new CreditCard(1234);

        // Admin requests access to the RealObject through the ObjectProxy
        creditCard1.Spend(50);

        // Create CreditCard object with incorrect pin
        CreditCard creditCard2 = new CreditCard(4321);

        // User attempts to spend money using proxy but fails
        creditCard2.Spend(50);
    }
}