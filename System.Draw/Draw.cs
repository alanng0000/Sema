namespace System.Draw;




public class Draw : InfraObject
{
    public Size Size;



    public ulong Handle { get; set; }



    



    public override bool Init()
    {
        base.Init();



        this.InitInternSize();



        this.InitInternDraw();




        return true;
    }






    private bool InitInternSize()
    {
        InfraConvert convert;

        convert = InfraConvert.This;




        ulong w;


        ulong h;


        w = convert.ULong(this.Size.Width);


        h = convert.ULong(this.Size.Height);




        ulong u;


        u = InfraExtern.Size_New();


        InfraExtern.Size_Init(u);



        InfraExtern.Size_SetWidth(u, w);


        InfraExtern.Size_SetHeight(u, h);



        this.InternSize = u;



        return true;
    }




    private bool InitInternDraw()
    {
        ulong draw;


        draw = DrawExtern.Draw_Draw_New();




        DrawExtern.Draw_Draw_SetHandle(draw, this.Handle);



        DrawExtern.Draw_Draw_SetSize(draw, this.InternSize);




        DrawExtern.Draw_Draw_Init(draw);



        
        InternIntern ooo;

        ooo = InternIntern.This;




        DrawDrawMethod del;

        del = new DrawDrawMethod(this.DrawExecute);



        Delegate ddc;

        ddc = del;


        this.Del = ddc;




        ulong drawMethod;


        drawMethod = ooo.MethodPointer(this.Del);




        DrawExtern.Draw_Draw_SetMethod(draw, drawMethod);




        this.InternDraw = draw;




        return true;
    }





    public virtual bool Final()
    {
        DrawExtern.Draw_Draw_Final(this.InternDraw);


        DrawExtern.Draw_Draw_Delete(this.InternDraw);




        InfraExtern.Size_Final(this.InternSize);


        InfraExtern.Size_Delete(this.InternSize);

        


        return true;
    }





    private ulong DrawExecute(ulong u)
    {




        return 1;        
    }





    private ulong InternSize;



    private ulong InternDraw;




    private SystemDelegate Del;
    



    public Rect Area;




    public Pos Pos;





    public bool SetClip()
    {
        Convert convert;


        convert = Convert.This;




        WinRectangle winRect;

        winRect = convert.WinRectangle(this.Area);



        this.WinGraphic.SetClip(winRect);



        return true;
    }




    

    public bool Rect(Rect rect, Brush brush)
    {
        this.Absolute(ref rect.Pos);




        WinRectangle u;

        u = Convert.This.WinRectangle(rect);




        this.WinGraphic.FillRectangle(brush.WinBrush, u);




        return true;
    }








    public bool Text(CharSpan charSpan, Font font, Color color, Rect destRect)
    {
        this.Absolute(ref destRect.Pos);



        Convert convert;

        convert = Convert.This;



        Constant constant;

        constant = Constant.This;




        TextConvert textConvert;

        textConvert = TextConvert.This;




        ReadOnlySpanChar u;


        u = textConvert.ReadOnlySpanChar(charSpan);




        WinFont winFont;

        winFont = font.WinFont;

        


        WinRectangle winDestRect;

        winDestRect = convert.WinRectangle(destRect);




        WinColor winColor;

        winColor = convert.WinColor(color);



        WinTextRenderer.DrawText(this.WinGraphic, u, winFont, winDestRect, winColor, constant.TextFormatFlag);




        return true;
    }





    public bool Image(Image image, Rect destRect, Rect sourceRect)
    {
        this.Absolute(ref destRect.Pos);

        



        WinBitmap winBitmap;

        winBitmap = image.WinBitmap;




        WinRectangle winDestRect;

        winDestRect = Convert.This.WinRectangle(destRect);




        WinRectangle winSourceRect;

        winSourceRect = Convert.This.WinRectangle(sourceRect);




        this.WinGraphic.DrawImage(winBitmap, winDestRect, winSourceRect, WinGraphicsUnit.Pixel);




        return true;
    }








    private bool Absolute(ref Pos pos)
    {
        pos.Left = pos.Left + this.Pos.Left;


        pos.Up = pos.Up + this.Pos.Up;



        return true;
    }
}
