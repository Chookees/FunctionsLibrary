using System;

namespace Functions
{
    /// <summary>
    /// Class of functions for DateTime. (Date)
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class Date
    {
        /// <summary>
        /// Get the current Date as String "XX-XX-XXXX"
        /// </summary>
        /// <returns> |Type: string| </returns>
        public static string GetCurrentDateAsString()
        {
            return DateTime.Today.ToLongDateString();
        }

        /// <summary>
        /// Get the current time as String
        /// </summary>
        /// <returns> |Type: string| </returns>
        public static string GetCurrentTimeAsString()
        {
            return DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Get true or false whether a year is a leap year
        /// </summary>
        /// <param name="year">Year as Integer</param>
        /// <returns> |Type: bool| </returns>
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Compare Date1 with Date2 to get true when Date1 is newer.
        /// String format should be "XX-XX-XXXX"
        /// </summary>
        /// <param name="date1">The "is this newer" than</param>
        /// <param name="date2">this</param>
        /// <returns> |Type: bool| </returns>
        public static bool IsNewerFromString(string date1, string date2)
        {
            return DateTime.Parse(date1) > DateTime.Parse(date2);
        }
    }
}
