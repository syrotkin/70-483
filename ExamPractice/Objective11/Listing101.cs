using System;
using System.Threading;

namespace Objective11 {

    public class Listing101 {

        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0); // relinquish time slice
            }
        }

        public static void Listing11Main() {
           var t = new Thread(ThreadMethod);
            t.Start();

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Main thread: do some work.");
                Thread.Sleep(0); // relinquish time slice
            }
            t.Join();
        }

    }

}