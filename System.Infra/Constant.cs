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



        ulong n;
        
        n = this.IntByteCount * this.ByteBitCount;




        Convert convert;

        convert = Convert.This;



        int k;

        k = convert.SInt32(n);


        this.BlockEntryKeyBitCount = k;




        k = this.BlockEntryCount / this.BlockEntryKeyBitCount;


        this.BlockEntryValueLoopCount = k;



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





    internal int BlockEntryCount
    {
        get;
        private set;
    }




    internal int BlockEntryKeyBitCount
    {
        get;
        private set;
    }




    internal int BlockEntryValueLoopCount
    {
        get;
        private set;
    }
}