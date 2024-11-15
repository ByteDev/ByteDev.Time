using System;

namespace ByteDev.Time
{
    internal static class StringExtensions
    {
        public static string Pluralize(this string source, int number)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            number = Math.Abs(number); // -1 should be singular, too

            return number == 1 ? source : source + "s";
        }
    }
}

