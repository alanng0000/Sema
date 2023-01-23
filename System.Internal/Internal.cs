namespace System.Internal;






public class Internal : InfraObject
{
    public static Internal This { get; } = CreateGlobal();




    private static Internal CreateGlobal()
    {
        Internal global;

        global = new Internal();

        global.Init();


        return global;
    }




    public ulong MethodPointer(SystemDelegate d)
    {
        IntPtr pp;

        pp = Marshal.GetFunctionPointerForDelegate(d);



        long ppu;

        ppu = pp.ToInt64();



        ulong o;

        o = (ulong)ppu;



        ulong ret;

        ret = o;

        return ret;
    }




    public bool CopyString(string s, ulong pointer)
    {
        unsafe
        {
            byte* p;

            p = (byte*)pointer;



            char oc;

            byte ob;



            int count;

            count = s.Length;



            int i;

            i = 0;



            while (i < count)
            {
                oc = s[i];


                ob = (byte)oc;


                p[i] = ob;



                i = i + 1;
            }
        }


        return true;
    }
}