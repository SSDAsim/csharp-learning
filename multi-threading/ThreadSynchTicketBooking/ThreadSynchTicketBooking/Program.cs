using System;
using System.Threading;

namespace ThreadSynchTicketBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookMyShow myShow = new BookMyShow();

            Thread t1 = new Thread(myShow.TicketBooking)
            {
                Name = "Thread1"
            };

            Thread t2 = new Thread(myShow.TicketBooking)
            {
                Name = "Thread2"
            };

            Thread t3 = new Thread(myShow.TicketBooking)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }

    class BookMyShow
    {
        int i = 1, j = 2, k = 3;
        int AvailableTickets = 3;

        private object objLock = new object();
        public void BookTicket(string name, int wantedTickets)
        {
            lock (objLock) // if we do not lock this, then we will have inconsistency in ticket booking
            {
                if (wantedTickets <= AvailableTickets)
                {
                    Console.WriteLine(wantedTickets + " booked to " + name);
                    AvailableTickets -= wantedTickets;
                }
                else
                {
                    Console.WriteLine("No tickets available to book");
                }
            }
        }
        public void TicketBooking()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("Thread1"))
            {
                BookTicket(name, i);
            } else if (name.Equals("Thread2"))
            {
                BookTicket(name, j);
            } else
            {
                BookTicket(name, k);
            }
        }
    }
}
