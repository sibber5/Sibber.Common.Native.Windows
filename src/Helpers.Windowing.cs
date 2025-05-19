using System.ComponentModel;
using Sibber.Common.Native.Windows.Windowing;

namespace Sibber.Common.Native.Windows;

/// <content>
/// <see cref="Helpers.Windowing"/>
/// </content>
partial class Helpers
{
    public static class Windowing
    {
        /// <summary>
        /// Run a simple standard message loop.
        /// </summary>
        /// <param name="throwOnError">Specifies whether the method should throw if there is an error, or return <c>-1</c>.</param>
        /// <returns>
        /// <c>0</c> if <see cref="WindowMessage.Quit"/> is retrieved.<br/>
        /// <c>-1</c> if <paramref name="throwOnError"/> is <see langword="false"/> and there was an error during/after message retrieval.
        /// </returns>
        /// <exception cref="Win32Exception">
        /// Thrown if <paramref name="throwOnError"/> is <see langword="true"/> and there was an error during/after message retrieval.
        /// </exception>
        public static unsafe int RunMessageLoop(bool throwOnError = false)
        {
            Msg msg = new();
            int ret;
            while (true)
            {
                ret = PInvoke.Windowing.GetMessage(&msg, HWnd.Null, 0, 0);
                if (ret == 0) break;

                if (ret == -1)
                {
                    if (throwOnError) throw new Win32Exception();
                    break;
                }

                PInvoke.Windowing.TranslateMessage(&msg);
                PInvoke.Windowing.DispatchMessage(&msg);
            }

            return ret;
        }
    }
}
