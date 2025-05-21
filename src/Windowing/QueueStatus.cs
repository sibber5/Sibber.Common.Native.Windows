using System;
using System.Runtime.Versioning;

namespace Sibber.Common.Native.Windows.Windowing;

/// <summary>
/// Queue status flags for <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getqueuestatus">GetQueueStatus</see> and <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-msgwaitformultipleobjects">MsgWaitForMultipleObjects</see>.
/// </summary>
/// <remarks>
/// Generated from WinUser.h from Windows SDK 10.0.26100.0.
/// </remarks>
[Flags]
public enum QueueStatus : uint
{
    /// <summary>
    /// A <see cref="WindowMessage.KeyUp"/>, <see cref="WindowMessage.KeyDown"/>, <see cref="WindowMessage.SysKeyUp"/>, or <see cref="WindowMessage.SysKeyDown"/> message is in the queue.
    /// </summary>
    Key = 0x0001u,

    /// <summary>
    /// A <see cref="WindowMessage.MouseMove"/> message is in the queue.
    /// </summary>
    MouseMove = 0x0002u,

    /// <summary>
    /// A mouse-button message (<see cref="WindowMessage.LButtonUp"/>, <see cref="WindowMessage.RButtonDown"/>, and so on).
    /// </summary>
    MouseButton = 0x0004u,

    /// <summary>
    /// A posted message (other than those listed here) is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-postmessagew">PostMessage</see>.<br/>
    /// This value is cleared when you call <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessage">GetMessage</see> or <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-peekmessagew">PeekMessage</see>, whether or not you are filtering messages.
    /// </summary>
    PostMessage = 0x0008u,

    /// <summary>
    /// A <see cref="WindowMessage.Timer"/> message is in the queue.
    /// </summary>
    Timer = 0x0010u,

    /// <summary>
    /// A <see cref="WindowMessage.Paint"/> message is in the queue.
    /// </summary>
    Paint = 0x0020u,

    /// <summary>
    /// A message sent by another thread or application is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendmessagew">SendMessage</see>.
    /// </summary>
    SendMessage = 0x0040u,

    /// <summary>
    /// A <see cref="WindowMessage.HotKey"/> message is in the queue.
    /// </summary>
    Hotkey = 0x0080u,

    /// <summary>
    /// A posted message (other than those listed here) is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-postmessagew">PostMessage</see>.<br/>
    /// This value is cleared when you call <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessage">GetMessage</see> or <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-peekmessagew">PeekMessage</see>, whether or not you are filtering messages.
    /// </summary>
    AllPostMessage = 0x0100u,

    /// <summary>
    /// A raw input message is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/desktop/inputdev/raw-input">Raw Input</see>.
    /// </summary>
    /// <remarks>
    /// Windows XP+
    /// </remarks>
    RawInput = 0x0400u,

    /// <summary>
    /// A touch input message is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/win32/wintouch/windows-touch-portal">Touch Input</see>.
    /// </summary>
    /// <remarks>
    /// Windows 8+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows6.2.9200")]
#endif
    Touch = 0x0800u,

    /// <summary>
    /// A pointer input message is in the queue. For more information, see <see href="https://learn.microsoft.com/windows/win32/inputmsg/messages-and-notifications-portal">Pointer Input</see>.
    /// </summary>
    /// <remarks>
    /// Windows 8+
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows6.2.9200")]
#endif
    Pointer = 0x1000u,

    /// <summary>
    /// A <see cref="WindowMessage.MouseMove"/> message or mouse-button message (<see cref="WindowMessage.LButtonUp"/>, <see cref="WindowMessage.RButtonDown"/>, and so on).
    /// </summary>
    Mouse = MouseMove | MouseButton,

    /// <summary>
    /// An input message is in the queue.
    /// </summary>
    /// <remarks>
    /// Windows 8+. Has a different value on previous versions.
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows6.2.9200")]
#endif
    Input = Mouse | Key | RawInput | Touch | Pointer,

    /// <summary>
    /// An input, <see cref="WindowMessage.Timer"/>, <see cref="WindowMessage.Paint"/>, <see cref="WindowMessage.HotKey"/>, or posted message is in the queue.
    /// </summary>
    /// <remarks>
    /// Windows 8+. Has a different value on previous versions.
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows6.2.9200")]
#endif
    AllEvents = Input | PostMessage | Timer | Paint | Hotkey,

    /// <summary>
    /// Any message is in the queue.
    /// </summary>
    /// <remarks>
    /// Windows 8+. Has a different value on previous versions.
    /// </remarks>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("windows6.2.9200")]
#endif
    AllInput = Input | PostMessage | Timer | Paint | Hotkey | SendMessage,
}
