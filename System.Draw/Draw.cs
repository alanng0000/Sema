namespace System.Draw;




public class Draw : InfraObject
{
    private WinGraphics WinGraphic { get; set; }






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




    public bool SetWin(WinGraphics graphic)
    {
        this.WinGraphic = graphic;



        this.SetWinDefault(this.WinGraphic);




        return true;
    }






    private bool SetWinDefault(WinGraphics g)
    {
        g.TextRenderingHint = WinTextRenderingHint.ClearTypeGridFit;


        g.PageUnit = WinGraphicsUnit.Pixel;


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
