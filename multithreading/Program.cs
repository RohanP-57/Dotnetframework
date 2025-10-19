/*using System;
using System.Threading;

class WithoutLockExample
{
    static int counter = 0;

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter (Without Lock): " + counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 1_00_000; i++)
        {
            // Multiple threads access counter simultaneously
            counter++;
        }
    }
}*/

/*using System;
using System.Threading;

class WithLockExample
{
    static int counter = 0;
    static readonly object locker = new object();

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter (With Lock): " + counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 100000; i++)
        {
            lock (locker)
            {
                counter++;
            }
        }
    }
}*/

using System;
using System.Threading;

class LockDeadlock
{
    static readonly object resourceA = new object();
    static readonly object resourceB = new object();

    static void Main()
    {
        Thread t1 = new Thread(Thread1Work);
        Thread t2 = new Thread(Thread2Work);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Both threads completed.");
    }

    static void Thread1Work()
    {
        lock (resourceA)
        {
            Console.WriteLine("Thread 1: locked Resource A");
            Thread.Sleep(5000); // simulate work while holding A

            // Now tries to lock B — will block if another thread holds B
            lock (resourceB)
            {
                Console.WriteLine("Thread 1: locked Resource B");
                Console.WriteLine("Thread 1: working with A and B");
            }
            // Releases resourceB automatically
        }
        // Releases resourceA automatically
    }

    static void Thread2Work()
    {
        lock (resourceB)
        {
            Console.WriteLine("Thread 2: locked Resource B");
            Thread.Sleep(5000); // simulate work while holding B

            // Now tries to lock A — will block if another thread holds A
            lock (resourceA)
            {
                Console.WriteLine("Thread 2: locked Resource A");
                Console.WriteLine("Thread 2: working with B and A");
            }
            // Releases resourceA automatically
        }
        // Releases resourceB automatically
    }
}