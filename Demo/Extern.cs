namespace Demo;





static class Extern
{
    const string Dll = "Infra.dll";



    const string FormDll = "Infra.Form.Windows.dll";





    [DllImport(Dll)]
    public static extern ulong New(ulong size);




    [DllImport(Dll)]
    public static extern ulong Delete(ulong o);





    [DllImport(Dll)]
    public static extern ulong String_New();




    [DllImport(Dll)]
    public static extern ulong String_Init(ulong o);





    [DllImport(Dll)]
    public static extern ulong String_GetData(ulong o);



    [DllImport(Dll)]
    public static extern ulong String_SetData(ulong o, ulong value);




    [DllImport(Dll)]
    public static extern ulong String_GetLength(ulong o);



    [DllImport(Dll)]
    public static extern ulong String_SetLength(ulong o, ulong value);




    [DllImport(Dll)]
    public static extern ulong String_Final(ulong o);




    [DllImport(Dll)]
    public static extern ulong String_Delete(ulong o);







    [DllImport(Dll)]
    public static extern ulong Console_New();




    [DllImport(Dll)]
    public static extern ulong Console_Init(ulong o);




    [DllImport(Dll)]
    public static extern ulong Console_Write(ulong o, ulong text);





    [DllImport(Dll)]
    public static extern ulong Console_Final(ulong o);




    [DllImport(Dll)]
    public static extern ulong Console_Delete(ulong o);






    [DllImport(FormDll)]
    public static extern ulong Frame_New();




    [DllImport(FormDll)]
    public static extern ulong Frame_Init(ulong o);





    [DllImport(FormDll)]
    public static extern ulong Frame_Execute(ulong o);





    [DllImport(FormDll)]
    public static extern ulong Frame_Final(ulong o);




    [DllImport(FormDll)]
    public static extern ulong Frame_Delete(ulong o);
}