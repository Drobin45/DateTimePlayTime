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
            //Problem 1. Complete!
            // Console.WriteLine(DateTime.Today);              
            // DateTime CurrentDay = DateTime.Now;
            // int day1 = (int)CurrentDay.DayOfWeek;          

            // string dayOne = " ";            
            //switch (day1)
            // {
            //     case 1:
            //         dayOne = "Today is Monday";
            //     break;
            //     case 2:
            //         dayOne = "Today is Tuesday";
            //         break;
            //     case 3:
            //         dayOne = "Today is Wednesday";
            //         break;
            //     case 4:
            //         dayOne = "Today is Thursday";
            //         break;
            //     case 5:
            //         dayOne = "Today is Friday";
            //         break;
            //     case 6:
            //         dayOne = "Today is Saturday";
            //         break;
            //     case 7:
            //         dayOne = "Today is Sunday";
            //         break;
            // }
            // Console.WriteLine(dayOne);


            // DateTime tomorrow = GetTomorrow();          
            // int tom1 = (int)tomorrow.DayOfWeek;

            // string tomOne = " ";
            // switch (tom1)
            // {
            //     case 1:
            //         tomOne = "Tomorrow is Monday";
            //         break;
            //     case 2:
            //         tomOne = "Tomorrow is Tuesday";
            //         break;
            //     case 3:
            //         tomOne = "Tomorrow is Wednesday";
            //         break;
            //     case 4:
            //         tomOne = "Tomorrow is Thursday";
            //         break;
            //     case 5:
            //         tomOne = "Tomorrow is Friday";
            //         break;
            //     case 6:
            //         tomOne = "Tomorrow is Saturday";
            //         break;
            //     case 7:
            //         tomOne = "Tomorrow is Sunday";
            //         break;
            // }
            // Console.WriteLine(tomOne);

            // DateTime yesterday = GetYesterday();

            // //translate to tomorrow

            // int yest1 = (int)yesterday.DayOfWeek;

            // string yestOne = " ";
            // switch (yest1)
            // {
            //     case 1:
            //         yestOne = "Yesterday was Monday";
            //         break;
            //     case 2:
            //         yestOne = "Yesterday was Tuesday";
            //         break;
            //     case 3:
            //         yestOne = "Yesterday was Wednesday";
            //         break;
            //     case 4:
            //         yestOne = "Yesterday was Thursday";
            //         break;
            //     case 5:
            //         yestOne = "Yesterday was Friday";
            //         break;
            //     case 6:
            //         yestOne = "Yesterday was Saturday";
            //         break;
            //     case 7:
            //         yestOne = "Yesterday was Sunday";
            //         break;
            // }
            // Console.WriteLine(yestOne);

            //switch(DayOfWeek) Look up this method(?)!

            // Console.WriteLine("Today is " +);
            //Console.WriteLine("Tomorrow is " +);
            //Console.WriteLine("Yesterday was " +);

            //-----------------------------------------------------------------------
            //Problem 2. Complete!
            //Create a DateTime instance that shows your birthday by the day of the year it is. Ex. Jan 5th, would be the fifth day of the year
            //My birthday is May 12th, so it will be the 132nd day of the year
            //To print "My birthday is the 132 day of the year."            

            //DateTime myBirthday = new DateTime(2017, 5, 12);
            //DateTime newYear = new DateTime(2017, 1, 1);
            //TimeSpan numberOfDays = myBirthday.Subtract(newYear);
            //double daysPast = numberOfDays.TotalDays;     

            //Console.WriteLine("My birthday is the " + daysPast + " day of the year.");        

            //-----------------------------------------------------------------------

            //Problem 3. Complete!
            //Create app that shows the ammount of days in a month
            //int month = 9;
            //int year = 2017;
            //int days = DateTime.DaysInMonth(year, month);
            //Console.WriteLine(days);

            //-----------------------------------------------------------------------
            //Problem 4


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
