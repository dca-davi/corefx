// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

//
//

namespace System
{
    using System.Text; // for NormalizationForm type

    public static class StringNormalizationExtensions
    {
        public static bool IsNormalized(this string value) { throw null; }
        [System.Security.SecurityCritical]
        public static bool IsNormalized(this string value, NormalizationForm normalizationForm) { throw null; }
        public static String Normalize(this string value) { throw null; }
        [System.Security.SecurityCritical]
        public static String Normalize(this string value, NormalizationForm normalizationForm) { throw null; }
    }
}

namespace System.Globalization
{
    public static partial class GlobalizationExtensions
    {
        public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options) { throw null; }
    }
}
