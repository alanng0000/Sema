namespace System.Draw;





public class Font : InfraObject
{
    public override bool Init()
    {
        base.Init();





        WinFontFamily family;


        family = new WinFontFamily(this.Family);


        



        if (100 < this.Size)
        {
            this.Size = 100;
        }



        float size;

        size = this.Size;





        WinFontStyle style;


        style = this.CreateWinFontStyle(this.Style);






        this.WinFont = new WinFont(family, size, style, WinGraphicsUnit.Pixel);







        return true;
    }





    private WinFontStyle CreateWinFontStyle(FontStyle style)
    {
        WinFontStyle t;


        t = WinFontStyle.Regular;




        if (style.Bold)
        {
            t = t | WinFontStyle.Bold;
        }


        if (style.Italic)
        {
            t = t | WinFontStyle.Italic;
        }


        if (style.Underline)
        {
            t = t | WinFontStyle.Underline;
        }




        WinFontStyle ret;


        ret = t;


        return ret;
    }







    public string Family { get; set; }




    public int Size { get; set; }




    public FontStyle Style { get; set; }





    internal WinFont WinFont { get; set; }
}
