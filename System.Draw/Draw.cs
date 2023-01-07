namespace System.Draw;




public class Draw : InfraObject
{
    private RangeInfra RangeInfra { get; set; }




    public override bool Init()
    {
        base.Init();




        this.RangeInfra = new RangeInfra();


        this.RangeInfra.Init();



        return true;
    }



    

    public bool Rect(Brush brush, Rect rect)
    {
        WinRectangle u;

        u = Create.This.ExecuteWinRectangle(rect);




        this.WinGraphic.FillRectangle(brush.WinBrush, u);




        return true;
    }








    public bool Text(char[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        int count;

        count = this.RangeInfra.Count(range);

    


        ReadOnlySpanChar t;


        t = new ReadOnlySpanChar(charList, range.Start, count);




        WinPoint winPoint;

        winPoint = Create.This.ExecuteWinPoint(pos);



        WinColor winColor;

        winColor = Create.This.ExecuteWinColor(color);



        WinTextRenderer.DrawText(this.WinGraphic, t, font.WinFont, winPoint, winColor, Constant.This.TextFormatFlag);




        return true;
    }
}
