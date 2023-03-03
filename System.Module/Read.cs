namespace System.Module;






public class Read : InfraObject
{
    public InfraData Data { get; set; }





    public ulong Index { get; set; }






    public Module Module { get; set; }




    


    public bool Execute()
    {
        this.Module = null;












        return true;
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
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}