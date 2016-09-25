using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());
            double transport = 0.0;

            if (peopleInGroup >= 1 && peopleInGroup <= 4)
            {
                transport = 0.75 * budget;
            }
            else if (peopleInGroup >= 5 && peopleInGroup <= 9)
            {
                transport = 0.60 * budget;
            }
            else if (peopleInGroup >= 10 && peopleInGroup <= 24)
            {
                transport = 0.50 * budget;
            }
            else if (peopleInGroup >= 25 && peopleInGroup <= 49)
            {
                transport = 0.40 * budget;
            }
            else if (peopleInGroup >= 50)
            {
                transport = 0.25 * budget;
            }

            if (category == "Normal")
            {
                var ticketsMoney = peopleInGroup * 249.99;

                if (budget >= transport + ticketsMoney)
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left. ", budget - (transport + ticketsMoney));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva. ",  (transport + ticketsMoney)-budget);
                }
            }

            if (category == "VIP")
            {
                var ticketsMoney = peopleInGroup * 499.99;
                if (budget >= transport + ticketsMoney)
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left. ", budget - (transport + ticketsMoney));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva. ", (transport + ticketsMoney) - budget);
                }
            }

        }
    }
}
