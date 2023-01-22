namespace System.Internal;




public static class DllExtern
{
    [DllImport("kernel32.dll")]
    public static extern bool SetDllDirectoryW(string lpPathName);
}