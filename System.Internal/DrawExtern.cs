namespace System.Internal;




public static class DrawExtern
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



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_Clear(ulong o, ulong color);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Draw_Rect(ulong o, long left, long up, ulong width, ulong height, ulong brush);





    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_New();


    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_Init(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_Final(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_Delete(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_GetType(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_SetType(ulong o, ulong value);



    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_GetValue(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Brush_SetValue(ulong o, ulong value);




    [DllImport(DrawDll)]
    public static extern ulong Draw_ColorBrush_Create();



    [DllImport(DrawDll)]
    public static extern ulong Draw_ColorBrush_GetColor(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_ColorBrush_SetColor(ulong o, ulong value);



    [DllImport(DrawDll)]
    public static extern ulong Draw_FrameDrawHandle(ulong arg);
}