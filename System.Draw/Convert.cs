namespace System.Draw;




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





    public override bool Init()
    {
        base.Init();



        this.RangeInfra = new RangeInfra();



        this.RangeInfra.Init();




        return true;
    }





    private RangeInfra RangeInfra { get; set; }







    public WinRectangle WinRectangle(Rect rect)
    {
        WinRectangle u;

        u = new WinRectangle(this.WinPoint(rect.Pos), this.WinSize(rect.Size));


        return u;
    }





    public WinPoint WinPoint(Pos pos)
    {
        WinPoint u;
        
        u = new WinPoint(pos.Left, pos.Up);


        return u;
    }




    public WinSize WinSize(Size size)
    {
        WinSize u;
        
        u = new WinSize(size.Width, size.Height);


        return u;
    }




    public WinColor WinColor(Color color)
    {
        WinColor c;


        c = global::System.Drawing.Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);


        return c;
    }







    public WinFontStyle WinFontStyle(FontStyle style)
    {
        WinFontStyle t;


        t = global::System.Drawing.FontStyle.Regular;




        if (style.Bold)
        {
            t = t | global::System.Drawing.FontStyle.Bold;
        }


        if (style.Italic)
        {
            t = t | global::System.Drawing.FontStyle.Italic;
        }


        if (style.Underline)
        {
            t = t | global::System.Drawing.FontStyle.Underline;
        }




        WinFontStyle ret;


        ret = t;


        return ret;
    }





    public Size Size(WinSize winSize)
    {
        Size u;
        
        u = new Size();

        u.Init();

        u.Width = winSize.Width;

        u.Height = winSize.Height;


        return u;
    }






    public ReadOnlySpanChar ReadOnlySpanChar(CharSpan charSpan)
    {
        ReadOnlySpanChar u;


        u = new ReadOnlySpanChar();





        int start;

        start = charSpan.Range.Start;



        int count;


        count = this.RangeInfra.Count(charSpan.Range);




        if (!this.Null(charSpan.Array))
        {
            char[] a;

            a = charSpan.Array;
            


            u = new ReadOnlySpanChar(a, start, count);
        }



        if (!this.Null(charSpan.String))
        {
            string s;


            s = charSpan.String;



            u = s.AsSpan(start, count);
        }



        return u;
    }
    




    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}