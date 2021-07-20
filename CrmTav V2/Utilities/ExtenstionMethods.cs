using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Utilities
{
    public static class ExtenstionMethods
    {

        public static string ToPersian(this DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();
            return calendar.GetYear(date).ToString() + '/' + calendar.GetMonth(date) + '/' + calendar.GetDayOfMonth(date);
        }

        public static DateTime ToDateTime(this string date)
        {
            PersianCalendar calendar = new PersianCalendar();
            string[] dateArray = date.Split('/');
            return calendar.ToDateTime(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]),
                Convert.ToInt32(dateArray[2]), 0, 0, 0, 0);
        }
    }
}
