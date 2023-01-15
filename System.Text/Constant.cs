namespace System.Text;



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



        this.DefaultCar = (char)0;




        return true;
    }





    public char DefaultCar { get; private set; }
}