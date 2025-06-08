// SPDX-License-Identifier: MIT
// Copyright (c) .NET Foundation and Contributors
// From https://github.com/dotnet/pinvoke/blob/d974353ca67c4b8e6009096bd3ab7e6f284ed11d/src/Windows.Core/HResult%2BSeverityCode.cs

namespace Sibber.Common.Native.Windows;

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
