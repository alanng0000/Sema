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
        SystemIntPtr u;

        u = Marshal.GetFunctionPointerForDelegate(d);



        ulong o;

        o = this.ULong(u);



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





    public ulong DrawDrawText(ulong o, string textString, char[] textArray, InfraRange range, 
        long destLeft, long destUp, ulong destWidth, ulong destHeight, ulong font, ulong brush)
    {
        int index;

        index = range.Start;




        RangeInfra infra;

        infra = RangeInfra.This;




        InfraConvert convert;

        convert = InfraConvert.This;




        int count;

        count = infra.Count(range);




        ulong length;

        length = convert.ULong(count);




        ulong ret;

        ret = 0;



        bool b;

        b = false;

        

        if (!b & !this.Null(textString))
        {
            unsafe
            {
                fixed (char* pointer = textString)
                {
                    ret = this.DrawDrawTextPointer(o, pointer, index, length,
                        destLeft, destUp, destWidth, destHeight, font, brush
                    );
                }
            }


            b = true;
        }

        


        if (!b & !this.Null(textArray))
        {
            unsafe
            {
                fixed (char* pointer = textArray)
                {
                    ret = this.DrawDrawTextPointer(o, pointer, index, length,
                        destLeft, destUp, destWidth, destHeight, font, brush
                    );
                }
            }


            b = true;
        }
        


        
        return ret;
    }




    private unsafe ulong DrawDrawTextPointer(ulong o, char* pointer, int index, ulong length, 
        long destLeft, long destUp, ulong destWidth, ulong destHeight, ulong font, ulong brush)
    {
        char* pu;

        pu = &pointer[index];



        ulong textO;

        textO = (ulong)pu;


        
        ulong ret;

        ret = DrawExtern.Draw_Draw_Text(o, textO, length, destLeft, destUp, destWidth, destHeight, font, brush);


        return ret;
    }





    public bool ReadStream(Stream stream, ulong buffer, ulong size)
    {
        SpanByte span;

        span = this.ByteSpan(buffer, size);



        stream.Read(span);



        return true;
    }
    




    private SpanByte ByteSpan(ulong pointer, ulong count)
    {
        InfraConvert convert;

        convert = InfraConvert.This;



        int u;

        u = convert.SInt32(count);




        SpanByte span;




        unsafe
        {
            void* ptr;

            ptr = (void*)pointer;



            span = new SpanByte(ptr, u);
        }



        return span;
    }





    public bool Bool(ulong internBool)
    {
        if (internBool == 0)
        {
            return false;
        }


        if (internBool == 1)
        {
            return true;
        }


        return true;
    }




    public ulong InternBool(bool b)
    {
        if (b)
        {
            return 1;
        }


        return 0;
    }





    private ulong ULong(SystemIntPtr u)
    {
        long uu;

        uu = u.ToInt64();



        ulong o;

        o = (ulong)uu;



        return o;
    }




    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}