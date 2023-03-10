namespace Sema.Draw;




public class Convert : InfraObject
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;

        global = new Convert();

        global.Init();


        return global;
    }






    internal ulong InternColor(Color color)
    {
        this.CompIndex = 0;



        ulong c;


        c = 0;


        c = c | this.InternColorComp(color.Blue);


        c = c | this.InternColorComp(color.Green);


        c = c | this.InternColorComp(color.Red);


        c = c | this.InternColorComp(color.Alpha);



        ulong ret;

        ret = c;

        return ret;
    }




    private int CompIndex;
    


    private ulong InternColorComp(byte comp)
    {
        ulong k;


        k = this.IndexInternColorComp(comp, this.CompIndex);



        this.CompIndex = this.CompIndex + 1;



        ulong ret;

        ret = k;

        return ret;
    }





    private ulong IndexInternColorComp(byte comp, int index)
    {
        InfraConstant constant;

        constant = InfraConstant.This;


        InfraConvert convert;

        convert = InfraConvert.This;




        int shiftCount;

        shiftCount = constant.ByteBitCount * index;





        ulong k;


        k = comp;


        k = k << shiftCount;



        ulong ret;

        ret = k;

        return ret;
    }





    internal ulong InternFontStyle(FontStyle style)
    {
        ulong t;


        t = 0;



        ulong gg;

        gg = DrawExtern.Draw_Global();



        ulong cc;

        cc = DrawExtern.Draw_Global_Constant(gg);



        
        if (style.Bold)
        {
            t = t | DrawExtern.Draw_Constant_FontStyleBold(cc);
        }


        if (style.Italic)
        {
            t = t | DrawExtern.Draw_Constant_FontStyleItalic(cc);
        }


        if (style.Underline)
        {
            t = t | DrawExtern.Draw_Constant_FontStyleUnderline(cc);
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