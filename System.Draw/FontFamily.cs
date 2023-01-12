namespace System.Draw;





public class FontFamily : InfraObject
{
    public override bool Init()
    {
        base.Init();



        this.WinFontFamily = new WinFontFamily(this.Name);



        return true;
    }


    


    public string Name { get; set; }




    internal WinFontFamily WinFontFamily { get; set; }
}