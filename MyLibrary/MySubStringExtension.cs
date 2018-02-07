using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MySubStringExtension
    {
        public static string MySubString(this string value, int startIndex, int length)
        {
            if (startIndex >= value.Length) return string.Empty;
            if (length > value.Length - startIndex) length = value.Length - startIndex;
            return value.Substring(startIndex, length);
        }
    }
}