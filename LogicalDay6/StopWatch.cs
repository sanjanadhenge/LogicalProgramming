using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class StopWatch
    {
        public void Run()
        {
            const string start = "Start", Stop = "Stop";
            Console.WriteLine("Enter Start to start the watch");
            string START = Console.ReadLine();
            TimeSpan timeSpan = TimeSpan.Zero;
            if (start.Equals(START))
                {
                     int Hour1 = timeSpan.Hours;
                     int Min1 = timeSpan.Minutes;
                     int Sec1 = timeSpan.Seconds;
                     int Millisec1 = timeSpan.Milliseconds;
                Console.WriteLine("Enter Stop to Stop the watch");
                string STOP = Console.ReadLine();
                if (Stop.Equals(STOP))
                {
                    int Hour2 = timeSpan.Hours;
                    int Min2 = timeSpan.Minutes;
                    int Sec2 = timeSpan.Seconds;
                    int Millisec2 = timeSpan.Milliseconds;
                    Console.WriteLine("StopWatch Time" + (Hour2 - Hour1) +" "+ (Min2 - Min1) +" "+ (Sec2 - Sec1) +" "+ (Millisec2 - Millisec1)); 
                }

            }


        }

    }

}
