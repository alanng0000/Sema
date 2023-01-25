namespace System.Intern;




static class KeyExtern
{
    const string User32Dll = "user32.dll";



    [DllImport(User32Dll)]
    public static extern short GetKeyState(int nVirtKey);
}