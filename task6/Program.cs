using System;
using System.Threading;
namespace EventDelegate
{
    // Define the delegate type
    public delegate void ThresholdReachedHandler();

    // Counter class
    class Counter
    {
        private int count = 0;
        private int threshold;

        // Declare the event
        public event ThresholdReachedHandler ThresholdReached;

        public Counter(int threshold)
        {
            this.threshold = threshold;
        }

        public void Increment()
        {
            count++;
            Console.WriteLine($"Count: {count}");

            if (count == threshold)
            {
                // Raise the event
                ThresholdReached?.Invoke();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Counter counter = new Counter(3); 

            counter.ThresholdReached += Alert;
            counter.ThresholdReached += Log;

            // Increment 5 times
            for (int i = 0; i < 5; i++)
            {
                counter.Increment();
                Thread.Sleep(1000);
            }
        }

        // Event handler 1
        static void Alert()
        {
            Console.WriteLine(">>> ALERT: Threshold reached!");
        }

        // Event handler 2
        static void Log()
        {
            Console.WriteLine(">>> LOG: Event has been logged.");
        }
    }
}
