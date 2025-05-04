namespace Sibber.Common.Native.Windows;

#pragma warning disable CA1707 // Identifiers should not contain underscores
partial struct HResult
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public static HResult S_OK => new(0x00000000u);

    /// <summary>
    /// Operation successful. (negative condition/no operation)
    /// </summary>
    public static HResult S_FALSE => new(0x00000001u);

    /// <summary>
    /// Not implemented.
    /// </summary>
    public static HResult E_NOTIMPL => new(0x80004001u);

    /// <summary>
    /// No such interface supported.
    /// </summary>
    public static HResult E_NOINTERFACE => new(0x80004002u);

    /// <summary>
    /// Pointer that is not valid.
    /// </summary>
    public static HResult E_POINTER => new(0x80004003u);

    /// <summary>
    /// Operation aborted.
    /// </summary>
    public static HResult E_ABORT => new(0x80004004u);

    /// <summary>
    /// Unspecified failure.
    /// </summary>
    public static HResult E_FAIL => new(0x80004005u);

    /// <summary>
    /// Unexpected failure.
    /// </summary>
    public static HResult E_UNEXPECTED => new(0x8000FFFFu);

    /// <summary>
    /// General access denied error.
    /// </summary>
    public static HResult E_ACCESSDENIED => new(0x80070005u);

    /// <summary>
    /// Handle that is not valid.
    /// </summary>
    public static HResult E_HANDLE => new(0x80070006u);

    /// <summary>
    /// Failed to allocate necessary memory.
    /// </summary>
    public static HResult E_OUTOFMEMORY => new(0x8007000Eu);

    /// <summary>
    /// One or more arguments are not valid.
    /// </summary>
    public static HResult E_INVALIDARG => new(0x80070057u);

    /// <summary>
    /// The operation was canceled by the user. (Error source 7 means Win32.)
    /// </summary>
    /// <SeeAlso href="https://learn.microsoft.com/windows/win32/debug/system-error-codes--1000-1299-"/>
    /// <SeeAlso href="https://en.wikipedia.org/wiki/HRESULT"/>
    public static HResult E_CANCELLED => new(0x800704C7u);

    /// <summary>
    /// The call was already canceled.
    /// </summary>
    public static HResult RPC_E_CALL_CANCELED => new(0x80010002);

    /// <summary>
    /// The call was completed during the timeout interval.
    /// </summary>
    public static HResult RPC_E_CALL_COMPLETE => new(0x80010117);

    /// <summary>
    /// Call cancellation is not enabled on the specified thread.
    /// </summary>
    public static HResult CO_E_CANCEL_DISABLED => new(0x80010140);
}
