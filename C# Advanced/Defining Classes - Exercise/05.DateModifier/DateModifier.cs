using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int GetDifferenceBetweenTwoDates(string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);

            TimeSpan diff = end - start;

            return Math.Abs(diff.Days);
        }
    }
}
