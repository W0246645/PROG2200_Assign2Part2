using System;

namespace Assignment2_Part2
{
    class BalanceWatcher
    {
        // This is another implementation of the event balanceChanged
        public void balanceWatch(decimal amount)
        {
            if (amount > 500.0m)
                Console.WriteLine("You reached your savings goal! You have {0}", amount);
        }
    }
}
