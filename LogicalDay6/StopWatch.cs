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
            DateTime timeSpan = DateTime.Now;
            if (start.Equals(START))
                {
                     int Hour1 = timeSpan.Hour;
                     int Min1 = timeSpan.Minute;
                     int Sec1 = timeSpan.Second;
                     int Millisec1 = timeSpan.Millisecond;
                Console.WriteLine("Enter Stop to Stop the watch");
                string STOP = Console.ReadLine();
                if (Stop.Equals(STOP))
                {
                    DateTime timeSpan1 = DateTime.Now;
                    int Hour2 = timeSpan1.Hour;
                    int Min2 = timeSpan1.Minute;
                    int Sec2 = timeSpan1.Second;
                    int Millisec2 = timeSpan1.Millisecond;
                    Console.WriteLine("StopWatch Time" + (Hour2 - Hour1) +" "+ (Min2 - Min1) +" "+ (Sec2 - Sec1) +" "+ (Millisec2 - Millisec1)); 
                }

            }


        }

    }

}
