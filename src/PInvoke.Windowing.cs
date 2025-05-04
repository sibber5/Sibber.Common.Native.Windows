using System.Runtime.InteropServices;
using Sibber.Common.Native.Windows.Windowing;

namespace Sibber.Common.Native.Windows;

internal static unsafe partial class PInvoke
{
    public static unsafe partial class Windowing
    {
#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll", EntryPoint = "GetMessageW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static partial int GetMessage(MSG* lpMsg, HWnd hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
#else
        [DllImport("USER32.dll", EntryPoint = "GetMessageW", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static extern int GetMessage(MSG* lpMsg, HWnd hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
#endif

#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool TranslateMessage(MSG* lpMsg);
#else
        [DllImport("USER32.dll", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(MSG* lpMsg);
#endif

#if NET7_0_OR_GREATER
        [LibraryImport("USER32.dll", EntryPoint = "DispatchMessageW")]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static unsafe partial nint DispatchMessage(MSG* lpMsg);
#else
        [DllImport("USER32.dll", EntryPoint = "DispatchMessageW", ExactSpelling = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        public static extern unsafe nint DispatchMessage(MSG* lpMsg);
#endif
    }
}
