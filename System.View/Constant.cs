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




        this.CompMax = byte.MaxValue;




        this.WhiteColor = this.CreateDrawColor(this.CompMax, this.CompMax, this.CompMax, this.CompMax);




        this.BlackColor = this.CreateDrawColor(this.CompMax, 0, 0, 0);




        this.TransparentColor = this.CreateDrawColor(0, 0, 0, 0);





        return true;
    }

    




    private DrawColor CreateDrawColor(byte alpha, byte red, byte green, byte blue)
    {
        DrawColor color;

        color = new DrawColor();

        color.Init();

        color.Alpha = alpha;

        color.Red = red;

        color.Green = green;

        color.Blue = blue;


        return color;
    }




    private byte CompMax;





    public byte ColorCompMax
    {
        get
        {
            return this.CompMax;
        }
    }




    public DrawColor WhiteColor
    {
        get;
        private set;
    }




    public DrawColor BlackColor
    {
        get;
        private set;
    }



    public DrawColor TransparentColor
    {
        get;
        private set;
    }
}