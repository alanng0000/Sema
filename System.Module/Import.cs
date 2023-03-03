namespace System.Module;




public class Import : InfraObject
{
    public Ref Module { get; set; }


    public ClassIndex Class { get; set; }
}