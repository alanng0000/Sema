namespace System.Draw;




class Convert : InfraObject
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;

        global = new Convert();

        global.Init();


        return global;
    }











    public ulong InternColor(Color color)
    {
        ulong c;


        c = 0;


        return c;
    }







    public ulong InternFontStyle(FontStyle style)
    {
        ulong t;


        t = 0;




        if (style.Bold)
        {
            t = t | 0;
        }


        if (style.Italic)
        {
            t = t | 0;
        }


        if (style.Underline)
        {
            t = t | 0;
        }




        ulong ret;


        ret = t;


        return ret;
    }





    public Size Size(ulong internSize)
    {
        ulong width;

        width = InfraExtern.Size_GetWidth(internSize);


        ulong height;

        height = InfraExtern.Size_GetHeight(internSize);



        InfraConvert convert;

        convert = InfraConvert.This;


        int w;

        w = convert.SInt32(width);


        int h;

        h = convert.SInt32(height);



        Size u;
        
        u = new Size();

        u.Init();

        u.Width = w;

        u.Height = h;


        return u;
    }





    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}