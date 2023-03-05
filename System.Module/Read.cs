namespace System.Module;






public class Read : InfraObject
{
    public InfraData Data { get; set; }





    public int Index { get; set; }






    public Module Module { get; set; }




    


    public bool Execute()
    {
        this.Module = null;












        return true;
    }







    private Ref ExecuteModuleRef()
    {
        Int varInt;

        varInt = this.ExecuteModuleInt();


        if (this.Null(varInt))
        {
            return null;
        }




        Ver ver;

        ver = this.ExecuteModuleVer();


        if (this.Null(ver))
        {
            return null;
        }




        Ref ret;

        ret = new Ref();

        ret.Init();

        ret.Int = varInt;

        ret.Ver = ver;

        return ret;
    }







    private int? ExecuteClass()
    {
        return this.ExecuteIntSInt32();
    }






    private int? ExecuteIntSInt32()
    {
        ulong? u;

        u = this.ExecuteInt();



        if (!u.HasValue)
        {
            return null;
        }



        ulong ua;

        ua = u.Value;



        InfraConvert convert;

        convert = InfraConvert.This;



        int k;

        k = convert.SInt32(ua);
    



        int ret;

        ret = k;


        return ret;
    }






    private Int ExecuteModuleInt()
    {
        ulong? u;

        u = this.ExecuteInt();


        if (!u.HasValue)
        {
            return null;
        }



        ulong value;


        value = u.Value;



        Int ret;

        ret = new Int();

        ret.Init();

        ret.Value = value;

        return ret;
    }






    private Ver ExecuteModuleVer()
    {
        ulong? u;

        u = this.ExecuteInt();


        if (!u.HasValue)
        {
            return null;
        }



        ulong value;


        value = u.Value;



        Ver ret;

        ret = new Ver();

        ret.Init();

        ret.Value = value;

        return ret;
    }






    private bool CheckByteAvailable(int count)
    {
        InfraConvert convert;

        convert = InfraConvert.This;




        int a;


        a = this.Data.Value.Length;




        return this.Index + count <= a;
    }





    private string ExecuteString()
    {
        ulong? u;


        u = this.ExecuteCount();



        if (!u.HasValue)
        {
            return null;
        }




        ulong k;

        k = u.Value;




        InfraConvert convert;

        convert = InfraConvert.This;




        int uu;

        uu = convert.SInt32(k);




        int count;

        count = uu;




        if (!this.CheckByteAvailable(count))
        {
            return null;
        }




        char[] array;


        array = new char[count];

        



        char oc;


        byte ob;




        int i;


        i = 0;



        while (i < count)
        {
            ob = this.ExecuteByte();



            oc = convert.ByteChar(ob);



            array[i] = oc;



            i = i + 1;
        }




        string s;


        s = new string(array);




        string ret;

        ret = s;


        return ret;
    }





    private ulong? ExecuteCount()
    {
        ulong? u;

        u = this.ExecuteInt();


        return u;
    }





    private ulong? ExecuteInt()
    {
        InfraConstant constant;

        constant = InfraConstant.This;



        InfraConvert infraConvert;

        infraConvert = InfraConvert.This;



        Convert convert;

        convert = Convert.This;




        int aa;

        aa = constant.IntByteCount;




        int count;


        count = aa;




        if (!this.CheckByteAvailable(count))
        {
            return null;
        }




        ulong k;


        k = convert.ByteListULong(this.Data.Value, this.Index);




        this.Index = this.Index + count;




        ulong ret;

        ret = k;


        return ret;
    }






    private byte ExecuteByte()
    {
        byte ob;

        ob = this.Data.Value[this.Index];



        this.Index = this.Index + 1;



        byte ret;

        ret = ob;

        return ret;
    }






    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}