﻿// SPDX-License-Identifier: MIT
// Copyright (c) 2025 sibber (GitHub: sibber5)

using System.Runtime.Versioning;

namespace Sibber.Common.Native.Windows.Input;

/// <summary>
/// Virtual-Key codes.
/// </summary>
/// <remarks>
/// <list type="table">
///     <item>
///         <term><c>0x07, 0x0A-0x0B</c></term>
///         <description>Reserved</description>
///     </item>
///     <item>
///         <term><c>0x0E - 0x0F</c></term>
///         <description>Unassigned</description>
///     </item>
///     <item>
///         <term><c>0x3A - 0x40</c></term>
///         <description>Undefined</description>
///     </item>
///     <item>
///         <term><c>0x5E, 0x88-0x8F</c></term>
///         <description>Reserved</description>
///     </item>
///     <item>
///         <term><c>0x92 - 0x96</c></term>
///         <description>OEM specific</description>
///     </item>
///     <item>
///         <term><c>0x97 - 0x9F</c></term>
///         <description>Unassigned</description>
///     </item>
///     <item>
///         <term><c>0xE0</c></term>
///         <description>Reserved</description>
///     </item>
///     <item>
///         <term><c>0xE1, 0xE3-0xE4, 0xE6</c></term>
///         <description>OEM specific</description>
///     </item>
///     <item>
///         <term><c>0xE8</c></term>
///         <description>Unassigned</description>
///     </item>
///     <item>
///         <term><c>0xE9-0xF5</c></term>
///         <description>OEM specific</description>
///     </item>
/// </list>
/// <para>Generated from WinUser.h from Windows SDK 10.0.26100.0.</para>
/// </remarks>
public enum VirtualKey : ushort
{
    /// <summary>
    /// No virtual key value.
    /// </summary>
    None = 0,
    /// <summary>
    /// The left mouse button.
    /// </summary>
    LeftButton = 1,
    /// <summary>
    /// The right mouse button.
    /// </summary>
    RightButton = 2,
    /// <summary>
    /// Control-break processing.
    /// </summary>
    Cancel = 3,
    /// <summary>
    /// The middle mouse button.
    /// </summary>
    MiddleButton = 4,
    /// <summary>
    /// The X1 mouse button (usually on the side of the mouse).
    /// </summary>
    XButton1 = 5,
    /// <summary>
    /// The X2 mouse button (usually on the side of the mouse).
    /// </summary>
    XButton2 = 6,
    // 0x07 Reserved
    /// <summary>
    /// The virtual backspace key or button.
    /// </summary>
    Back = 8,
    /// <summary>
    /// The Tab key.
    /// </summary>
    Tab = 9,
    // 0x0A - 0x0B Reserved
    /// <summary>
    /// The Clear key or button.
    /// </summary>
    Clear = 12,
    /// <summary>
    /// The Enter key.
    /// </summary>
    Enter = 13,
    // 0x0E - 0x0F Unassigned
    /// <summary>
    /// The Shift key. This is the general Shift case, applicable to key layouts with only one Shift key or that do not need to differentiate between left Shift and right Shift keystrokes.
    /// </summary>
    Shift = 16,
    /// <summary>
    /// The Ctrl key. This is the general Ctrl case, applicable to key layouts with only one Ctrl key or that do not need to differentiate between left Ctrl and right Ctrl keystrokes.
    /// </summary>
    Control = 17,
    /// <summary>
    /// The menu/alt key or button.
    /// </summary>
    Menu = 18,
    /// <summary>
    /// The Pause key or button.
    /// </summary>
    Pause = 19,
    /// <summary>
    /// The Caps Lock key or button.
    /// </summary>
    CapitalLock = 20,
    /// <summary>
    /// The Kana symbol key-shift button (IME Kana mode).
    /// </summary>
    Kana = 21,
    /// <summary>
    /// The Hangul symbol key-shift button (IME Hangul mode).
    /// </summary>
    Hangul = 21,
    /// <summary>
    /// IME On.
    /// </summary>
    ImeOn = 22,
    /// <summary>
    /// The Junja symbol key-shift button (IME Junja mode).
    /// </summary>
    Junja = 23,
    /// <summary>
    /// The Final symbol key-shift button (IME final mode).
    /// </summary>
    Final = 24,
    /// <summary>
    /// The Hanja symbol key shift button (IME Hanja mode).
    /// </summary>
    Hanja = 25,
    /// <summary>
    /// The Kanji symbol key-shift button (IME Kanji mode).
    /// </summary>
    Kanji = 25,
    /// <summary>
    /// IME Off.
    /// </summary>
    ImeOff = 26,
    /// <summary>
    /// The Esc key.
    /// </summary>
    Escape = 27,
    /// <summary>
    /// The convert button or key (IME convert).
    /// </summary>
    Convert = 28,
    /// <summary>
    /// The nonconvert button or key (IME nonconvert).
    /// </summary>
    NonConvert = 29,
    /// <summary>
    /// The accept button or key (IME accept).
    /// </summary>
    Accept = 30,
    /// <summary>
    /// The mode change key (IME mode change request).
    /// </summary>
    ModeChange = 31,
    /// <summary>
    /// The Spacebar key or button.
    /// </summary>
    Space = 32,
    /// <summary>
    /// The Page Up key.
    /// </summary>
    PageUp = 33,
    /// <summary>
    /// The Page Down key.
    /// </summary>
    PageDown = 34,
    /// <summary>
    /// The End key.
    /// </summary>
    End = 35,
    /// <summary>
    /// The Home key.
    /// </summary>
    Home = 36,
    /// <summary>
    /// The Left Arrow key.
    /// </summary>
    Left = 37,
    /// <summary>
    /// The Up Arrow key.
    /// </summary>
    Up = 38,
    /// <summary>
    /// The Right Arrow key.
    /// </summary>
    Right = 39,
    /// <summary>
    /// The Down Arrow key.
    /// </summary>
    Down = 40,
    /// <summary>
    /// The Select key or button.
    /// </summary>
    Select = 41,
    /// <summary>
    /// The Print key or button.
    /// </summary>
    Print = 42,
    /// <summary>
    /// The execute key or button.
    /// </summary>
    Execute = 43,
    /// <summary>
    /// The snapshot (print screen) key or button.
    /// </summary>
    Snapshot = 44,
    /// <summary>
    /// The Insert key.
    /// </summary>
    Insert = 45,
    /// <summary>
    /// The Delete key.
    /// </summary>
    Delete = 46,
    /// <summary>
    /// The Help key or button.
    /// </summary>
    Help = 47,
    /// <summary>
    /// The number "0" key.
    /// </summary>
    Number0 = 48,
    /// <summary>
    /// The number "1" key.
    /// </summary>
    Number1 = 49,
    /// <summary>
    /// The number "2" key.
    /// </summary>
    Number2 = 50,
    /// <summary>
    /// The number "3" key.
    /// </summary>
    Number3 = 51,
    /// <summary>
    /// The number "4" key.
    /// </summary>
    Number4 = 52,
    /// <summary>
    /// The number "5" key.
    /// </summary>
    Number5 = 53,
    /// <summary>
    /// The number "6" key.
    /// </summary>
    Number6 = 54,
    /// <summary>
    /// The number "7" key.
    /// </summary>
    Number7 = 55,
    /// <summary>
    /// The number "8" key.
    /// </summary>
    Number8 = 56,
    /// <summary>
    /// The number "9" key.
    /// </summary>
    Number9 = 57,
    // 0x3A - 0x40 Undefined
    /// <summary>
    /// The letter "A" key.
    /// </summary>
    A = 65,
    /// <summary>
    /// The letter "B" key.
    /// </summary>
    B = 66,
    /// <summary>
    /// The letter "C" key.
    /// </summary>
    C = 67,
    /// <summary>
    /// The letter "D" key.
    /// </summary>
    D = 68,
    /// <summary>
    /// The letter "E" key.
    /// </summary>
    E = 69,
    /// <summary>
    /// The letter "F" key.
    /// </summary>
    F = 70,
    /// <summary>
    /// The letter "G" key.
    /// </summary>
    G = 71,
    /// <summary>
    /// The letter "H" key.
    /// </summary>
    H = 72,
    /// <summary>
    /// The letter "I" key.
    /// </summary>
    I = 73,
    /// <summary>
    /// The letter "J" key.
    /// </summary>
    J = 74,
    /// <summary>
    /// The letter "K" key.
    /// </summary>
    K = 75,
    /// <summary>
    /// The letter "L" key.
    /// </summary>
    L = 76,
    /// <summary>
    /// The letter "M" key.
    /// </summary>
    M = 77,
    /// <summary>
    /// The letter "N" key.
    /// </summary>
    N = 78,
    /// <summary>
    /// The letter "O" key.
    /// </summary>
    O = 79,
    /// <summary>
    /// The letter "P" key.
    /// </summary>
    P = 80,
    /// <summary>
    /// The letter "Q" key.
    /// </summary>
    Q = 81,
    /// <summary>
    /// The letter "R" key.
    /// </summary>
    R = 82,
    /// <summary>
    /// The letter "S" key.
    /// </summary>
    S = 83,
    /// <summary>
    /// The letter "T" key.
    /// </summary>
    T = 84,
    /// <summary>
    /// The letter "U" key.
    /// </summary>
    U = 85,
    /// <summary>
    /// The letter "V" key.
    /// </summary>
    V = 86,
    /// <summary>
    /// The letter "W" key.
    /// </summary>
    W = 87,
    /// <summary>
    /// The letter "X" key.
    /// </summary>
    X = 88,
    /// <summary>
    /// The letter "Y" key.
    /// </summary>
    Y = 89,
    /// <summary>
    /// The letter "Z" key.
    /// </summary>
    Z = 90,
    /// <summary>
    /// The left Windows key.
    /// </summary>
    LeftWindows = 91,
    /// <summary>
    /// The right Windows key.
    /// </summary>
    RightWindows = 92,
    /// <summary>
    /// The application key or button.
    /// </summary>
    Application = 93,
    // 0x5E Reserved
    /// <summary>
    /// The sleep key or button (computer sleep).
    /// </summary>
    Sleep = 95,
    /// <summary>
    /// The number "0" key as located on a numeric pad.
    /// </summary>
    NumberPad0 = 96,
    /// <summary>
    /// The number "1" key as located on a numeric pad.
    /// </summary>
    NumberPad1 = 97,
    /// <summary>
    /// The number "2" key as located on a numeric pad.
    /// </summary>
    NumberPad2 = 98,
    /// <summary>
    /// The number "3" key as located on a numeric pad.
    /// </summary>
    NumberPad3 = 99,
    /// <summary>
    /// The number "4" key as located on a numeric pad.
    /// </summary>
    NumberPad4 = 100,
    /// <summary>
    /// The number "5" key as located on a numeric pad.
    /// </summary>
    NumberPad5 = 101,
    /// <summary>
    /// The number "6" key as located on a numeric pad.
    /// </summary>
    NumberPad6 = 102,
    /// <summary>
    /// The number "7" key as located on a numeric pad.
    /// </summary>
    NumberPad7 = 103,
    /// <summary>
    /// The number "8" key as located on a numeric pad.
    /// </summary>
    NumberPad8 = 104,
    /// <summary>
    /// The number "9" key as located on a numeric pad.
    /// </summary>
    NumberPad9 = 105,
    /// <summary>
    /// The multiply (*) operation key as located on a numeric pad.
    /// </summary>
    Multiply = 106,
    /// <summary>
    /// The add (+) operation key as located on a numeric pad.
    /// </summary>
    Add = 107,
    /// <summary>
    /// The separator key as located on a numeric pad.
    /// </summary>
    Separator = 108,
    /// <summary>
    /// The subtract (-) operation key as located on a numeric pad.
    /// </summary>
    Subtract = 109,
    /// <summary>
    /// The decimal (.) key as located on a numeric pad.
    /// </summary>
#pragma warning disable CA1720 // Identifier contains type name
    Decimal = 110,
#pragma warning restore CA1720 // Identifier contains type name
    /// <summary>
    /// The divide (/) operation key as located on a numeric pad.
    /// </summary>
    Divide = 111,
    /// <summary>
    /// The F1 function key.
    /// </summary>
    F1 = 112,
    /// <summary>
    /// The F2 function key.
    /// </summary>
    F2 = 113,
    /// <summary>
    /// The F3 function key.
    /// </summary>
    F3 = 114,
    /// <summary>
    /// The F4 function key.
    /// </summary>
    F4 = 115,
    /// <summary>
    /// The F5 function key.
    /// </summary>
    F5 = 116,
    /// <summary>
    /// The F6 function key.
    /// </summary>
    F6 = 117,
    /// <summary>
    /// The F7 function key.
    /// </summary>
    F7 = 118,
    /// <summary>
    /// The F8 function key.
    /// </summary>
    F8 = 119,
    /// <summary>
    /// The F9 function key.
    /// </summary>
    F9 = 120,
    /// <summary>
    /// The F10 function key.
    /// </summary>
    F10 = 121,
    /// <summary>
    /// The F11 function key.
    /// </summary>
    F11 = 122,
    /// <summary>
    /// The F12 function key.
    /// </summary>
    F12 = 123,
    /// <summary>
    /// The F13 function key.
    /// </summary>
    F13 = 124,
    /// <summary>
    /// The F14 function key.
    /// </summary>
    F14 = 125,
    /// <summary>
    /// The F15 function key.
    /// </summary>
    F15 = 126,
    /// <summary>
    /// The F16 function key.
    /// </summary>
    F16 = 127,
    /// <summary>
    /// The F17 function key.
    /// </summary>
    F17 = 128,
    /// <summary>
    /// The F18 function key.
    /// </summary>
    F18 = 129,
    /// <summary>
    /// The F19 function key.
    /// </summary>
    F19 = 130,
    /// <summary>
    /// The F20 function key.
    /// </summary>
    F20 = 131,
    /// <summary>
    /// The F21 function key.
    /// </summary>
    F21 = 132,
    /// <summary>
    /// The F22 function key.
    /// </summary>
    F22 = 133,
    /// <summary>
    /// The F23 function key.
    /// </summary>
    F23 = 134,
    /// <summary>
    /// The F24 function key.
    /// </summary>
    F24 = 135,
    // 0x88 - 0x8F Reserved
    /// <summary>
    /// The navigation up button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationView = 136,
    /// <summary>
    /// The navigation menu button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationMenu = 137,
    /// <summary>
    /// The navigation up button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationUp = 138,
    /// <summary>
    /// The navigation down button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationDown = 139,
    /// <summary>
    /// The navigation left button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationLeft = 140,
    /// <summary>
    /// The navigation right button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationRight = 141,
    /// <summary>
    /// The navigation accept button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationAccept = 142,
    /// <summary>
    /// The navigation cancel button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    NavigationCancel = 143,
    /// <summary>
    /// The Num Lock key.
    /// </summary>
    NumberKeyLock = 144,
    /// <summary>
    /// The Scroll Lock (ScrLk) key.
    /// </summary>
    Scroll = 145,
    // 0x92 - 0x96 OEM specific
    // 0x97 - 0x9F Unassigned
    /// <summary>
    /// The left Shift key.
    /// </summary>
    LeftShift = 160,
    /// <summary>
    /// The right Shift key.
    /// </summary>
    RightShift = 161,
    /// <summary>
    /// The left Ctrl key.
    /// </summary>
    LeftControl = 162,
    /// <summary>
    /// The right Ctrl key.
    /// </summary>
    RightControl = 163,
    /// <summary>
    /// The left menu/alt key.
    /// </summary>
    LeftMenu = 164,
    /// <summary>
    /// The right menu/alt key.
    /// </summary>
    RightMenu = 165,
    /// <summary>
    /// The go back key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GoBack = 166,
    /// <summary>
    /// The go forward key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GoForward = 167,
    /// <summary>
    /// The refresh key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    Refresh = 168,
    /// <summary>
    /// The stop key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    Stop = 169,
    /// <summary>
    /// The search key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    Search = 170,
    /// <summary>
    /// The favorites key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    Favorites = 171,
    /// <summary>
    /// The go home key.
    /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GoHome = 172,
    /// <summary>
    /// The volume mute key.
    /// </summary>
    VolumeMute = 173,
    /// <summary>
    /// The volume down key.
    /// </summary>
    VolumeDown = 174,
    /// <summary>
    /// The volume up key.
    /// </summary>
    VolumeUp = 175,
    /// <summary>
    /// The next track key.
    /// </summary>
    MediaNextTrack = 176,
    /// <summary>
    /// The previous track key.
    /// </summary>
    MediaPrevTrack = 177,
    /// <summary>
    /// The stop media key.
    /// </summary>
    MediaStop = 178,
    /// <summary>
    /// The play/pause media key.
    /// </summary>
    MediaPlayPause = 179,
    /// <summary>
    /// The start mail key.
    /// </summary>
    LaunchMail = 180,
    /// <summary>
    /// The select media key.
    /// </summary>
    LaunchMediaSelect = 181,
    /// <summary>
    /// The start application 1 key.
    /// </summary>
    LaunchApp1 = 182,
    /// <summary>
    /// The start application 2 key.
    /// </summary>
    LaunchApp2 = 183,
    /* 0xB8 - 0xB9 : reserved */
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';:' key.
    /// </summary>
    Oem1 = 186,
    /// <summary>
    /// For any country/region, the '+' key.
    /// </summary>
    OemPlus = 187,
    /// <summary>
    /// For any country/region, the ',' key.
    /// </summary>
    OemComma = 188,
    /// <summary>
    /// For any country/region, the '-' key.
    /// </summary>
    OemMinus = 189,
    /// <summary>
    /// For any country/region, the '.' key.
    /// </summary>
    OemPeriod = 190,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key.
    /// </summary>
    Oem2 = 191,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key.
    /// </summary>
    Oem3 = 192,
    /* 0xC1 - 0xDA : reserved */
    /// <summary>
    /// The gamepad A button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadA = 195,
    /// <summary>
    /// The gamepad B button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadB = 196,
    /// <summary>
    /// The gamepad X button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadX = 197,
    /// <summary>
    /// The gamepad Y button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadY = 198,
    /// <summary>
    /// The gamepad right shoulder.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightShoulder = 199,
    /// <summary>
    /// The gamepad left shoulder.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftShoulder = 200,
    /// <summary>
    /// The gamepad left trigger.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftTrigger = 201,
    /// <summary>
    /// The gamepad right trigger.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightTrigger = 202,
    /// <summary>
    /// The gamepad d-pad up.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadDPadUp = 203,
    /// <summary>
    /// The gamepad d-pad down.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadDPadDown = 204,
    /// <summary>
    /// The gamepad d-pad left.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadDPadLeft = 205,
    /// <summary>
    /// The gamepad d-pad right.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadDPadRight = 206,
    /// <summary>
    /// The gamepad menu button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadMenu = 207,
    /// <summary>
    /// The gamepad view button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadView = 208,
    /// <summary>
    /// The gamepad left thumbstick button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftThumbstickButton = 209,
    /// <summary>
    /// The gamepad right thumbstick button.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightThumbstickButton = 210,
    /// <summary>
    /// The gamepad left thumbstick up.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftThumbstickUp = 211,
    /// <summary>
    /// The gamepad left thumbstick down.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftThumbstickDown = 212,
    /// <summary>
    /// The gamepad left thumbstick right.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftThumbstickRight = 213,
    /// <summary>
    /// The gamepad left thumbstick left.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadLeftThumbstickLeft = 214,
    /// <summary>
    /// The gamepad right thumbstick up.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightThumbstickUp = 215,
    /// <summary>
    /// The gamepad right thumbstick down.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightThumbstickDown = 216,
    /// <summary>
    /// The gamepad right thumbstick right.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightThumbstickRight = 217,
    /// <summary>
    /// The gamepad right thumbstick left.
    /// </summary>
    /// <remarks>
    /// Windows 10.0.10240.0+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("Windows10.0.10240.0")]
#endif
    GamepadRightThumbstickLeft = 218,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key.
    /// </summary>
    Oem4 = 219,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\\|' key.
    /// </summary>
    Oem5 = 220,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key.
    /// </summary>
    Oem6 = 221,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ''"' key.
    /// </summary>
    Oem7 = 222,
    /// <summary>
    /// Used for miscellaneous characters; it can vary by keyboard.
    /// </summary>
    Oem8 = 223,
    // 0xE0 Reserved
    // 0xE1 OEM specific
    /// <summary>
    /// The '&lt;&gt;' keys on the US standard keyboard, or the '\\|' key on the non-US 102-key keyboard.
    /// </summary>
    Oem102 = 226,
    // 0xE3 - 0xE4 OEM specific
    /// <summary>
    /// The IME PROCESS key.
    /// </summary>
    ProcessKey = 229,
    // 0xE6 OEM specific
    /// <summary>
    /// Used to pass Unicode characters as if they were keystrokes. The <see cref="Packet"/> key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods.
    /// For more information, see Remark in <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput">KEYBDINPUT</see>, <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput">SendInput</see>, <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-keydown">WM_KEYDOWN</see>, and <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-keyup">WM_KEYUP</see>.
    /// </summary>
    Packet = 231,
    // 0xE8 Unassigned
    // 0xE9 - 0xF5 OEM specific
    /// <summary>
    /// The Attn key.
    /// </summary>
    Attn = 246,
    /// <summary>
    /// The CrSel key.
    /// </summary>
    CrSel = 247,
    /// <summary>
    /// The ExSel key.
    /// </summary>
    ExSel = 248,
    /// <summary>
    /// The Erase EOF key.
    /// </summary>
    EraseEOF = 249,
    /// <summary>
    /// The play key.
    /// </summary>
    Play = 250,
    /// <summary>
    /// The zoom key.
    /// </summary>
    Zoom = 251,
    /// <summary>
    /// Reserved.
    /// </summary>
    NoName = 252,
    /// <summary>
    /// The PA1 key.
    /// </summary>
    PA1 = 253,
    /// <summary>
    /// The clear key.
    /// </summary>
    OemClear = 254,
}
