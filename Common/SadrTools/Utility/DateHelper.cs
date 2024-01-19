using SadrTools.Extension;
using System;
using System.Globalization;

namespace SadrTools.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class DateHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToPersianDate(DateTime date)
        {
            // 2023/12/08 ==> 1402/09/17
            // 2023/12/8 ==>  1402/09/07

            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToPersianDate2(DateTime date)
        {
            // 2023/12/08 ==> 1402/09/17
            // 2023/12/8 ==>  1402/09/07

            /*
            string tmp = 123;

            string tmp2 = 123.ToString();

            string tmp3 = 123.ToString() + " salam ";

            string tmp4 = 123 + " salam ";
            */

            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2,'0')}/" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2,'0')}";
      
        }



        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate3(DateTime date, char separator)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }

        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate4(DateTime date, char separator='/')
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }

        private static string GetDayOfWeekTitle(DateTime date)
        {
            var dayofWeek = date.DayOfWeek;
            switch (dayofWeek)
            {
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه_شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنج_شنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                default:
                    return "";
            }
        }

        /// <summary>
        /// تاریخ امروز به شمسی
        /// </summary>
        /// <returns></returns>
        public static string GetTodayPersianDate(char seprator = '-')
        {
            return DateTime.Now.ToPersianDate(seprator);
        }

        public static string GetTodayTime()
        {
            return DateTime.Now.ToLongTimeString();
        }


        /// <summary>
        /// چندمین روز ماه
        /// </summary>
        /// <param name="dayNumber">شماره روز</param>
        /// <returns></returns>
        internal static string DayName(string dayNumber)
        {
            switch (dayNumber)
            {
                case "01":
                    return "یکم";

                case "02":
                    return "دوم";

                case "03":
                    return "سوم";

                case "04":
                    return "چهارم";

                case "05":
                    return "پنجم";

                case "06":
                    return "ششم";

                case "07":
                    return "هفتم";

                case "08":
                    return "هشتم";

                case "09":
                    return "نهم";

                case "10":
                    return "دهم";

                case "11":
                    return "یازدهم";

                case "12":
                    return "دوازدهم";

                case "13":
                    return "سیزدهم";

                case "14":
                    return "چهاردهم";

                case "15":
                    return "پانزدهم";

                case "16":
                    return "شانزدهم";

                case "17":
                    return "هفدهم";

                case "18":
                    return "هجدهم";

                case "19":
                    return "نوزدهم";

                case "20":
                    return "بیستم";

                case "21":
                    return "بیست و یکم";

                case "22":
                    return "بیست و دوم";

                case "23":
                    return "بیست و سوم";

                case "24":
                    return "بیست و چهارم";

                case "25":
                    return "بیست و پنجم";

                case "26":
                    return "بیست و ششم";

                case "27":
                    return "بیست و هفتم";

                case "28":
                    return "بیست و هشتم";

                case "29":
                    return "بیست و نهم";

                case "30":
                    return "سی ام";

                case "31":
                    return "سی ویکم";

                default:
                    return "";
            }
        }

        /// <summary>
        /// نام ماه فارسی
        /// </summary>
        /// <param name="monthNumber">شماره ماه</param>
        /// <returns></returns>
        internal static string MonthName(string monthNumber)
        {
            switch (monthNumber)
            {
                case "01":
                    return "فروردين"; ;

                case "02":
                    return "ارديبهشت";

                case "03":
                    return "خرداد";

                case "04":
                    return "تير";

                case "05":
                    return "مرداد";

                case "06":
                    return "شهريور";

                case "07":
                    return "مهر";

                case "08":
                    return "آبان";

                case "09":
                    return "آذر";

                case "10":
                    return "دی";

                case "11":
                    return "بهمن";

                case "12":
                    return "اسفند";

                default:
                    return "";
            }
        }

        /// <summary>
        /// ساعت الان
        /// </summary>
        /// <param name="format">فرمت خروجی</param>
        /// <returns></returns>
        public static string Hour(string format = "hh:mm:ss")
        {
            return DateTime.Now.ToString(format);
        }

        public static class StaticValues
        {
            public static readonly string Year = "سال";

            public static readonly string Month = "ماه";

            public static readonly string Day = "روز";

            /// <summary>
            /// امروز
            /// </summary>
            public static readonly string Today = "امروز";

        }

    }
}