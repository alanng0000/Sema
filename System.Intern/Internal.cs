namespace System.Intern;






public class Intern : InfraObject
{
    public static Intern This { get; } = CreateGlobal();




    private static Intern CreateGlobal()
    {
        Intern global;

        global = new Intern();

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