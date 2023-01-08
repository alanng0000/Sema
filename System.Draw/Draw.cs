namespace System.Draw;




public class Draw : InfraObject
{
    public override bool Init()
    {
        base.Init();





        return true;
    }



    

    public bool Rect(Brush brush, Rect rect)
    {
        if (brush is ColorBrush)
        {
            ColorBrush colorBrush;


            colorBrush = (ColorBrush)brush;




            
        }



        return true;
    }








    public bool Text(char[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        



        return true;
    }
}
