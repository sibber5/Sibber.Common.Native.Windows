using System;
using System.ComponentModel;
using Sibber.Common.Native.Windows.Windowing;

namespace Sibber.Common.Native.Windows;

/// <content>
/// <see cref="Helpers.Windowing"/>
/// </content>
partial class Helpers
{
    /// <summary>
    /// Provides helpers for Windows API features and functions related to windowing.
    /// </summary>
    public static class Windowing
    {
        /// <summary>
        /// Run a simple standard message loop.
        /// </summary>
        /// <param name="throwOnError">Specifies whether the method should throw if there is an error, or return <c>-1</c>.</param>
        /// <param name="peekMessage">Invoked right before the message is translated and dispatched.</param>
        /// <param name="msgFilterMin">
        /// <para>The integer value of the lowest message value to be retrieved. Use <see cref="WindowMessage.KeyFirst"/> (0x0100) to specify the first keyboard message or <see cref="WindowMessage.MouseFirst"/> (0x0200) to specify the first mouse message.</para>
        /// <para>Use <see cref="WindowMessage.Input"/> here and in <paramref name="msgFilterMax"/> to specify only the <see cref="WindowMessage.Input"/> messages.</para>
        /// <para>If <paramref name="msgFilterMin"/> and <paramref name="msgFilterMax"/> are both zero (default), <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessage">GetMessage</see> returns all available messages (that is, no range filtering is performed).</para>
        /// </param>
        /// <param name="msgFilterMax">
        /// <para>The integer value of the highest message value to be retrieved. Use <see cref="WindowMessage.KeyLast"/> to specify the last keyboard message or <see cref="WindowMessage.MouseLast"/> to specify the last mouse message.</para>
        /// <para>Use <see cref="WindowMessage.Input"/> here and in <paramref name="msgFilterMin"/> to specify only the <see cref="WindowMessage.Input"/> messages.</para>
        /// <para>If <paramref name="msgFilterMin"/> and <paramref name="msgFilterMax"/> are both zero (default), <see href="https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessage">GetMessage</see> returns all available messages (that is, no range filtering is performed).</para>
        /// </param>
        /// <returns>
        /// <c>0</c> if <see cref="WindowMessage.Quit"/> is retrieved.<br/>
        /// <c>-1</c> if <paramref name="throwOnError"/> is <see langword="false"/> and there was an error during/after message retrieval.
        /// </returns>
        /// <exception cref="Win32Exception">
        /// Thrown if <paramref name="throwOnError"/> is <see langword="true"/> and there was an error during/after message retrieval.
        /// </exception>
        public static unsafe int RunMessageLoop(bool throwOnError = false, Action<Msg>? peekMessage = null, uint msgFilterMin = 0, uint msgFilterMax = 0)
        {
            Msg msg = new();
            int ret;
            while (true)
            {
                ret = PInvoke.Windowing.GetMessage(&msg, HWnd.Null, msgFilterMin, msgFilterMax);
                if (ret == 0) break;

                if (ret == -1)
                {
                    if (throwOnError) throw new Win32Exception();
                    break;
                }

                peekMessage?.Invoke(msg);

                PInvoke.Windowing.TranslateMessage(&msg);
                PInvoke.Windowing.DispatchMessage(&msg);
            }

            return ret;
        }
    }
}
