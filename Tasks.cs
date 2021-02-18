using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Task<int> t = new Task<int>(() => {
                int timeSleep = r.Next(1000, 2000);
                Thread.Sleep(timeSleep);
                Console.WriteLine("Good Morning!");
                return timeSleep;
            }, TaskCreationOptions.LongRunning);

            t.Start();

            Console.WriteLine($"result is {t.Result}");

            Task<int> t1 = new Task<int>(() =>
            {
                int timeSleep = r.Next(1000, 2000);
                Thread.Sleep(timeSleep);
                Console.WriteLine("Hello!");
                return timeSleep;
            }, TaskCreationOptions.LongRunning);

            Task<int> t2 = new Task<int>(() =>
            {
                int timeSleep = r.Next(1000, 2000);
                Thread.Sleep(timeSleep);
                Console.WriteLine("Bye!");
                return timeSleep;
            }, TaskCreationOptions.LongRunning);

            t1.Start();
            t2.Start();

            Task.WaitAny(t1, t2);
            //We cannot manage, but we can find out which of the tasks ended, for example by adding  Console.WriteLine();
        }
    }
}
