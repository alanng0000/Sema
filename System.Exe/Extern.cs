namespace System.Exe;




static class Extern : Object
{
    [DllImport("kernel32.dll")]
    public static extern bool SetDllDirectoryW(string lpPathName);
}