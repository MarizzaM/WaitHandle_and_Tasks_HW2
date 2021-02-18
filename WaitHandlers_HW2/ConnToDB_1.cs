using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitHandlers_HW2
{
    class ConnToDB_1
    {
        private AutoResetEvent are = new AutoResetEvent(false);

        private static Random r = new Random();

        public void CreateOrder()
        {
            are.WaitOne();
            Console.WriteLine("Created the order");
        }

        public void ReadOrder()
        {
            are.WaitOne();
            Console.WriteLine("Readed the order");
        }

        public void UpdateOrder()
        {
            are.WaitOne();
            Console.WriteLine("Updated the order");
        }

        public void DeleteOrder()
        {
            are.WaitOne();
            Console.WriteLine("Deleted the order");
        }

        public void ConnectToDB()
        {
            Console.WriteLine("New Connection...");
            Thread.Sleep(4000);
            Console.WriteLine("Successful");
            are.Set();
        }
    }
}
