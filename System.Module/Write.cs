namespace System.Module;




public class Write : InfraObject
{
    public Module Module { get; set; }




    
    public InfraData Data { get; set; }




    public bool Execute()
    {
        this.Data = null;






        CountByteOp countOp;

        countOp = new CountByteOp();

        countOp.Write = this;

        countOp.Init();



        this.ByteOp = countOp;




        
        this.Index = 0;



        this.ExecuteRefer(this.Module);





        ulong referSize;

        referSize = this.Index;




        
        this.ExecuteState(this.Module);





        ulong uu;

        uu = this.Index;




        ulong stateSize;
        
        stateSize = uu - referSize;






        InfraConstant constant;

        constant = InfraConstant.This;



        InfraConvert convert;

        convert = InfraConvert.This;




        int ua;

        ua = constant.IntByteCount;


        ulong uh;

        uh = convert.ULong(ua);





        ulong totalSize;

        totalSize = uu + 2 * uh;
        




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




        this.ExecuteInt(referSize);



        this.ExecuteInt(stateSize);




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



            string name;

            name = varClass.Name;



            this.ExecuteString(name);




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



            this.ExecuteModuleRef(import.Module);



            this.ExecuteClassIndex(import.Class);




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




            this.ExecuteClassIndex(export.Class);




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




            this.ExecuteClassIndex(varBase.Class);




            i = i + 1;
        }



        return true;
    }








    private bool ExecuteImport(Import import)
    {
        this.ExecuteModuleRef(import.Module);


        this.ExecuteClassIndex(import.Class);


        return true;
    }





    private bool ExecuteExport(Export export)
    {
        this.ExecuteClassIndex(export.Class);


        return true;
    }






    private bool ExecuteClassIndex(ClassIndex index)
    {
        InfraConvert convert;

        convert = InfraConvert.This;


        ulong k;

        k = convert.ULong(index.Value);



        this.ExecuteInt(k);




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





    private bool ExecuteCount(int count)
    {
        InfraConvert convert;

        convert = InfraConvert.This;


        ulong k;

        k = convert.ULong(count);



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







    public ulong Index { get; set; }








    private ByteOp ByteOp { get; set; }
}