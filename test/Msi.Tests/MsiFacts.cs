﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using PInvoke;
using Xunit;
using static PInvoke.Msi;

public class MsiFacts
{
    [Fact]
    public void InstallProduct_BadArgs()
    {
        Win32ErrorCode result = MsiInstallProduct(null, null);
        Assert.Equal(Win32ErrorCode.ERROR_INVALID_PARAMETER, result);
    }

    [Fact]
    public void IsProductElevated_BadArgs()
    {
        Guid productCode = Guid.Empty;
        Win32ErrorCode result = MsiIsProductElevated(productCode, out bool elevated);
        Assert.Equal(Win32ErrorCode.ERROR_UNKNOWN_PRODUCT, result);
    }

    [Fact]
    public unsafe void EnumProductsEx()
    {
        Win32ErrorCode result = MsiEnumProductsEx(
            null,
            null,
            MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_ALL,
            0,
            out Guid installedProductCode,
            out MSIINSTALLCONTEXT installedContext,
            out string sid);
        Assert.Equal(Win32ErrorCode.ERROR_SUCCESS, result);
    }
}
