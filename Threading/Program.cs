using System;
using System.Threading;
using System.Diagnostics;


namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("How many throws would you like for each thread? ");
            int amountDarts = Int32.Parse(Console.ReadLine());
            Console.Write("How many thread would you like to simulate? ");
            int amountThreads = Int32.Parse(Console.ReadLine());
            List<Thread> threads = new List<Thread>();
            List<FindPiThread> findPiThreads = new List<FindPiThread>();
            Stopwatch s = new Stopwatch();
            s.Start();
            for(int i = 0; i < amountThreads; i++)
            {
                findPiThreads.Add(new FindPiThread(amountDarts));
                threads.Add(new Thread(new ThreadStart(findPiThreads[i].throwDarts)));
                threads[i].Start();
                Thread.Sleep(16);
            }
            foreach(Thread thread in threads)
            {
                thread.Join();
            }
            foreach (FindPiThread i in findPiThreads) {
                sum += i.numDartsHit;
            }
            double estimation_of_pi = ((4 * Convert.ToDouble(sum)) / (amountThreads * amountDarts));
            s.Stop();
            Console.WriteLine(estimation_of_pi);
            Console.WriteLine("Time: " + s.ElapsedMilliseconds + "ms");
            Console.ReadKey();
        }
    }
}