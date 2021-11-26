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

                    DateTime dateTime = new DateTime(year, j, i);
                    if (dateTime.ToString("dddd") == "Friday")
                    {
                        allFridaysList.Add(dateTime.ToString("MMMM") + " " + dateTime.Day);
                        break;
                    }
                }
            }
        }
    }
}
