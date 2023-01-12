namespace System.Draw;





public class Font : InfraObject
{
    public override bool Init()
    {
        base.Init();





        WinFontFamily family;


        family = this.Family.WinFontFamily;


        


        int end;

        end = 100;


        if (!(this.Size < end))
        {
            this.Size = end - 1;
        }




        float size;

        size = this.Size;





        WinFontStyle style;


        style = Convert.This.WinFontStyle(this.Style);






        this.WinFont = new WinFont(family, size, style, WinGraphicsUnit.Pixel);







        return true;
    }





    public bool Close()
    {
        this.WinFont.Dispose();


        this.WinFont = null;

        

        return true;
    }

    




    public FontFamily Family { get; set; }




    public int Size { get; set; }




    public FontStyle Style { get; set; }





    internal WinFont WinFont { get; set; }
}
