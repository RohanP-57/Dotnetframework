using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(0);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        t1.Priority = ThreadPriority.AboveNormal;
        t1.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
            Thread.Sleep(0);
        }
    }
}