using System;

namespace Assignment2_Part2
{
    class BalanceLogger
    {
        // This is the implementation of the event balanceChanged 
        public void balanceLog(decimal amount)
        {
            Console.WriteLine("The balance amount is {0}", amount);
        }
    }
}
