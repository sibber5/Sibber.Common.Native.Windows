using System;
using System.Runtime.CompilerServices;

namespace Sibber.Common.Native.Windows;

public static partial class Helpers
{
#if NET7_0_OR_GREATER
    [Obsolete("Call the overload that takes 'byte' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort MakeWord(nuint low, nuint high) => unchecked((ushort)(((byte)(low & 0xff)) | ((byte)(high & 0xff) << 8)));
#else
    [Obsolete("Call the overload that takes 'byte' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort MakeWord(UIntPtr low, UIntPtr high) => Environment.Is64BitProcess ? MakeWord((ulong)low, (ulong)high) : MakeWord((uint)low, (uint)high);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ushort MakeWord(ulong low, ulong high) => unchecked((ushort)(((byte)(low & 0xff)) | ((byte)(high & 0xff) << 8)));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ushort MakeWord(uint low, uint high) => unchecked((ushort)(((byte)(low & 0xff)) | ((byte)(high & 0xff) << 8)));
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort MakeWord(byte low, byte high) => unchecked((ushort)(low | (high << 8)));

#if NET7_0_OR_GREATER
    [Obsolete("Call the overload that takes 'ushort' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int MakeLong(nuint low, nuint high) => unchecked((int)(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16)));
#else
    [Obsolete("Call the overload that takes 'ushort' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int MakeLong(UIntPtr low, UIntPtr high) => Environment.Is64BitProcess ? MakeLong((ulong)low, (ulong)high) : MakeLong((uint)low, (uint)high);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MakeLong(ulong low, ulong high) => unchecked((int)(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16)));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MakeLong(uint low, uint high) => unchecked((int)(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16)));
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int MakeLong(ushort low, ushort high) => unchecked((int)(low | (((uint)high) << 16)));

#if NET7_0_OR_GREATER
    [Obsolete("Call the overload that takes 'ushort' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MakeDWord(nuint low, nuint high) => unchecked(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16));
#else
    [Obsolete("Call the overload that takes 'ushort' to avoid unintentionally unsafely passing out of range values.", false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MakeDWord(UIntPtr low, UIntPtr high) => Environment.Is64BitProcess ? MakeDWord((ulong)low, (ulong)high) : MakeDWord((uint)low, (uint)high);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MakeDWord(ulong low, ulong high) => unchecked(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint MakeDWord(uint low, uint high) => unchecked(((ushort)(low & 0xffff)) | (((uint)(ushort)(high & 0xffff)) << 16));
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MakeDWord(ushort low, ushort high) => unchecked(low | (((uint)high) << 16));

#if NET7_0_OR_GREATER
    /// <inheritdoc cref="LowWord(uint)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort LowWord(nuint x) => unchecked((ushort)(x & 0xffff));
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    /// <inheritdoc cref="LowWord(uint)"/>
    public static ushort LowWord(UIntPtr x) => unchecked((ushort)(((ulong)x) & 0xffff));
#endif
    /// <returns>The low word (16 bits) of the least significant 32 bits.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort LowWord(uint x) => unchecked((ushort)(x & 0xffff));

#if NET7_0_OR_GREATER
    /// <inheritdoc cref="HighWord(uint)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort HighWord(nuint x) => unchecked((ushort)((x >> 16) & 0xffff));
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    /// <inheritdoc cref="HighWord(uint)"/>
    public static ushort HighWord(UIntPtr x) => unchecked((ushort)((((ulong)x) >> 16) & 0xffff));
#endif
    /// <returns>The high word (16 bits) of the least significant 32 bits.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort HighWord(uint x) => unchecked((ushort)((x >> 16) & 0xffff));

#if NET7_0_OR_GREATER
    /// <inheritdoc cref="LowByte(ushort)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte LowByte(nuint x) => unchecked((byte)(x & 0xff));
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    /// <inheritdoc cref="LowByte(ushort)"/>
    public static byte LowByte(UIntPtr x) => unchecked((byte)(((ulong)x) & 0xff));
#endif
    /// <returns>The low byte (8 bits) of the least significant 16 bits.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte LowByte(ushort x) => unchecked((byte)(x & 0xff));

#if NET7_0_OR_GREATER
    /// <inheritdoc cref="HighByte(ushort)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort HighByte(nuint x) => unchecked((ushort)((x >> 8) & 0xff));
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    /// <inheritdoc cref="HighByte(ushort)"/>
    public static ushort HighByte(UIntPtr x) => unchecked((ushort)((((ulong)x) >> 8) & 0xff));
#endif
    /// <returns>The high byte (8 bits) of the least significant 16 bits.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort HighByte(ushort x) => unchecked((ushort)((x >> 8) & 0xff));
}
