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




    private Module ExecuteModule()
    {
        ListArray varClass;

        varClass = this.ExecuteClassArray();


        if (this.Null(varClass))
        {
            return null;
        }



        this.ClassArray = varClass;






        Module ret;

        ret = new Module();

        ret.Init();

        ret.Class = varClass;

        return ret;
    }





    private ListArray ExecuteClassArray()
    {
        int? u;

        u = this.ExecuteCount();


        if (!u.HasValue)
        {
            return null;
        }



        int count;

        count = u.Value;




        ListArray array;

        array = new ListArray();

        array.Count = count;

        array.Init();



        int i;

        i = 0;


        while (i < count)
        {
            Class varClass;

            varClass = this.ExecuteClassArrayClass();



            if (this.Null(varClass))
            {
                return null;
            }



            array.Set(i, varClass);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }







    private ListArray ExecuteImportArray()
    {
        int? u;

        u = this.ExecuteCount();


        if (!u.HasValue)
        {
            return null;
        }



        int count;

        count = u.Value;




        ListArray array;

        array = new ListArray();

        array.Count = count;

        array.Init();



        int i;

        i = 0;


        while (i < count)
        {
            Import import;

            import = this.ExecuteImport();



            if (this.Null(import))
            {
                return null;
            }



            array.Set(i, import);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }






    private ListArray ExecuteExportArray()
    {
        int? u;

        u = this.ExecuteCount();


        if (!u.HasValue)
        {
            return null;
        }



        int count;

        count = u.Value;




        ListArray array;

        array = new ListArray();

        array.Count = count;

        array.Init();



        int i;

        i = 0;


        while (i < count)
        {
            Export export;

            export = this.ExecuteExport();



            if (this.Null(export))
            {
                return null;
            }



            array.Set(i, export);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }






    private ListArray ExecuteBaseArray()
    {
        int count;

        count = this.ClassArray.Count;




        ListArray array;

        array = new ListArray();

        array.Count = count;

        array.Init();



        int i;

        i = 0;


        while (i < count)
        {
            Base varBase;

            varBase = this.ExecuteBase();



            if (this.Null(varBase))
            {
                return null;
            }



            array.Set(i, varBase);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }






    private Class ExecuteClassArrayClass()
    {
        string name;

        name = this.ExecuteName();


        if (this.Null(name))
        {
            return null;
        }



        Class ret;

        ret = new Class();

        ret.Init();

        ret.Name = name;

        return ret;
    }






    private Import ExecuteImport()
    {
        Ref varRef;

        varRef = this.ExecuteModuleRef();


        if (this.Null(varRef))
        {
            return null;
        }




        int? u;

        u = this.ExecuteClass();


        if (!u.HasValue)
        {
            return null;
        }



        int varClass;

        varClass = u.Value;





        Import ret;

        ret = new Import();

        ret.Init();

        ret.Module = varRef;

        ret.Class = varClass;

        return ret;
    }






    private Export ExecuteExport()
    {
        int? u;

        u = this.ExecuteClass();


        if (!u.HasValue)
        {
            return null;
        }




        int varClass;

        varClass = u.Value;




        Export ret;

        ret = new Export();

        ret.Init();

        ret.Class = varClass;

        return ret;
    }






    private Base ExecuteBase()
    {
        int? u;

        u = this.ExecuteClass();


        if (!u.HasValue)
        {
            return null;
        }




        int varClass;

        varClass = u.Value;




        Base ret;

        ret = new Base();

        ret.Init();

        ret.Class = varClass;

        return ret;
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




    private int? ExecuteCount()
    {
        return this.ExecuteIntSInt32();
    }




    private string ExecuteName()
    {
        return this.ExecuteString();
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





    private ListArray ClassArray { get; set; }






    private bool CheckByteAvailable(int count)
    {
        int a;


        a = this.Data.Value.Length;




        return this.Index + count <= a;
    }





    private string ExecuteString()
    {
        int? u;


        u = this.ExecuteCount();



        if (!u.HasValue)
        {
            return null;
        }





        int count;

        count = u.Value;




        if (!this.CheckByteAvailable(count))
        {
            return null;
        }





        InfraConvert convert;

        convert = InfraConvert.This;





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







    private ulong? ExecuteInt()
    {
        InfraConstant constant;

        constant = InfraConstant.This;



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