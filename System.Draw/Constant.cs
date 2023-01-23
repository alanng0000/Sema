namespace System.Draw;



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




        return true;
    }
}