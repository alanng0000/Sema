namespace System.Draw;





public class ColorBrush : Brush
{
    public Color Color;




    public override bool Init()
    {
        base.Init();




        WinColor winColor;


        winColor = Create.This.ExecuteWinColor(this.Color);



        this.WinBrush = new WinSolidBrush(winColor);



        return true;
    }
}
