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







    public bool DrawDrawText(ulong internDraw, string textString, char[] textArray, InfraRange range, 
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




        ulong u;

        u = 0;



        bool b;

        b = false;

        

        if (!b & !this.Null(textString))
        {
            unsafe
            {
                fixed (char* pointer = textString)
                {
                    u = this.DrawDrawTextPointer(internDraw, pointer, index, length,
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
                    u = this.DrawDrawTextPointer(internDraw, pointer, index, length,
                        destLeft, destUp, destWidth, destHeight, font, brush
                    );
                }
            }


            b = true;
        }
        




        bool o;

        o = false;


        if (b)
        {
            o = this.Bool(u);
        }        



        bool ret;

        ret = o;
        
        return ret;
    }




    public bool CheckCharSpan(string textString, char[] textArray, InfraRange range)
    {
        bool ret;

        ret = false;



        bool b;

        b = false;



        int dataCount;

        dataCount = 0;




        if (!b & !this.Null(textString))
        {
            dataCount = textString.Length;


            b = true;
        }



        if (!b & !this.Null(textArray))
        {
            dataCount = textArray.Length;


            b = true;
        }



        if (b)
        {
            ret = this.CheckCharSpanRange(dataCount, range);
        }



        return ret;
    }





    private bool CheckCharSpanRange(int count, InfraRange range)
    {
        if (range.Start < 0)
        {
            return false;
        }


        if (!(range.Start < count))
        {
            return false;
        }


        if (count < range.End)
        {
            return false;
        }


        if (range.End < range.Start)
        {
            return false;
        }


        return true;
    }





    private unsafe ulong DrawDrawTextPointer(ulong internDraw, char* pointer, int index, ulong length, 
        long destLeft, long destUp, ulong destWidth, ulong destHeight, ulong font, ulong brush)
    {
        char* pu;

        pu = pointer + index;



        ulong textO;

        textO = (ulong)pu;


        
        ulong ret;

        ret = DrawExtern.Draw_Draw_Text(internDraw, textO, length, destLeft, destUp, destWidth, destHeight, font, brush);


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