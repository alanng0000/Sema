namespace System.Module;




public class Load : InfraObject
{
    public Ref Module { get; set; }





    public InfraData Data { get; set; }






    public bool Execute()
    {
        this.Data = null;





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




        Convert convert;

        convert = Convert.This;




        ulong referSize;


        referSize = convert.ByteListULong(u, 0);




        

        byte[] d;


        d = new byte[referSize];




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