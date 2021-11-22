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
        public List<string> numberNamesList = new List<string>();


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

            var numbers = new List<int> { 1, 8, 3, 2, 5 };
            int maxNumber = numbers.Last();

            allFridaysLINQlist.Add(maxNumber.ToString());
        }

        public void CreateFirstFridayLINQTest()
        {
            // Testing with LINQ
            string[] nums = { "One",
                              "Two",
                              "Three",
                              "Four",
                              "Five",
                              "Six",
                              "Seven",
                              "Eight",
                              "Nine",
                              "Ten",
                              "Eleven",
                              "Twelve",
                              "Thirteen",
                              "Fourteen",
                              "Fifteen",
                              "Sixteen",
                              "Seventeen"
                           };
            //Linq query  
            IEnumerable<string> numberNames = from i in nums
                                              where i.StartsWith("F")
                                                select i;
            foreach (var num in numberNames)
            {
                numberNamesList.Add(num);
            }

        }

        public void CreateFirstFridayLINQTest2()
        {
            // Testing with LINQ
            string[] nums = { "One",
                              "Two",
                              "Three",
                              "Four",
                              "Five",
                              "Six",
                              "Seven",
                              "Eight",
                              "Nine",
                              "Ten",
                              "Eleven",
                              "Twelve",
                              "Thirteen",
                              "Fourteen",
                              "Fifteen",
                              "Sixteen",
                              "Seventeen"
                           };

            var result = nums.Skip(5);
            numberNamesList.Clear();
            foreach (var num in result)
            {
                numberNamesList.Add(num);
            }

        }

        public void CreateFirstFridayLINQTest3()
        {
            // Testing with LINQ
            int[] nums = {    78,
                              432,
                              4,
                              12,
                              54,
                              543,
                              7,
                              1,
                              83,
                              92,
                              23,
                              23,
                              14,
                           };

            var result = nums.Average();
            numberNamesList.Clear();

            numberNamesList.Add(result.ToString());

        }

        
        public void CreateFirstFridayLINQTest4()
        {
            // Testing with LINQ
            int[] nums = {    78,
                              432,
                              4,
                              12,
                              54,
                              543,
                              7,
                              1,
                              83,
                              92,
                              23,
                              23,
                              14,
                           };

            // Query LINQ
            var res = from n in nums
                      where n > 60
                      orderby n
                      select n.ToString();

            numberNamesList.Clear();

            // Lambda LINQ
            var rus = nums.Where(n => n > 60)
                          .OrderBy(n => n)
                          .Select(n => n.ToString());

            // Both give SAME result

            foreach (var i in res)
            {
                numberNamesList.Add(i);
            }

        }

        public void CreateFirstFridayLINQTest5()
        {
            numberNamesList.Clear();

            string[] nums = {
                              "Two",
                              "Three",
                              "Ten",
                              "Twelve",
                              "Thirteen",
                              "Million",
                              "Thirty"
                           };

            
            var res = nums.All(n => n.StartsWith("T")); // Does all start with letter T ?

            
            numberNamesList.Add(res.ToString()); // result
            

        }
    }
}
