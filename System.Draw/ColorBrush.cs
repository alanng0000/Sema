namespace System.Draw;





public class ColorBrush : Brush
{
    public Color Color;




    public override bool Init()
    {
        base.Init();



        WinColor c;


        c = WinColor.FromArgb(this.Color.Alpha, this.Color.Red, this.Color.Green, this.Color.Blue);



        this.WinBrush = new WinSolidBrush(c);



        return true;
    }
}
