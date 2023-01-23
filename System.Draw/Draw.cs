namespace System.Draw;




public class Draw : InfraObject
{
    public Size Size;



    public ulong Video { get; set; }




    public Handle Handle { get; set; }





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




        DrawExtern.Draw_Draw_SetHandle(draw, this.Video);



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
        this.Handle.Execute(this);



        return 1;        
    }





    private ulong InternSize;




    public ulong InternDraw;




    private SystemDelegate Del;
    



    public Rect Area;




    public Pos Pos;





    public bool Clip()
    {
        InfraConvert convert;

        convert = InfraConvert.This;




        long left;

        left = this.Area.Pos.Left;


        long up;

        up = this.Area.Pos.Up;


        ulong width;

        width = convert.ULong(this.Area.Size.Width);


        ulong height;

        height = convert.ULong(this.Area.Size.Height);




        DrawExtern.Draw_Draw_Clip(this.InternDraw, left, up, width, height);




        return true;
    }




    

    public bool Rect(Rect rect, Brush brush)
    {
        this.Absolute(ref rect.Pos);




        InfraConvert convert;

        convert = InfraConvert.This;




        long left;

        left = rect.Pos.Left;


        long up;

        up = rect.Pos.Up;


        ulong width;

        width = convert.ULong(rect.Size.Width);


        ulong height;

        height = convert.ULong(rect.Size.Height);




        ulong brushU;


        brushU = brush.Intern;




        DrawExtern.Draw_Draw_Rect(this.InternDraw, left, up, width, height, brushU);




        return true;
    }






    public bool Text(CharSpan text, Rect destRect, Font font, Brush brush)
    {
        this.Absolute(ref destRect.Pos);




        char[] textU;

        textU = text.Array;



        InfraRange range;

        range = text.Range;




        InfraConvert convert;

        convert = InfraConvert.This;




        long destLeft;

        destLeft = destRect.Pos.Left;


        long destUp;

        destUp = destRect.Pos.Up;


        ulong destWidth;

        destWidth = convert.ULong(destRect.Size.Width);


        ulong destHeight;

        destHeight = convert.ULong(destRect.Size.Height);





        ulong fontU;

        fontU = font.Intern;

        


        ulong brushU;

        brushU = brush.Intern;





        InternIntern intern;

        intern = InternIntern.This;




        intern.DrawDrawText(this.InternDraw, textU, range, destLeft, destUp, destWidth, destHeight, fontU, brushU);




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
