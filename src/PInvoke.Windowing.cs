using System;
using System.Runtime.InteropServices;
using Sibber.Common.Native.Windows.Windowing;

namespace Sibber.Common.Native.Windows;

internal static unsafe partial class PInvoke
{
    public static partial class Windowing
    {
#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll", EntryPoint = "GetMessageW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static partial int GetMessage(Msg* lpMsg, HWnd hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
#else
        [DllImport("USER32.dll", EntryPoint = "GetMessageW", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static extern int GetMessage(Msg* lpMsg, HWnd hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
#endif

#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool TranslateMessage(Msg* lpMsg);
#else
        [DllImport("USER32.dll", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(Msg* lpMsg);
#endif

#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll", EntryPoint = "DispatchMessageW")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static unsafe partial nint DispatchMessage(Msg* lpMsg);
#else
        [DllImport("USER32.dll", EntryPoint = "DispatchMessageW", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static extern unsafe IntPtr DispatchMessage(Msg* lpMsg);
#endif
    }
}
