namespace System.Draw;




public class Draw : InfraObject
{
    public override bool Init()
    {
        base.Init();



        return true;
    }





    private Rect AreaData;





    public Rect Area
    {
        get
        {
            return this.AreaData;
        }
        set
        {
            this.AreaData = value;
        }
    }






    
    public bool Rect(Brush brush, Rect rect)
    {
        return true;
    }








    public bool Text(CharSpan charSpan, Font font, Color color, Pos pos)
    {
        return true;
    }
}
