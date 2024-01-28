﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// Contains the <see cref="HASHALGORITHM_ENUM"/> nested type.
    /// </content>
    public partial class BCrypt
    {
        public enum HASHALGORITHM_ENUM
        {
            DSA_HASH_ALGORITHM_SHA1 = 0,
            DSA_HASH_ALGORITHM_SHA256 = 1,
            DSA_HASH_ALGORITHM_SHA512 = 2,
        }
    }
}
