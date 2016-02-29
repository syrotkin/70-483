using System;
using System.Threading.Tasks;

namespace Objective11 {

    public class Listing108NewTask {

        public static void Listing108Main() {
            var task = Task.Run(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(i);
                }
            });
            task.Wait(); // Wait on a Task is like a Join on a Thread
        }

        public static void TryWithResult() {
            
        
        }

    }
}