using System;
using System.Threading;

class Program
{
    static int sharedCounter = 0;
    static int sharedCounterFixed = 0;
    static int iterations = 1_000_000;

    static void IncrementWithoutLock()
    {
        for (int i = 0; i < iterations; i++)
        {
            // Non-thread-safe increment — causes race condition
            sharedCounter++;
        }
    }

    static void IncrementWithInterlocked()
    {
        for (int i = 0; i < iterations; i++)
        {
            // Thread-safe increment using Interlocked
            Interlocked.Increment(ref sharedCounterFixed);
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Without Synchronization (Race Condition) ===");
        sharedCounter = 0;

        Thread[] threads1 = new Thread[4];
        for (int i = 0; i < 4; i++)
        {
            threads1[i] = new Thread(IncrementWithoutLock);
            threads1[i].Start();
        }

        foreach (var t in threads1)
            t.Join();

        Console.WriteLine($"Expected: {iterations * 4}");
        Console.WriteLine($"Actual (without Interlocked): {sharedCounter}");

        Console.WriteLine("\n=== With Interlocked.Increment() ===");
        sharedCounterFixed = 0;

        Thread[] threads2 = new Thread[4];
        for (int i = 0; i < 4; i++)
        {
            threads2[i] = new Thread(IncrementWithInterlocked);
            threads2[i].Start();
        }

        foreach (var t in threads2)
            t.Join();

        Console.WriteLine($"Expected: {iterations * 4}");
        Console.WriteLine($"Actual (with Interlocked): {sharedCounterFixed}");
    }
}
