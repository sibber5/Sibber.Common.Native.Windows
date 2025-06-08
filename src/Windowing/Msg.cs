// SPDX-License-Identifier: MIT
// Copyright (c) 2025 sibber (GitHub: sibber5)

using System;
using System.Runtime.InteropServices;

namespace Sibber.Common.Native.Windows.Windowing;

/// <summary>
/// Contains message information from a thread's message queue.
/// </summary>
/// <remarks>
/// <see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-msg">Read more on learn.microsoft.com</see>.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly struct Msg(HWnd hWnd, uint messageId, UIntPtr wParam, IntPtr lParam, uint time, Point pt) : IEquatable<Msg>
{
    /// <summary>
    /// A handle to the window whose window procedure receives the message. This member is <see cref="HWnd.Null"/> when the message is a thread message.
    /// </summary>
    public readonly HWnd HWnd = hWnd;

    /// <summary>
    /// The message identifier. Applications can only use the low word; the high word is reserved by the system.
    /// </summary>
    /// <seealso cref="Helpers.LowWord(uint)"/>
    public readonly uint MessageId = messageId;

    /// <summary>
    /// The window message associated with <see cref="MessageId"/>.
    /// </summary>
    public readonly WindowMessage Message => (WindowMessage)Helpers.LowWord(MessageId);

    /// <summary>
    /// Additional information about the message. The exact meaning depends on the value of <see cref="MessageId"/> (or <see cref="Message"/>).
    /// </summary>
    public readonly UIntPtr WParam = wParam;

    /// <summary>
    /// Additional information about the message. The exact meaning depends on the value of <see cref="MessageId"/> (or <see cref="Message"/>).
    /// </summary>
    public readonly IntPtr LParam = lParam;

    /// <summary>
    /// The time at which the message was posted.
    /// </summary>
    public readonly uint Time = time;

    /// <summary>
    /// The cursor position, in screen coordinates, when the message was posted.
    /// </summary>
    public readonly Point Pt = pt;

    public static bool operator ==(Msg left, Msg right) => left.Equals(right);
    public static bool operator !=(Msg left, Msg right) => !(left == right);
    public readonly override int GetHashCode() => HashCode.Combine(HWnd, MessageId, WParam, LParam, Time, Pt);
    public readonly override bool Equals(object? obj) => obj is Msg msg && Equals(msg);
    public readonly bool Equals(Msg other) => HWnd == other.HWnd && MessageId == other.MessageId && WParam == other.WParam && LParam == other.LParam && Time == other.Time && other.Pt == Pt;
    public readonly override string ToString() => $"{nameof(Msg)} {{ {nameof(HWnd)} = {HWnd}, {nameof(MessageId)} = {MessageId} ({Message}), {nameof(WParam)} = {WParam}, {nameof(LParam)} = {LParam}, {nameof(Time)} = {Time}, {nameof(Pt)} = {Pt} }}";
}
