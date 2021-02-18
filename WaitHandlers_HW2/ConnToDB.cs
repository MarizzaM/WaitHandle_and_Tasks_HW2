using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitHandlers_HW2
{
    class ConnToDB
    {
        private ManualResetEvent mre = new ManualResetEvent(false);

        private static Random r = new Random();

        public void CreateOrder() {
            mre.WaitOne();
            Console.WriteLine("Created the order");
        }

        public void ReadOrder() {
            mre.WaitOne();
            Console.WriteLine("Readed the order");
        }

        public void UpdateOrder() {
            mre.WaitOne();
            Console.WriteLine("Updated the order");
        }

        public void DeleteOrder() {
            mre.WaitOne();
            Console.WriteLine("Deleted the order");
        }

        public void ConnectToDB() {
            Console.WriteLine("Connection...");
            Thread.Sleep(4000);
            Console.WriteLine("Successful");
            mre.Set();
        }
    }
}
