namespace System.Draw;




public class Draw : InfraObject
{
    public WinGraphics WinGraphics { get; set; }






    
    public bool Rect(Brush brush, Rect rect)
    {
        WinRectangle u;

        u = this.CreateWinRectangle(rect);



        this.WinGraphics.FillRectangle(brush.WinBrush, u);




        return true;
    }








    public bool Text(char[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        return true;
    }

    




    private WinRectangle CreateWinRectangle(Rect rect)
    {
        WinRectangle u;

        u = new WinRectangle(this.CreateWinPoint(rect.Pos), this.CreateWinSize(rect.Size));


        return u;
    }





    private WinPoint CreateWinPoint(Pos pos)
    {
        WinPoint u;
        
        u = new WinPoint(pos.Left, pos.Up);


        return u;
    }




    private WinSize CreateWinSize(Size size)
    {
        WinSize u;
        
        u = new WinSize(size.Width, size.Height);


        return u;
    }
}
