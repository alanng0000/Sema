namespace System.Module;




public class Module : InfraObject
{
    public Ref Ref { get; set; }



    public Array Class { get; set; }



    public Array Import { get; set; }



    public Array Export { get; set; }



    public Array Base { get; set; }



    public Array Member { get; set; }

    
    
    public Array State { get; set; }
}