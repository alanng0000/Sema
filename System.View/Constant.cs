namespace System.View;



public class Constant : InfraObject
{
    public static Constant This { get; } = CreateGlobal();




    private static Constant CreateGlobal()
    {
        Constant global;

        global = new Constant();

        global.Init();


        return global;
    }




    public override bool Init()
    {
        base.Init();




        FontFamily fontFamily;

        fontFamily = new FontFamily();

        fontFamily.Name = "Segoe UI Variable Display";

        fontFamily.Init();

        

        FontStyle fontStyle;

        fontStyle = new FontStyle();

        fontStyle.Init();




        Font font;


        font = new Font();


        font.Family = fontFamily;


        font.Size = 16;


        font.Style = fontStyle;


        font.Init();



        this.DefaultFont = font;



        return true;
    }





    public Font DefaultFont { get; private set; }
}