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