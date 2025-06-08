// SPDX-License-Identifier: MIT
// Copyright (c) 2025 sibber (GitHub: sibber5)

using System;
using System.Diagnostics;
using System.Globalization;

namespace Sibber.Common.Native.Windows;

/// <summary>
/// Represents a native handle.
/// </summary>
[DebuggerDisplay("{Value}")]
public readonly struct Handle(IntPtr value) : IEquatable<Handle>, IFormattable
{
    public readonly IntPtr Value = value;

    public static Handle Null => default;

    public static explicit operator Handle(IntPtr value) => new(value);

    public static implicit operator IntPtr(Handle value) => value.Value;

    public static bool operator ==(Handle left, Handle right) => left.Value == right.Value;
    public static bool operator !=(Handle left, Handle right) => !(left == right);
    public readonly bool Equals(Handle other) => Value == other.Value;
    public readonly override bool Equals(object? obj) => obj is Handle other && Equals(other);
    public readonly override int GetHashCode() => Value.GetHashCode();

    public readonly override string ToString() => $"0x{Value:X}";

    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        if (string.IsNullOrEmpty(format)) return ToString();
        formatProvider ??= CultureInfo.CurrentCulture;

#if NET5_0_OR_GREATER
        return Value.ToString(format, formatProvider);
#else
        return Value.ToString(format);
#endif
    }
}
