namespace System.Internal;




public static class InfraExtern
{
    const string InfraDll = "Infra.dll";


    const string InfraFormInfraDll = "Infra.Form.Infra.dll";



    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_New();


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Init(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Final(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Delete(ulong o);



    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_GetWidth(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_SetWidth(ulong o, ulong value);



    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_GetHeight(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_SetHeight(ulong o, ulong value);
}