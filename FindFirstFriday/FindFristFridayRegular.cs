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
        public void CreateDateDays()
        {
            for (int i = 1; i < 7; i++)
            {
                // new date days
                
                DateTime timeDate = new DateTime(2021, 9, i);
                if (timeDate.ToString("dddd") == "Friday")
                {
                    Debug.WriteLine("Friday is " + timeDate.Day);
                    break;
                }
                
            }
        }
    }
}
