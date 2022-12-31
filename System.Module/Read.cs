namespace System.Module;







public class Read : InfraObject
{
    public InfraData Data { get; set; }



    public ulong Index { get; set; }






    public Module Execute()
    {
        Module module;


        module = this.ExecuteModule();




        Module ret;

        ret = module;


        return ret;
    }




    private Module ExecuteModule()
    {
        ModuleName name;

        name = this.ExecuteModuleName();


        if (this.Null(name))
        {
            return null;
        }



        Ver ver;

        ver = this.ExecuteVer();


        if (!this.Null(ver))
        {
            return null;
        }




        Module ret;

        ret = new Module();

        ret.Name = name;

        ret.Ver = ver;

        return ret;
    }





    private ModuleName ExecuteModuleName()
    {
        string value;


        value = this.NameValue();



        if (this.Null(value))
        {
            return null;
        }




        ModuleName ret;

        ret = new ModuleName();

        ret.Init();

        ret.Value = value;


        return ret;
    }






    private ClassName ExecuteClassName()
    {
        string value;


        value = this.NameValue();



        if (this.Null(value))
        {
            return null;
        }




        ClassName ret;

        ret = new ClassName();

        ret.Init();

        ret.Value = value;


        return ret;
    }





    private Ver ExecuteVer()
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





    
    private ImportList ExecuteImportList()
    {
        ulong? u;


        u = this.Count();




        if (!u.HasValue)
        {
            return null;
        }




        ImportList list;

        list = new ImportList();

        list.Init();





        Import import;




        ulong count;

        count = u.Value;




        ulong i;

        i = 0;


        while (i < count)
        {
            import = this.ExecuteImport();


            if (this.Null(import))
            {
                return null;
            }



            list.Add(import);



            i = i + 1;
        }



        ImportList ret;

        ret = list;

        return ret;
    }






    private Import ExecuteImport()
    {
        ModuleName module;

        module = this.ExecuteModuleName();


        if (this.Null((module)))
        {
            return null;
        }




        Ver ver;

        ver = this.ExecuteVer();


        if (this.Null(ver))
        {
            return null;
        }




        ClassName varClass;

        varClass = this.ExecuteClassName();


        if (this.Null(varClass))
        {
            return null;
        }





        ClassName name;

        name = this.ExecuteClassName();


        if (this.Null(name))
        {
            return null;
        }



        Import ret;

        ret = new Import();

        ret.Init();

        ret.Module = module;

        ret.Ver = ver;

        ret.Class = varClass;

        ret.Name = name;

        return ret;
    }






    private ulong? Count()
    {
        ulong? u;

        u = this.ExecuteInt();


        return u;
    }
    





    private string NameValue()
    {
        string value;

        value = this.ExecuteString();



        return value;
    }






    private ulong IntByteCount
    {
        get
        {
            return sizeof(ulong);
        }
        set
        {
        }
    }



    private ulong ByteBitCount
    {
        get
        {
            return 8;
        }
        set
        {
        }
    }



    

    private bool CheckByteAvailable(ulong count)
    {
        ulong a;


        a = this.ULong(this.Data.Value.Length);



        return this.Index + count <= a;
    }





    private string ExecuteString()
    {
        ulong? u;


        u = this.ExecuteInt();



        if (!u.HasValue)
        {
            return null;
        }




        ulong count;

        count = u.Value;




        if (!this.CheckByteAvailable(count))
        {
            return null;
        }




        StringBuilder sb;


        sb = new StringBuilder();




        char oc;


        byte ob;




        ulong i;


        i = 0;



        while (i < count)
        {
            ob = this.Byte();



            oc = (char)ob;



            sb.Append(oc);



            i = i + 1;
        }



        string s;


        s = sb.ToString();




        string ret;

        ret = s;


        return ret;
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






    private bool Null(object o)
    {
        return o == null;
    }





    private ulong ULong(int k)
    {
        return (ulong)k;
    }




    private int SInt32(ulong k)
    {
        return (int)k;
    }
}