using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public delegate void BalanceEventHandler(decimal theValue);

    class PiggyBank
    {
        private decimal m_bankBalance;
        // Declaring a public event called balancedChanged which is referd to it
        // using the delegate BalanceEventHandler
        // This is considered as an action listener referd to it using
        // the delegate BalanceEventHandler
        public event BalanceEventHandler balanceChanged;

        // public getter and setter for the private member variable m_bankBalance property
        public decimal theBalance
        {
            set // Once setting the value of the balance then trigger the 
                // event balanceChanged to update the new bank account balance
            {
                m_bankBalance = value; //value is the received argument from the place where we
                                        // pass this value (PSVM)
                balanceChanged(value);// Any new value posted (being set), trigger the event.
            }
            get
            {
                return m_bankBalance;
            }
        }
    }

    class BalanceLogger
    {
        // This is the implementation of the event balanceChanged 
        public void balanceLog(decimal amount)
        {
            Console.WriteLine("The balance amount is {0}", amount);
        }
    }

    class BalanceWatcher
    {
        // This is another implementation of the event balanceChanged
        public void balanceWatch(decimal amount)
        {
            if (amount > 500.0m)
                Console.WriteLine("You reached your savings goal! You have {0}", amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PiggyBank pb = new PiggyBank();
            BalanceLogger bl = new BalanceLogger();
            BalanceWatcher bw = new BalanceWatcher();

            // Triggering the balacedChanged event listener. 
            // That means this event is ready to implpement balanceLog method &
            // belanceWatch method once it is called from the setter of the m_bankBalance

            pb.balanceChanged += bl.balanceLog; // By implementing the balanceLog method
            pb.balanceChanged += bw.balanceWatch; // By implementing the balanceWatch method

            string theStr;
            do
            {
                Console.WriteLine("How much to deposit?");

                theStr = Console.ReadLine();
                if (!theStr.Equals("exit"))
                {
                    decimal newVal = decimal.Parse(theStr);

                    pb.theBalance += newVal;
                }
            } while (!theStr.Equals("exit"));
            Console.WriteLine("Your current balance after those transactions is: ${0}",pb.theBalance);
            Console.ReadLine();

        }
    }
}
