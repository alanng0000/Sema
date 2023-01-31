namespace System.Draw;




public class Draw : InfraObject
{
    public Size Size;



    public ulong Video { get; set; }





    public override bool Init()
    {
        base.Init();



        this.InitInternSize();



        this.InitIntern();




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




    private bool InitIntern()
    {
        ulong draw;


        draw = DrawExtern.Draw_Draw_New();




        DrawExtern.Draw_Draw_SetHandle(draw, this.Video);



        DrawExtern.Draw_Draw_SetSize(draw, this.InternSize);




        DrawExtern.Draw_Draw_Init(draw);





        this.Intern = draw;




        return true;
    }





    public virtual bool Final()
    {
        DrawExtern.Draw_Draw_Final(this.Intern);


        DrawExtern.Draw_Draw_Delete(this.Intern);




        InfraExtern.Size_Final(this.InternSize);


        InfraExtern.Size_Delete(this.InternSize);

        


        return true;
    }






    private ulong InternSize { get; set; }




    private ulong Intern { get; set; }






    public Rect Area;




    public Pos Pos;






    public bool Clear(Color color)
    {
        Convert convert;

        convert = Convert.This;



        ulong colorU;


        colorU = convert.InternColor(color);



        DrawExtern.Draw_Draw_Clear(this.Intern, colorU);



        return true;
    }






    public bool Result()
    {
        DrawExtern.Draw_Draw_Result(this.Intern);



        return true;
    }





    public bool Clip()
    {
        InfraConvert convert;

        convert = InfraConvert.This;




        long left;

        left = this.Area.Pos.Left;


        long up;

        up = this.Area.Pos.Up;



        ulong leftI;

        leftI = (ulong)left;


        ulong upI;

        upI = (ulong)up;



        ulong width;

        width = convert.ULong(this.Area.Size.Width);


        ulong height;

        height = convert.ULong(this.Area.Size.Height);




        DrawExtern.Draw_Draw_Clip(this.Intern, leftI, upI, width, height);




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



        ulong leftI;

        leftI = (ulong)left;


        ulong upI;

        upI = (ulong)up;



        ulong width;

        width = convert.ULong(rect.Size.Width);


        ulong height;

        height = convert.ULong(rect.Size.Height);




        ulong brushU;


        brushU = brush.Intern;




        DrawExtern.Draw_Draw_Rect(this.Intern, leftI, upI, width, height, brushU);




        return true;
    }






    public bool Text(CharSpan text, Rect destRect, Font font, Brush brush)
    {        
        InternIntern intern;

        intern = InternIntern.This;



        if (!intern.CheckCharSpan(text.String, text.Array, text.Range))
        {
            return true;
        }





        this.Absolute(ref destRect.Pos);





        InfraConvert convert;

        convert = InfraConvert.This;




        long destLeft;

        destLeft = destRect.Pos.Left;


        long destUp;

        destUp = destRect.Pos.Up;




        ulong destLeftI;

        destLeftI = (ulong)destLeft;


        ulong destUpI;

        destUpI = (ulong)destUp;




        ulong destWidth;

        destWidth = convert.ULong(destRect.Size.Width);


        ulong destHeight;

        destHeight = convert.ULong(destRect.Size.Height);





        ulong fontU;

        fontU = font.Intern;

        


        ulong brushU;

        brushU = brush.Intern;




        intern.DrawDrawText(this.Intern, text.String, text.Array, text.Range, destLeftI, destUpI, destWidth, destHeight, fontU, brushU);




        return true;
    }






    public bool Image(Image image, Rect destRect, Rect sourceRect)
    {
        this.Absolute(ref destRect.Pos);

        



        ulong imageU;

        imageU = image.Intern;





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





        long sourceLeft;

        sourceLeft = sourceRect.Pos.Left;


        long sourceUp;

        sourceUp = sourceRect.Pos.Up;


        ulong sourceWidth;

        sourceWidth = convert.ULong(sourceRect.Size.Width);


        ulong sourceHeight;

        sourceHeight = convert.ULong(sourceRect.Size.Height);





        DrawExtern.Draw_Draw_Image(this.Intern, imageU, destLeft, destUp, destWidth, destHeight,
            sourceLeft, sourceUp, sourceWidth, sourceHeight
        );



        return true;
    }






    private bool Absolute(ref Pos pos)
    {
        pos.Left = pos.Left + this.Pos.Left;


        pos.Up = pos.Up + this.Pos.Up;



        return true;
    }




    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}
