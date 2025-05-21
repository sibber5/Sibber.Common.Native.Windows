using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Sibber.Common.Native.Windows;

#pragma warning disable CA1823 // Avoid unused private fields

/// <summary>
/// Represents a window result handle (HRESULT).
/// </summary>
[DebuggerDisplay("{Value}")]
public readonly partial struct HResult(uint value) : IEquatable<HResult>, IFormattable
{
    #region This region is licensed under the MIT license (SPDX-License-Identifier: MIT); Copyright (c) .NET Foundation and Contributors. All rights reserved.
    // From: https://github.com/dotnet/pinvoke/blob/d974353ca67c4b8e6009096bd3ab7e6f284ed11d/src/Windows.Core/HResult.cs

    /// <summary>
    /// The mask of the bits that describe the <see cref="Severity"/>.
    /// </summary>
    private const uint SeverityMask = 0x80000000;

    /// <summary>
    /// The number of bits that <see cref="Severity"/> values are shifted
    /// in order to fit within <see cref="SeverityMask"/>.
    /// </summary>
    private const int SeverityShift = 31;

    /// <summary>
    /// The mask of the bits that describe the <see cref="Facility"/>.
    /// </summary>
    private const int FacilityMask = 0x7ff0000;

    /// <summary>
    /// The number of bits that <see cref="Facility"/> values are shifted
    /// in order to fit within <see cref="FacilityMask"/>.
    /// </summary>
    private const int FacilityShift = 16;

    /// <summary>
    /// The mask of the bits that describe the <see cref="FacilityStatus"/>.
    /// </summary>
    private const int FacilityStatusMask = 0xffff;

    /// <summary>
    /// The number of bits that <see cref="FacilityStatus"/> values are shifted
    /// in order to fit within <see cref="FacilityStatusMask"/>.
    /// </summary>
    private const int FacilityStatusShift = 0;

    /// <summary>
    /// Gets the full HRESULT value.
    /// </summary>
    public readonly uint Value = value;

    /// <summary>
    /// Gets a value indicating whether this HRESULT represents a successful operation.
    /// </summary>
    public readonly bool Succeeded => Severity == SeverityCode.Success;

    /// <summary>
    /// Gets a value indicating whether this HRESULT represents a failured operation.
    /// </summary>
    public readonly bool Failed => Severity == SeverityCode.Fail;

    /// <summary>
    /// Gets the facility code of the HRESULT.
    /// </summary>
    public readonly FacilityCode Facility => (FacilityCode)((Value & FacilityMask) >> FacilityShift);

    /// <summary>
    /// Gets the severity of the HRESULT.
    /// </summary>
    public readonly SeverityCode Severity => (SeverityCode)((Value & SeverityMask) >> SeverityShift);

    /// <summary>
    /// Gets the facility's status code bits from the HRESULT.
    /// </summary>
    public readonly uint FacilityStatus => Value & FacilityStatusMask;

    /// <summary>
    /// Throws an exception if <see cref="Failed"/> is <see langword="true"/>, based on the failure value.
    /// </summary>
    public readonly void ThrowOnFailure() => Marshal.ThrowExceptionForHR((int)this);

    /// <summary>
    /// Throws an exception if <see cref="Failed"/> is <see langword="true"/>, based on the failure value and the specified IErrorInfo interface.
    /// </summary>
    /// <param name="errorInfo">
    /// A pointer to the IErrorInfo interface that provides more information about the
    /// error. You can specify IntPtr(0) to use the current IErrorInfo interface, or
    /// IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception
    /// just from the error code.
    /// </param>
    public readonly void ThrowOnFailure(IntPtr errorInfo) => Marshal.ThrowExceptionForHR((int)this, errorInfo);

    #endregion

    /// <inheritdoc cref="Marshal.GetExceptionForHR(int)"/>
    public readonly Exception? GetException() => Marshal.GetExceptionForHR((int)this);

    /// <inheritdoc cref="Marshal.GetExceptionForHR(int, IntPtr)"/>
    public readonly Exception? GetException(IntPtr errorInfo) => Marshal.GetExceptionForHR((int)this, errorInfo);

    public static explicit operator uint(HResult value) => value.Value;
    public static explicit operator int(HResult value) => (int)value.Value;

    public static bool operator ==(HResult left, HResult right) => left.Value == right.Value;
    public static bool operator !=(HResult left, HResult right) => !(left == right);
    public readonly bool Equals(HResult other) => Value == other.Value;
    public readonly override bool Equals(object? obj) => obj is HResult other && Equals(other);
    public readonly override int GetHashCode() => Value.GetHashCode();

    public readonly override string ToString() => $"0x{Value:X8}";

    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        if (string.IsNullOrEmpty(format)) return ToString();
        formatProvider ??= CultureInfo.CurrentCulture;

        return Value.ToString(format, formatProvider);
    }
}
