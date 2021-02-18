using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitHandlers_HW2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //ConnToDB conn = new ConnToDB();
            ConnToDB_1 conn1 = new ConnToDB_1();

            //new Thread(() => { conn.CreateOrder(); }).Start();
            //new Thread(() => { conn.ReadOrder(); }).Start();
            //new Thread(() => { conn.UpdateOrder(); }).Start();
            //new Thread(() => { conn.DeleteOrder(); }).Start();
            //new Thread(() => { conn.ConnectToDB(); }).Start();

            new Thread(() => { conn1.CreateOrder(); }).Start();
            new Thread(() => { conn1.ReadOrder(); }).Start();
            new Thread(() => { conn1.UpdateOrder(); }).Start();
            new Thread(() => { conn1.DeleteOrder(); }).Start();
            new Thread(() => { conn1.ConnectToDB(); }).Start();
        }
    }
}
