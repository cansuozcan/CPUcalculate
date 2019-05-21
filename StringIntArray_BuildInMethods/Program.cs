using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StringIntArray_BuildInMethods
{
    class Program
        
    {
        private static PerformanceCounter cpu;

        static void Main(string[] args)
        {
            cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            Timer kronometre = new Timer();
            kronometre.Interval = 1000;
            kronometre.Elapsed += OnTimedEvent;
            kronometre.Start();
            Console.ReadKey();
            
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Console.WriteLine("asd");
            PrintCpuUsageToConsole(e.SignalTime);
            

        }
        static void PrintCpuUsageToConsole(DateTime signalTime)
        {
            string formatlanmis = String.Format("Cpu Usage {0} % Time: {1}",cpu.NextValue(),signalTime.ToString());

            //System.Diagnostics.PerformanceCounterCategory.GetCategories();
            // Console.WriteLine("Cpu Usage" + cpu.NextValue() + "%" + "Time:" + signalTime.ToString());
            Console.WriteLine(formatlanmis);
        }
    }
}
