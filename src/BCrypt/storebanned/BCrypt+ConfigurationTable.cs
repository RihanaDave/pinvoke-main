// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// Contains the <see cref="ChainingModes"/> nested type.
    /// </content>
    public partial class BCrypt
    {
        /// <summary>
        /// Possible values for the <see cref="BCryptAddContextFunction"/>.
        /// </summary>
        public enum ConfigurationTable
        {
            /// <summary>
            /// The context exists in the local-machine configuration table.
            /// </summary>
            CRYPT_LOCAL,

            /// <summary>
            /// This value is not available for use.
            /// </summary>
            CRYPT_DOMAIN,
        }
    }
}
