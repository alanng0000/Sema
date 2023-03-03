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






        Constant constant;

        constant = Constant.This;




        ulong totalSize;

        totalSize = uu + 2 * constant.IntByteCount;
        




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




        this.Int(referSize);



        this.Int(stateSize);




        this.ExecuteRefer(this.Module);


        this.ExecuteState(this.Module);





        return true;
    }






    private bool ExecuteRefer(Module module)
    {
        this.ExecuteClassArray(module.Class);



        this.ExecuteImportArray(module.Import);



        this.ExecuteExportArray(module.Export);



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
        this.Int(varInt.Value);


        return true;
    }




    private bool ExecuteModuleVer(Ver ver)
    {
        this.Int(ver.Value);


        return true;
    }





    private bool ExecuteClassArray(Array varClass)
    {
        Convert convert;


        convert = Convert.This;




        ulong k;

        k = convert.ULong(varClass.Count);




        ulong count;

        count = k;




        this.Int(count);



        int uu;



        ulong i;

        i = 0;


        while (i < count)
        {
            uu = convert.SInt32(i);



            string s;

            s = (string)varClass.Get(uu);




            this.String(s);




            i = i + 1;
        }



        return true;
    }







    private bool ExecuteImportArray(Array import)
    {
        Convert convert;


        convert = Convert.This;




        ulong k;

        k = convert.ULong(import.Count);




        ulong count;

        count = k;




        this.Int(count);



        int uu;



        ulong i;

        i = 0;


        while (i < count)
        {
            uu = convert.SInt32(i);



            Import a;

            a = (Import)import.Get(uu);




            this.ExecuteImport(a);




            i = i + 1;
        }



        return true;
    }






    private bool ExecuteExportArray(Array export)
    {
        Convert convert;


        convert = Convert.This;




        ulong k;

        k = convert.ULong(export.Count);




        ulong count;

        count = k;




        this.Int(count);



        int uu;



        ulong i;

        i = 0;


        while (i < count)
        {
            uu = convert.SInt32(i);



            Export a;

            a = (Export)export.Get(uu);




            this.ExecuteExport(a);




            i = i + 1;
        }



        return true;
    }








    private bool ExecuteImport(Import import)
    {
        this.ExecuteModuleRefer(import.Refer);


        this.ExecuteClassIndex(import.Index);


        return true;
    }





    private bool ExecuteExport(Export export)
    {
        this.ExecuteClassIndex(export.Index);


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