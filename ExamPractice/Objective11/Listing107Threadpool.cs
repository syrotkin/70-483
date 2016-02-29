using System;
using System.Threading;

namespace Objective11 {

    public class Listing107Threadpool {
        public static void Listing107Main() {
            // Fire and forget
            ThreadPool.QueueUserWorkItem((a) => { Console.WriteLine("Working in a threadpool"); });
            // Warning: Threadpool threads reuse their local state.

            Console.ReadLine();
        }

    }

}