namespace sibber.Common.Native.Windows;

// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. SPDX-License-Identifier: MIT.
// From https://github.com/dotnet/pinvoke/blob/d974353ca67c4b8e6009096bd3ab7e6f284ed11d/src/Windows.Core/HResult%2BSeverityCode.cs

/// <content>
/// The <see cref="SeverityCode"/> nested type.
/// </content>
partial struct HResult
{
    /// <summary>
    /// HRESULT severity codes defined by winerror.h.
    /// </summary>
    public enum SeverityCode : uint
    {
        Success = 0,
        Fail = 1,
    }
}
