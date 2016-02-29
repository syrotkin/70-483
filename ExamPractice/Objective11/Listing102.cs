using System;
using System.Threading;

namespace Objective11 {

    public class Listing102 {
        
        public static void Listing12Main() {
            var thread = new Thread(ThreadMethod) {
                IsBackground = false // if foreground, application does not terminate until all the foreground threads terminate
            };
            thread.Start();
        }

        private static void ThreadMethod() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}