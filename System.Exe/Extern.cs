namespace System.Exe;





static class Extern
{
    const string Dll = "Infra.Form.Windows.dll";




    [DllImport(Dll)]
    public static extern ulong Infra_Form_Init();



    [DllImport(Dll)]
    public static extern ulong Infra_Form_Final();
}