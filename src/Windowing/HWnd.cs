using System;
using System.Diagnostics;
using System.Globalization;

namespace Sibber.Common.Native.Windows.Windowing;

/// <summary>
/// Represents a native handle to a window.
/// </summary>
[DebuggerDisplay("{Value}")]
public readonly struct HWnd(IntPtr value) : IEquatable<HWnd>, IFormattable
{
    public readonly IntPtr Value = value;

    public static HWnd Null => default;

    public static explicit operator HWnd(IntPtr value) => new(value);

    public static implicit operator IntPtr(HWnd value) => value.Value;

    public static implicit operator Handle(HWnd value) => new(value.Value);

    public static bool operator ==(HWnd left, HWnd right) => left.Value == right.Value;
    public static bool operator !=(HWnd left, HWnd right) => !(left == right);
    public readonly bool Equals(HWnd other) => Value == other.Value;
    public readonly override bool Equals(object? obj) => obj is HWnd other && Equals(other);
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
