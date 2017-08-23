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
            DateTime CurrentDay = DateTime.Now;
            int day1 = (int)CurrentDay.DayOfWeek;          

            string dayOne = " ";            
           switch (day1)
            {
                case 1:
                    dayOne = "Today is Monday";
                break;
                case 2:
                    dayOne = "Today is Tuesday";
                    break;
                case 3:
                    dayOne = "Today is Wednesday";
                    break;
                case 4:
                    dayOne = "Today is Thursday";
                    break;
                case 5:
                    dayOne = "Today is Friday";
                    break;
                case 6:
                    dayOne = "Today is Saturday";
                    break;
                case 7:
                    dayOne = "Today is Sunday";
                    break;
            }
            Console.WriteLine(dayOne);


            DateTime tomorrow = GetTomorrow();          
            int tom1 = (int)tomorrow.DayOfWeek;
            
            string tomOne = " ";
            switch (tom1)
            {
                case 1:
                    tomOne = "Tomorrow is Monday";
                    break;
                case 2:
                    tomOne = "Tomorrow is Tuesday";
                    break;
                case 3:
                    tomOne = "Tomorrow is Wednesday";
                    break;
                case 4:
                    tomOne = "Tomorrow is Thursday";
                    break;
                case 5:
                    tomOne = "Tomorrow is Friday";
                    break;
                case 6:
                    tomOne = "Tomorrow is Saturday";
                    break;
                case 7:
                    tomOne = "Tomorrow is Sunday";
                    break;
            }
            Console.WriteLine(tomOne);

            DateTime yesterday = GetYesterday();

            //translate to tomorrow

            int tom1 = (int)tomorrow.DayOfWeek;

            string tomOne = " ";
            switch (tom1)
            {
                case 1:
                    tomOne = "Tomorrow is Monday";
                    break;
                case 2:
                    tomOne = "Tomorrow is Tuesday";
                    break;
                case 3:
                    tomOne = "Tomorrow is Wednesday";
                    break;
                case 4:
                    tomOne = "Tomorrow is Thursday";
                    break;
                case 5:
                    tomOne = "Tomorrow is Friday";
                    break;
                case 6:
                    tomOne = "Tomorrow is Saturday";
                    break;
                case 7:
                    tomOne = "Tomorrow is Sunday";
                    break;
            }
            Console.WriteLine(tomOne);

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
