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




        this.CompMax = byte.MaxValue;




        this.WhiteColor = this.CreateColor(this.CompMax, this.CompMax, this.CompMax, this.CompMax);




        this.BlackColor = this.CreateColor(this.CompMax, 0, 0, 0);





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




    private byte CompMax;





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