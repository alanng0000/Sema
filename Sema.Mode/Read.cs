namespace Sema.Mode;






public class Read : InfraObject
{
    public InfraData Data { get; set; }





    public int Index { get; set; }






    public Mode Mode { get; set; }




    


    public bool Execute()
    {
        this.Mode = null;




        Mode m;

        m = this.ExecuteModule();




        this.CaseArray = null;




        if (this.Null(m))
        {
            return false;
        }




        this.Mode = m;




        return true;
    }







    private Mode ExecuteModule()
    {
        ListArray varCase;

        varCase = this.ExecuteCaseArray();


        if (this.Null(varCase))
        {
            return null;
        }



        this.CaseArray = varCase;





        ListArray import;

        import = this.ExecuteImportArray();


        if (this.Null(import))
        {
            return null;
        }




        ListArray export;

        export = this.ExecuteExportArray();


        if (this.Null(export))
        {
            return null;
        }




        ListArray varBase;

        varBase = this.ExecuteBaseArray();


        if (this.Null(varBase))
        {
            return null;
        }




        ListArray member;

        member = this.ExecuteMemberArray();


        if (this.Null(member))
        {
            return null;
        }





        Mode ret;

        ret = new Mode();

        ret.Init();

        ret.Case = varCase;

        ret.Import = import;

        ret.Export = export;

        ret.Base = varBase;

        ret.Member = member;

        return ret;
    }





    private ListArray ExecuteCaseArray()
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
            Case varCase;

            varCase = this.ExecuteCaseArrayCase();



            if (this.Null(varCase))
            {
                return null;
            }



            array.Set(i, varCase);
            



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

        count = this.CaseArray.Count;




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







    private ListArray ExecuteMemberArray()
    {
        int count;

        count = this.CaseArray.Count;




        ListArray array;

        array = new ListArray();

        array.Count = count;

        array.Init();



        int i;

        i = 0;


        while (i < count)
        {
            Member member;

            member = this.ExecuteMember();



            if (this.Null(member))
            {
                return null;
            }



            array.Set(i, member);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }






    private Case ExecuteCaseArrayCase()
    {
        string name;

        name = this.ExecuteName();


        if (this.Null(name))
        {
            return null;
        }



        Case ret;

        ret = new Case();

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

        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }



        int varCase;

        varCase = u.Value;





        Import ret;

        ret = new Import();

        ret.Init();

        ret.Mode = varRef;

        ret.Case = varCase;

        return ret;
    }






    private Export ExecuteExport()
    {
        int? u;

        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }




        int varCase;

        varCase = u.Value;




        Export ret;

        ret = new Export();

        ret.Init();

        ret.Case = varCase;

        return ret;
    }






    private Base ExecuteBase()
    {
        int? u;

        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }




        int varCase;

        varCase = u.Value;




        Base ret;

        ret = new Base();

        ret.Init();

        ret.Case = varCase;

        return ret;
    }







    private Member ExecuteMember()
    {
        ListArray field;

        field = this.ExecuteFieldArray();


        if (this.Null(field))
        {
            return null;
        }




        ListArray method;

        method = this.ExecuteMethodArray();


        if (this.Null(method))
        {
            return null;
        }




        Member ret;

        ret = new Member();

        ret.Init();

        ret.Field = field;

        ret.Method = method;

        return ret;
    }







    private ListArray ExecuteFieldArray()
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
            Field field;

            field = this.ExecuteField();



            if (this.Null(field))
            {
                return null;
            }



            array.Set(i, field);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }







    private ListArray ExecuteMethodArray()
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
            Method method;

            method = this.ExecuteMethod();



            if (this.Null(method))
            {
                return null;
            }



            array.Set(i, method);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }







    private ListArray ExecuteVarArray()
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
            Var varVar;

            varVar = this.ExecuteVar();



            if (this.Null(varVar))
            {
                return null;
            }



            array.Set(i, varVar);
            



            i = i + 1;
        }



        ListArray ret;

        ret = array;

        return ret;
    }







    private Field ExecuteField()
    {
        int? u;



        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }



        int varCase;

        varCase = u.Value;




        u = this.ExecuteAccess();


        if (!u.HasValue)
        {
            return null;
        }



        int access;

        access = u.Value;




        string name;

        name = this.ExecuteName();



        if (this.Null(name))
        {
            return null;
        }




        Field ret;

        ret = new Field();

        ret.Init();

        ret.Case = varCase;

        ret.Access = access;

        ret.Name = name;

        return ret;
    }






    private Method ExecuteMethod()
    {
        int? u;



        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }



        int varCase;

        varCase = u.Value;




        u = this.ExecuteAccess();


        if (!u.HasValue)
        {
            return null;
        }



        int access;

        access = u.Value;




        string name;

        name = this.ExecuteName();



        if (this.Null(name))
        {
            return null;
        }




        ListArray param;

        param = this.ExecuteVarArray();


        
        if (this.Null(param))
        {
            return null;
        }





        Method ret;

        ret = new Method();

        ret.Init();

        ret.Case = varCase;

        ret.Access = access;

        ret.Name = name;

        ret.Param = param;

        return ret;
    }





    private Var ExecuteVar()
    {
        int? u;

        u = this.ExecuteCase();


        if (!u.HasValue)
        {
            return null;
        }



        int varCase;

        varCase = u.Value;




        string name;

        name = this.ExecuteName();


        if (this.Null(name))
        {
            return null;
        }




        Var ret;

        ret = new Var();

        ret.Init();

        ret.Case = varCase;

        ret.Name = name;

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







    private int? ExecuteCase()
    {
        return this.ExecuteIntSInt32();
    }





    private int? ExecuteAccess()
    {
        if (!this.CheckByteAvailable(1))
        {
            return null;
        }



        byte u;

        u = this.ExecuteByte();



        int a;

        a = u;




        int ret;

        ret = a;


        return ret;
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



        ulong valu;


        valu = u.Value;



        Int ret;

        ret = new Int();

        ret.Init();

        ret.Valu = valu;

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



        ulong valu;


        valu = u.Value;



        Ver ret;

        ret = new Ver();

        ret.Init();

        ret.Valu = valu;

        return ret;
    }





    private ListArray CaseArray { get; set; }






    private bool CheckByteAvailable(int count)
    {
        int a;


        a = this.Data.Valu.Length;




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


        k = convert.ByteListULong(this.Data.Valu, this.Index);




        this.Index = this.Index + count;




        ulong ret;

        ret = k;


        return ret;
    }






    private byte ExecuteByte()
    {
        byte ob;

        ob = this.Data.Valu[this.Index];



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