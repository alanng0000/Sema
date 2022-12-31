namespace System.Module;




public class Load : InfraObject
{
    public string ModuleName { get; set; }



    public ulong ModuleVer { get; set; }
    



    public InfraData Result { get; set; }



    public bool Execute()
    {
        return true;
    }
}