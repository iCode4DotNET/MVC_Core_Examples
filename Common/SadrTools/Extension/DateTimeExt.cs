using System.Globalization;
using System;
using SadrTools.Utility;

namespace SadrTools.Extension
{
    public static class DateTimeExt
    {
        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate(this DateTime date, char separator = '/')
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }



        /// <summary>
        /// تاریخ میلادی به عبارت فارسی و خوانای تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <returns></returns>
        public static string ToPersianText(this DateTime date)
        {
            var persianDate = date.ToPersianDate();
            var year = persianDate.Substring(0, 4);
            var month = persianDate.Substring(5, 2);
            var day = persianDate.Substring(8, 2);

            day = DateHelper.DayName(day);
            month = DateHelper.MonthName(month);
            year = year.NumberToPersianText();

            return $"{day} {month} {DateHelper.StaticValues.Month} {DateHelper.StaticValues.Year} {year} ";

        }

        /// <summary>
        /// تاریخ میلادی به عبارت فارسی و خوانای تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <returns></returns>
        public static string ToPersianTextFull(this DateTime date)
        {
            return $"{DateHelper.StaticValues.Today} {date.ToPersianDayOfWeek()} {date.ToPersianText()}";
        }

        /// <summary>
        /// تاریخ امروز به شمسی
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="seprator">جدا کننده</param>
        /// <returns></returns>
        public static string Today(this DateTime date, char seprator = '/')
        {
            // Remove unused parameter 'date' if it is not part of a shipped public API"
            return DateTime.Now.ToPersianDate(seprator);
        }


        /// <summary>
        /// روز هفته فارسی
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <returns></returns>
        public static string ToPersianDayOfWeek(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "يكشنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهار شنبه";
                default:
                    return "";
            }
        }


    }

   
}
