// SPDX-License-Identifier: MIT
// Copyright (c) 2025 sibber (GitHub: sibber5)

using System;
using System.Runtime.InteropServices;

namespace Sibber.Common.Native.Windows;

/// <summary>Defines the <i>x</i>- and <i>y</i>-coordinates of a point.</summary>
/// <remarks>
/// <para>This is the <a href="https://learn.microsoft.com/windows/win32/api/windef/ns-windef-point">POINT</a> structure which is identical to the <a href="https://learn.microsoft.com/windows/win32/api/windef/ns-windef-pointl">POINTL</a> structure.</para>
/// <para><see href="https://learn.microsoft.com/windows/win32/api/windef/ns-windef-point">Read more on learn.microsoft.com</see>.</para>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly struct Point(int x, int y) : IEquatable<Point>
{
    /// <summary>Specifies the <i>x</i>-coordinate of the point.</summary>
    private readonly int X = x;

    /// <summary>Specifies the <i>y</i>-coordinate of the point.</summary>
    private readonly int Y = y;

    public static explicit operator System.Drawing.Point(Point p) => new(p.X, p.Y);

    public static explicit operator Point(System.Drawing.Point p) => new(p.X, p.Y);

    public static bool operator !=(Point left, Point right) => !(left == right);

    public static bool operator ==(Point left, Point right) => left.Equals(right);

    public readonly override int GetHashCode() => HashCode.Combine(X, Y);

    public readonly override bool Equals(object? obj) => obj is Point point && Equals(point);

    public readonly bool Equals(Point other) => X == other.X && Y == other.Y;

    // ReSharper disable ParameterHidesMember
    public readonly void Deconstruct(out int X, out int Y)
    // ReSharper restore ParameterHidesMember
    {
        X = this.X;
        Y = this.Y;
    }

    public readonly override string ToString() => $"Point {{ {nameof(X)} = {X}, {nameof(Y)} = {Y} }}";
}
