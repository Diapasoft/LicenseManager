﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ThinkSharp.Helper
{
    internal static class ValidationHelper
    {
        public static void IsValidFolderName(this string value)
        {
            value.IsValidFileName();
        }

        public static void IsValidFileName(this string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value must not be null or empty.");

            if (value.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                throw new ArgumentException($"Value '{value}' is not valid because it contains invalid characters.");
        }
    }
}