namespace System.Module;




public class Module : InfraObject
{
    public ModuleName Name { get; set; }





    public ModuleVer Ver { get; set; }





    public ImportList Import { get; set; }





    public ExportList Export { get; set; }





    public Entry Entry { get; set; }
}