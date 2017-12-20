using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIOTCA3.Extensions
{
    public static class StringExtensions
    {
        public static string SubStringTo(this string thatString, int limit)
        {
            if (!String.IsNullOrEmpty(thatString))
            {
                if (thatString.Length > limit)
                {
                    return thatString.Substring(0, limit);
                }
                return thatString;
            }
            return string.Empty;
        }
    }
}