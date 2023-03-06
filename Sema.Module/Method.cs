namespace Sema.Module;





public class Method : InfraObject
{
    public int Class { get; set; }



    public int Access { get; set; }



    public string Name { get; set; }



    public ListArray Param { get; set; }
}