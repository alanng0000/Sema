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





    public ulong ByteListULong(byte[] u, int start)
    {
        InfraConstant constant;

        constant = InfraConstant.This;



        InfraConvert convert;

        convert = InfraConvert.This;




        int m;

        m = constant.ByteBitCount;



        int ua;

        ua = constant.IntByteCount;




        byte ob;



        ulong k;



        int index;




        ulong h;

        h = 0;



        int shiftCount;




        int count;

        count = ua;



        int i;

        i = 0;


        while (i < count)
        {
            shiftCount = i * m;



            index = start + i;



            ob = u[index];



            k = ob;
            

            k = k << shiftCount;



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