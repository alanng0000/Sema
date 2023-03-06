namespace Sema.Mode;




public class Load : Object
{
    public Ref Module { get; set; }





    public InfraData Data { get; set; }




    public bool Refer { get; set; }



    public bool State { get; set; }





    public bool Execute()
    {
        this.Data = null;



        if (!(this.Refer | this.State))
        {
            return false;
        }

        



        string dataPath;

        dataPath = this.DataPath();




        InfraConstant constant;

        constant = InfraConstant.This;



        int ou;

        ou = constant.IntByteCount;




        int oo;

        oo = 2 * ou;




        byte[] u;

        u = new byte[oo];





        FileStream fileStream;


        fileStream = new FileStream(dataPath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);




        int f;



        f = fileStream.Read(u, 0, u.Length);



        if (f < u.Length)
        {
            return false;
        }






        int referSize;


        referSize = this.Size(u, 0);




        int stateSize;


        stateSize = this.Size(u, ou);




        int totalSize;

        totalSize = 0;


        if (this.Refer)
        {
            totalSize = totalSize + referSize;
        }


        if (this.State)
        {
            totalSize = totalSize + stateSize;
        }




        long uu;


        uu = 0;


        if (!this.Refer)
        {
            uu = referSize;
        }

        


        

        byte[] d;


        d = new byte[totalSize];



        
        long uua;


        uua = fileStream.Position;



        uua = uua + uu;




        fileStream.Position = uua;




        f = fileStream.Read(d, 0, d.Length);

        

        if (f < d.Length)
        {
            return false;
        }
        



        fileStream.Dispose();






        InfraData data;


        data = new InfraData();


        data.Init();


        data.Value = d;



        this.Data = data;


        return true;
    }






    private int Size(byte[] array, int start)
    {
        Convert convert;

        convert = Convert.This;



        ulong u;

        u = convert.ByteListULong(array, start);



        InfraConvert infraConvert;

        infraConvert = InfraConvert.This;



        int k;

        k = infraConvert.SInt32(u);



        return k;
    }





    private string DataPath()
    {
        Path path;


        path = Path.This;




        
        string s;


        s = path.Module(this.Module);




        string su;


        su = path.ModuleDataName;




        s = SystemPath.Combine(s, su);




        string ret;

        ret = s;


        return ret;
    }
}