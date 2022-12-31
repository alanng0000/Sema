namespace System.Module;







public class Read : InfraObject
{
    public InfraData Data { get; set; }



    private ulong Index { get; set; }



    public Module Execute()
    {




        return null;
    }




    private ulong IntByteCount
    {
        get
        {
            return sizeof(ulong);
        }
    }



    private ulong ByteBitCount
    {
        get
        {
            return 8;
        }
    }





    

    private bool CheckByteAvailable(ulong count)
    {
        ulong a;


        a = (ulong)this.Data.Value.Length;



        return this.Index + count <= a;
    }





    private ulong? ExecuteInt()
    {
        ulong count;


        count = this.IntByteCount;



        if (!this.CheckByteAvailable(count))
        {
            return null;
        }





        ulong d;


        d = 0;



        ulong k;



        byte a;



        ulong shiftCount;



        int u;





        ulong i;

        i = 0;


        while (i < count)
        {
            a = this.Byte();



        
            shiftCount = this.ByteBitCount * i;



            u = this.SInt32(shiftCount);



            k = a;
            
            
            k = k << u;



            d = d | k;




            i = i + 1;
        }



        ulong ret;


        ret = d;


        return ret;
    }





    private byte Byte()
    {
        byte ob;

        ob = this.Data.Value[this.Index];



        this.Index = this.Index + 1;



        byte ret;

        ret = ob;

        return ret;
    }




    private int SInt32(ulong k)
    {
        return (int)k;
    }
}