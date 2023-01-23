namespace System.Internal;




public static class InfraExtern
{
    const string InfraDll = "Infra.dll";


    const string InfraFormInfraDll = "Infra.Form.Infra.dll";





    [DllImport(InfraDll)]
    public static extern ulong New(ulong size);



    [DllImport(InfraDll)]
    public static extern ulong Delete(ulong o);




    [DllImport(InfraDll)]
    public static extern ulong Console_New();


    [DllImport(InfraDll)]
    public static extern ulong Console_Delete(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong Console_Init(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong Console_Final(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong Console_Write(ulong o, ulong text);



    [DllImport(InfraDll)]
    public static extern ulong String_New();


    [DllImport(InfraDll)]
    public static extern ulong String_Delete(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong String_Init(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong String_Final(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong String_GetLength(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong String_SetLength(ulong o, ulong value);


    [DllImport(InfraDll)]
    public static extern ulong String_GetData(ulong o);


    [DllImport(InfraDll)]
    public static extern ulong String_SetData(ulong o, ulong value);





    [DllImport(InfraFormInfraDll)]
    public static extern ulong Infra_Form_Init();


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Infra_Form_Final();




    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_New();


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Delete(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Init(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_Final(ulong o);




    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_GetWidth(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_SetWidth(ulong o, ulong value);



    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_GetHeight(ulong o);


    [DllImport(InfraFormInfraDll)]
    public static extern ulong Size_SetHeight(ulong o, ulong value);
}