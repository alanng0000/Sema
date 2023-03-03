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






        this.BlockEntryIndexBitCount = 12;




        this.BlockEntryCount = 1 << this.BlockEntryIndexBitCount;
        





        int k;
        
        k = this.IntByteCount * this.ByteBitCount;




        this.BlockEntryKeyBitCount = k;




        k = this.BlockEntryCount / this.BlockEntryKeyBitCount;


        this.BlockEntryValueLoopCount = k;




        this.BlockLevelCount = 4;




        this.BlockEntryKeyAllUse = 0xffffffffffffffff;





        return true;
    }
    




    public int IntByteCount
    {
        get;
        private set;
    }



    public int ByteBitCount
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



    internal int BlockLevelCount
    {
        get;
        private set;
    }



    internal int BlockEntryIndexBitCount
    {
        get;
        private set;
    }



    internal ulong BlockEntryKeyAllUse
    {
        get;
        private set;
    }
}