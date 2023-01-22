namespace System.Draw;




static class Extern
{
    const string DrawDll = "Draw.dll";



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_New();



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_Init(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_Final(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_Delete(ulong o);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_GetHandle(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_SetHandle(ulong o, ulong value);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_GetSize(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_SetSize(ulong o, ulong value);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_GetMethod(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_SetMethod(ulong o, ulong value);
}