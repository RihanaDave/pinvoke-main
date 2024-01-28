﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="CHAR_INFO_ENCODING"/> nested type.
    /// </content>
    public partial class Kernel32
    {
        /// <summary>
        /// A union of the Unicode and Ascii encodings.
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct CHAR_INFO_ENCODING
        {
            /// <summary>
            /// Unicode character of a screen buffer character cell.
            /// </summary>
            [FieldOffset(0)]
            public char UnicodeChar;

            /// <summary>
            /// ANSI character of a screen buffer character cell.
            /// </summary>
            [FieldOffset(0)]
            public byte AsciiChar;
        }
    }
}
