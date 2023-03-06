namespace Sema.Draw;



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



        Infra infra;


        infra = Infra.This;




        this.CompMax = byte.MaxValue;




        this.WhiteColor = infra.CreateColor(this.CompMax, this.CompMax, this.CompMax, this.CompMax);




        this.BlackColor = infra.CreateColor(this.CompMax, 0, 0, 0);




        this.TransparentColor = infra.CreateColor(0, 0, 0, 0);




        return true;
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



    public Color TransparentColor
    {
        get;
        private set;
    }





    private byte CompMax;





    public byte ColorCompMax
    {
        get
        {
            return this.CompMax;
        }
    }
}