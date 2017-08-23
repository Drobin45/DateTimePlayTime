using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePlayTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Today);
           // Console.WriteLine("Today: {0}", DateTime.Today);

            DateTime yesterday = GetYesterday();
           //Console.WriteLine("Yesterday: {0}", yesterday);
            
            DateTime tomorrow = GetTomorrow();
            //Console.WriteLine("Tomorrow: {0}", tomorrow);

            DateTime CurrentDay = DateTime.Now;
            int day1 = (int)CurrentDay.DayOfWeek;

           //switch(DayOfWeek) Look up this method(?)!

           // Console.WriteLine("Today is " +);
           //Console.WriteLine("Tomorrow is " +);
           //Console.WriteLine("Yesterday was " +);


            //Methods Section below------------------------------------------------
        }
        static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
