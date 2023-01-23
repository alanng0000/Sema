namespace System.Internal;




public static class InfraExtern
{
    const string InfraDll = "Infra.dll";


    const string InfraFormInfraDll = "Infra.Form.Infra.dll";


    const string InfraFormDll = "Infra.Form.Windows.dll";




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





    [DllImport(InfraFormDll)]
    public static extern ulong Infra_Form_Init();


    [DllImport(InfraFormDll)]
    public static extern ulong Infra_Form_Final();





    [DllImport(InfraFormDll)]
    public static extern ulong Frame_New();


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Delete(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Init(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Final(ulong o);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetTitle(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_SetTitle(ulong o, ulong value);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetVisible(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_SetVisible(ulong o, ulong value);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetSize(ulong o);



    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetHandle(ulong o);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetControlHandle(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_SetControlHandle(ulong o, ulong value);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetDrawHandle(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_SetDrawHandle(ulong o, ulong value);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_GetDrawHandleArg(ulong o);


    [DllImport(InfraFormDll)]
    public static extern ulong Frame_SetDrawHandleArg(ulong o, ulong value);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Execute(ulong o);




    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Close(ulong o);



    [DllImport(InfraFormDll)]
    public static extern ulong Frame_Update(ulong o);
}