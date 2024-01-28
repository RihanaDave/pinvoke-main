﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System;

    /// <content>
    /// Contains the <see cref="NCryptIsAlgSupportedFlags"/> nested type.
    /// </content>
    public partial class NCrypt
    {
        /// <summary>
        /// Flags that can be passed to the <see cref="NCryptIsAlgSupported(SafeProviderHandle, string, NCryptIsAlgSupportedFlags)"/> method.
        /// </summary>
        [Flags]
        public enum NCryptIsAlgSupportedFlags
        {
            /// <summary>
            /// No flags.
            /// </summary>
            None = 0x0,

            /// <summary>
            /// Requests that the key service provider (KSP) not display any user interface. If the provider must display the UI to operate, the call fails and the KSP should set the NTE_SILENT_CONTEXT error code as the last error.
            /// </summary>
            NCRYPT_SILENT_FLAG = 0x00000040,
        }
    }
}
