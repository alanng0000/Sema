namespace System.Intern;




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
    public static extern ulong Draw_Draw_Clip(ulong o, long left, long up, ulong width, ulong height);





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
    public static extern ulong Draw_FontFamily_New();


    [DllImport(DrawDll)]
    public static extern ulong Draw_FontFamily_Init(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_FontFamily_Final(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_FontFamily_Delete(ulong o);



    [DllImport(DrawDll)]
    public static extern ulong Draw_FontFamily_GetName(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_FontFamily_SetName(ulong o, ulong value);





    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_DefaultColor(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_ColorBrushType(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_FontStyleRegular(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_FontStyleBold(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_FontStyleItalic(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_FontStyleUnderline(ulong o);


    [DllImport(DrawDll)]
    public static extern ulong Draw_Constant_StringFormat(ulong o);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Global_Constant(ulong o);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Global();





    [DllImport(DrawDll)]
    public static extern ulong Draw_FrameDrawHandle(ulong arg);




    [DllImport(DrawDll)]
    public static extern ulong Draw_Init();



    [DllImport(DrawDll)]
    public static extern ulong Draw_Final();
}