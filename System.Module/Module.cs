namespace System.Module;




public class Module : InfraObject
{
    public Ref Ref { get; set; }



    public Array Class { get; set; }



    public Array Import { get; set; }



    public Array Export { get; set; }
}