using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    internal class DateTimeCase
    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hour = now.Hour;
                int minute = now.Minute;
                int second = now.Second;

                // only date
            DateTime onlyDate = now.Date;
                Console.WriteLine($"Only Date : {onlyDate}");

                //dayOfWeek
                DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek kamis = DayOfWeek.Thursday;

                //addDays
            DateTime tomorrow = now.AddDays(2);

                //selisih hari
                             TimeSpan dateDifference = tomorrow - now;
                int daysRemaining = dateDifference.Days;
                             Console.WriteLine($"{now} - {tomorrow},selisih : {daysRemaining}");

            // store     spesific date
            DateTime birthDay = new DateTime(1998, 10, 21);
        }   
    }   
}
