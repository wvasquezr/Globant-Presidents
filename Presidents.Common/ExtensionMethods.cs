/***********************************************************************
ABIE Development team
***********************************************************************/

using System;

namespace Presidents.Common
{
    public static class ExtensionMethods
    {
        public const string NullString = "\\N";

        public static string StripNullString(this string input)
        {
            return input == null ? null : input.Equals(NullString, StringComparison.OrdinalIgnoreCase) ? null : input;
        }

        public static DateTime ValidateDateTime(this string input)
        {
            DateTime.TryParse(input, out var result);
            return result;
        }

        public static DateTime? ValidateNullDateTime(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            DateTime.TryParse(input, out var result);
            return result;
        }
    }
}