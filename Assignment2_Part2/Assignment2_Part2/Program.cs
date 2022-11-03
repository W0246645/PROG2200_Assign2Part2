using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public delegate void BalanceEventHandler(decimal theValue);

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
            pb.negBalancedChanged += delegate (object sender, BalanceArgs e)
            {
                Console.WriteLine("Balance has gone below 0");
            };

            string theStr;
            do
            {
                Console.WriteLine("How much to deposit?");

                theStr = Console.ReadLine();
                if (!theStr.Equals("exit"))
                {
                    if (!decimal.TryParse(theStr, out decimal newVal))
                    {
                        Console.WriteLine("Not a valid number.");
                    } else
                    {
                        pb.theBalance += newVal;
                    }
                }
            } while (!theStr.Equals("exit"));
            Console.WriteLine("Your current balance after those transactions is: ${0}",pb.theBalance);
            Console.ReadLine();

        }
    }
}
