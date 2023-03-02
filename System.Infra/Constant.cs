namespace System.Infra;




public class Constant : Object
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




        this.IntByteCount = sizeof(ulong);



        this.ByteBitCount = 8;





        this.BlockEntryCount = 4 * 1024;
        



        return true;
    }




    public ulong IntByteCount
    {
        get;
        private set;
    }



    public ulong ByteBitCount
    {
        get;
        private set;
    }




    internal ulong BlockEntryCount
    {
        get;
        private set;
    }
}