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




        int m;

        m = constant.ByteBitCount;



        int ua;

        ua = constant.IntByteCount;




        byte ob;



        ulong k;



        ulong index;



        ulong uu;




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



            uu = convert.ULong(i);



            index = start + uu;



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