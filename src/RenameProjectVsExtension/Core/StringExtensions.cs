﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal static class StringExtensions
    {
        public static string WrapWithTag(this string str, string tag)
        {
            return $"<{tag}>{str}</{tag}>";
        }

        public static string ReplaceWithTag(this string sourceStr, string oldValue, string newValue, string tag)
        {
            return sourceStr.Replace(oldValue.WrapWithTag(tag), newValue.WrapWithTag(tag));
        }
    }
}
