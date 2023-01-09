namespace System.Draw;




public class Draw : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.RangeInfra = new RangeInfra();


        this.RangeInfra.Init();



        return true;
    }





    private WinGraphics WinGraphic { get; set; }




    private RangeInfra RangeInfra { get; set; }





    public Rect Area;




    public Pos Pos;





    public bool SetClip()
    {
        WinRectangle winRect;

        winRect = Convert.This.WinRectangle(this.Area);



        this.WinGraphic.SetClip(winRect);



        return true;
    }




    public bool SetWin(WinGraphics graphic)
    {
        this.WinGraphic = graphic;



        this.SetGraphicDefault(this.WinGraphic);




        return true;
    }






    private bool SetGraphicDefault(WinGraphics g)
    {
        g.TextRenderingHint = WinTextRenderingHint.ClearTypeGridFit;


        g.PageUnit = WinGraphicsUnit.Pixel;


        return true;
    }




    

    public bool Rect(Brush brush, Rect rect)
    {
        this.Absolute(ref rect.Pos);




        WinRectangle u;

        u = Convert.This.WinRectangle(rect);




        this.WinGraphic.FillRectangle(brush.WinBrush, u);




        return true;
    }








    public bool Text(char[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        int count;

        count = this.RangeInfra.Count(range);

    


        ReadOnlySpanChar t;


        t = new ReadOnlySpanChar(charList, range.Start, count);




        this.Absolute(ref pos);


        


        WinPoint winPoint;

        winPoint = Convert.This.WinPoint(pos);



        WinColor winColor;

        winColor = Convert.This.WinColor(color);



        WinTextRenderer.DrawText(this.WinGraphic, t, font.WinFont, winPoint, winColor, Constant.This.TextFormatFlag);




        return true;
    }






    private bool Absolute(ref Pos pos)
    {
        pos.Left = pos.Left + this.Pos.Left;


        pos.Up = pos.Up + this.Pos.Up;



        return true;
    }
}
