namespace System.Exe;






static class Extern
{
    const string Dll = "Draw.dll";




    [DllImport(Dll)]
    public static extern void Draw_Method_Init();
}