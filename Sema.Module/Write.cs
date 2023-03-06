namespace Sema.Module;




public class Write : InfraObject
{
    public Module Module { get; set; }




    
    public InfraData Data { get; set; }




    public bool Execute()
    {
        this.Data = null;




        InfraConvert convert;

        convert = InfraConvert.This;





        CountByteOp countOp;

        countOp = new CountByteOp();

        countOp.Write = this;

        countOp.Init();



        this.ByteOp = countOp;




        
        this.Index = 0;



        this.ExecuteRefer(this.Module);





        int referSize;

        referSize = this.Index;




        this.Index = 0;


        
        this.ExecuteState(this.Module);





        int stateSize;
        
        stateSize = this.Index;






        InfraConstant constant;

        constant = InfraConstant.This;




        int ua;

        ua = constant.IntByteCount;




        int totalSize;

        totalSize = referSize + stateSize + 2 * ua;
        




        byte[] ud;

        ud = new byte[totalSize];



        this.Data = new InfraData();

        this.Data.Init();

        this.Data.Value = ud;






        WriteByteOp writeOp;

        writeOp = new WriteByteOp();

        writeOp.Write = this;

        writeOp.Init();



        this.ByteOp = writeOp;




        
        this.Index = 0;




        this.ExecuteSize(referSize);



        this.ExecuteSize(stateSize);




        this.ExecuteRefer(this.Module);


        this.ExecuteState(this.Module);





        return true;
    }






    private bool ExecuteRefer(Module module)
    {
        this.ExecuteClassArray(module.Class);



        this.ExecuteImportArray(module.Import);



        this.ExecuteExportArray(module.Export);



        this.ExecuteBaseArray(module.Base);



        this.ExecuteMemberArray(module.Member);



        return true;
    }






    private bool ExecuteState(Module module)
    {
        return true;
    }






    private bool ExecuteModuleRef(Ref varRef)
    {
        this.ExecuteModuleInt(varRef.Int);


        this.ExecuteModuleVer(varRef.Ver);



        return true;
    }





    private bool ExecuteModuleInt(Int varInt)
    {
        this.ExecuteInt(varInt.Value);


        return true;
    }




    private bool ExecuteModuleVer(Ver ver)
    {
        this.ExecuteInt(ver.Value);


        return true;
    }





    private bool ExecuteClassArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Class varClass;

            varClass = (Class)array.Get(i);



            this.ExecuteClassArrayClass(varClass);




