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
        public void CreateFirstFriDays()
        {

            for (int j = 1; j < 13; j++)
            {
                for (int i = 1; i < 8; i++)
                {
                    // new date days

                    DateTime timeDate = new DateTime(2021, j, i);
                    if (timeDate.ToString("dddd") == "Friday")
                    {

                        Debug.WriteLine(timeDate.ToString("MMMM") + " " + timeDate.Day);
                        break;
                    }
                }
            }
        }
    }
}
