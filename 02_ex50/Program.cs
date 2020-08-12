using System;
using System.Threading;

namespace _02_ex50
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ThreadStuff();
        }

        private void DoStuff()
        {
            // IT DOES STUFF
        }

        private void ThreadStuff()
        {
            const int n = 100;
            Thread[] threads = new Thread[n];
            // 1. INSTANCIAR AS 100 THREADS
            for (int i = 0; i < n; i++) threads[i] = new Thread(DoStuff);
            // 2. INICIAR AS 100 THREADS
            for (int i = 0; i < n; i++) threads[i].Start();
            // 3. ESPERAR QUE A EXECUÇÃO DAS MESMAS TERMINE
            Console.ReadKey();
            for (int i = 0; i < n; i++) threads[i].Join();
        }
    }
}
