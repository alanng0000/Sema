namespace System.Module;





public class Method : InfraObject
{
    public ClassIndex Class { get; set; }



    public Access Access { get; set; }



    public string Name { get; set; }



    public Array Param { get; set; }
}