using System;
using System.Threading;

namespace Stopwatch
{
    public class Stopwatch
    {
        public static void Main(string[] args)
        {
            int s = 0, m = 0, h = 0;
            // DateTime Timestamp = DateTime.Now;
            TimeSpan Timestamp = new TimeSpan(0, 1, 10);
            TimeSpan Time = new TimeSpan(0, 0, 50);
            double TimestampInt = Timestamp.TotalSeconds;
            double TimeInt = Time.TotalSeconds;

            while (TimeInt < TimestampInt)
            {
                Thread.Sleep(1000);
                var currentTime = Time.Add(new TimeSpan(0, 0, ++s));
                Console.Write("\r" + currentTime);
                TimeInt++;
            }
        }
    }
}