namespace System.Module;



public class Convert : InfraObject
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;


        global = new Convert();



        global.Init();



        return global;
    }





    public ulong ByteListULong(byte[] u, ulong start)
    {
        InfraConstant constant;

        constant = InfraConstant.This;



        InfraConvert convert;

        convert = InfraConvert.This;




        ulong m;

        m = constant.ByteBitCount;



        byte ob;



        ulong k;



        ulong index;




        ulong h;

        h = 0;



        ulong shiftCount;


        int v;



        ulong count;

        count = constant.IntByteCount;



        ulong i;

        i = 0;


        while (i < count)
        {
            shiftCount = i * m;


            v = convert.SInt32(shiftCount);



            index = start + i;



            ob = u[index];



            k = ob;
            

            k = k << v;



            h = h | k;



            i = i + 1;
        }



        ulong ret;

        ret = h;


        return ret;
    }






    public string Int60BitListString(ulong a)
    {
        return a.ToString("x15");
    }
}