            i = i + 1;
        }



        return true;
    }







    private bool ExecuteImportArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Import import;

            import = (Import)array.Get(i);



            this.ExecuteImport(import);



            i = i + 1;
        }



        return true;
    }






    private bool ExecuteExportArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Export export;

            export = (Export)array.Get(i);




            this.ExecuteExport(export);




            i = i + 1;
        }



        return true;
    }







    private bool ExecuteBaseArray(ListArray array)
    {
        int count;

        count = array.Count;





        int i;

        i = 0;


        while (i < count)
        {
            Base varBase;

            varBase = (Base)array.Get(i);




            this.ExecuteBase(varBase);




            i = i + 1;
        }



        return true;
    }








    private bool ExecuteMemberArray(ListArray array)
    {
        int count;

        count = array.Count;





        int i;

        i = 0;


        while (i < count)
        {
            Member member;

            member = (Member)array.Get(i);




            this.ExecuteMember(member);




            i = i + 1;
        }



        return true;
    }






    private bool ExecuteClassArrayClass(Class varClass)
    {
        this.ExecuteName(varClass.Name);


        return true;
    }






    private bool ExecuteImport(Import import)
    {
        this.ExecuteModuleRef(import.Module);


        this.ExecuteClass(import.Class);


        return true;
    }





    private bool ExecuteExport(Export export)
    {
        this.ExecuteClass(export.Class);


        return true;
    }





    private bool ExecuteBase(Base varBase)
    {
        this.ExecuteClass(varBase.Class);


        return true;
    }





    private bool ExecuteMember(Member member)
    {
        this.ExecuteFieldArray(member.Field);


        this.ExecuteMethodArray(member.Method);




        return true;
    }




    private bool ExecuteFieldArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Field field;

            field = (Field)array.Get(i);




            this.ExecuteField(field);




            i = i + 1;
        }



        return true;
    }






    private bool ExecuteField(Field field)
    {
        this.ExecuteClass(field.Class);


        this.ExecuteAccess(field.Access);


        this.ExecuteName(field.Name);



        return true;
    }






    private bool ExecuteMethodArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Method method;

            method = (Method)array.Get(i);




            this.ExecuteMethod(method);




            i = i + 1;
        }



        return true;
    }





    private bool ExecuteMethod(Method method)
    {
        this.ExecuteClass(method.Class);


        this.ExecuteAccess(method.Access);


        this.ExecuteName(method.Name);


        this.ExecuteVarArray(method.Param);



        return true;
    }








    private bool ExecuteVarArray(ListArray array)
    {
        int count;

        count = array.Count;




        this.ExecuteCount(count);





        int i;

        i = 0;


        while (i < count)
        {
            Var varVar;

            varVar = (Var)array.Get(i);




            this.ExecuteVar(varVar);




            i = i + 1;
        }



        return true;
    }






    private bool ExecuteVar(Var varVar)
    {
        this.ExecuteClass(varVar.Class);


        this.ExecuteName(varVar.Name);



        return true;
    }







    private bool ExecuteClass(int varClass)
    {
        this.ExecuteSInt32Int(varClass);




        return true;
    }




    private bool ExecuteAccess(int access)
    {
        this.ExecuteSInt32Byte(access);




        return true;
    }




    private bool ExecuteName(string name)
    {
        this.ExecuteString(name);




        return true;
    }





    private bool ExecuteString(string o)
    {
        InfraConvert convert;

        convert = InfraConvert.This;




        int count;

        count = o.Length;




        this.ExecuteCount(count);




        char oc;



        byte ob;




        int i;

        i = 0;

        while (i < count)
        {
            oc = o[i];


            ob = convert.CharByte(oc);



            this.ExecuteByte(ob);




            i = i + 1;
        }



        return true;
    }





    private bool ExecuteSize(int size)
    {
        this.ExecuteSInt32Int(size);




        return true;
    }




    private bool ExecuteCount(int count)
    {
        this.ExecuteSInt32Int(count);




        return true;
    }




    private bool ExecuteSInt32Byte(int a)
    {
        InfraConvert convert;

        convert = InfraConvert.This;


        ulong k;

        k = convert.ULong(a);


        
        byte o;

        o = convert.Byte(k);



        this.ExecuteByte(o);




        return true;
    }






    private bool ExecuteSInt32Int(int a)
    {
        InfraConvert convert;

        convert = InfraConvert.This;


        ulong k;

        k = convert.ULong(a);



        this.ExecuteInt(k);




        return true;
    }

    




    private bool ExecuteInt(ulong o)
    {
        InfraConstant constant;

        constant = InfraConstant.This;



        InfraConvert convert;

        convert = InfraConvert.This;




        int uu;

        uu = constant.ByteBitCount;



        int uv;

        uv = constant.IntByteCount;




        int shiftCount;




        byte ob;



        ulong k;
        



        int count;

        count = uv;




        int i;

        i = 0;


        while (i < count)
        {
            shiftCount = i * uu;



            k = o >> shiftCount;



            ob = convert.Byte(k);




            this.ExecuteByte(ob);
            



            i = i + 1;
        }



        return true;
    }







    private bool ExecuteByte(byte ob)
    {
        this.ByteOp.Execute(ob);




        return true;
    }







    public int Index { get; set; }








    private ByteOp ByteOp { get; set; }
}