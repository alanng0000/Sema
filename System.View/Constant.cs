namespace System.View;



class Constant : InfraObject
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



        this.WhiteColor = this.CreateColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);




        this.BlackColor = this.CreateColor(byte.MaxValue, 0, 0, 0);





        return true;
    }




    private Color CreateColor(byte alpha, byte red, byte green, byte blue)
    {
        Color color;

        color = new Color();

        color.Init();

        color.Alpha = alpha;

        color.Red = red;

        color.Green = green;

        color.Blue = blue;


        return color;
    }





    public Color WhiteColor
    {
        get;
        private set;
    }




    public Color BlackColor
    {
        get;
        private set;
    }
}