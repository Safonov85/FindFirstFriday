using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstFriday
{
    public class FindFristFridayRegular
    {
        public List<string> allFridaysList = new List<string>();
        public List<string> allFridaysLINQlist = new List<string>();


        // Regular
        public void CreateFirstFriDays()
        {
            int year = 2018;
            allFridaysList.Add(year.ToString() + ":");

            for (int j = 1; j < 13; j++)
            {
                for (int i = 1; i < 8; i++)
                {
                    // new date days

                    DateTime timeDate = new DateTime(year, j, i);
                    if (timeDate.ToString("dddd") == "Friday")
                    {

                        //Debug.WriteLine(timeDate.ToString("MMMM") + " " + timeDate.Day);
                        allFridaysList.Add(timeDate.ToString("MMMM") + " " + timeDate.Day);
                        break;
                    }
                }
            }
        }


        // LINQ 
        public void CreateFirstFridayLINQ()
        {
            // Find First friday in a month using LINQ
            //DateTime firstSunday = new DateTime(2021, 6, 7);
            //var bookings = from b in this.db.Bookings
            //               where b.StartDateTime.DayOfWeek == DayOfWeek.Friday
            //               select b;

            var numbers = new List<int> { 1, 8, 3, 2 };
            int maxNumber = numbers.Max();

            allFridaysLINQlist.Add(maxNumber.ToString());
        }

        public void CreateFirstFridayLINQTest()
        {
            // Testing with LINQ
        }
    }
}
