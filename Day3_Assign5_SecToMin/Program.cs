using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assign5_SecToMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of seconds you would like to convert into days, hours, minutes, and seconds:");
            string stringSec = System.Console.ReadLine();
            int sec = int.Parse(stringSec);

            int a = sec % 86400;
            int hours = a / 3600;
            int b = a % 3600;
            int minutes = b /60;
            int c = b % 60;
            int remainSec = c;
            System.Console.WriteLine(sec + " seconds is equal to " + sec/ 86400 + " days " + hours + " hours " + minutes + " minutes and " + remainSec + " seconds.");
            // 1 day = 86,400 seconds;  1 hour = 3600 seconds; 1 minute = 60 seconds
            System.Console.ReadKey();
        }
    }
}
