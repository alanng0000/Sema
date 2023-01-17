namespace System.Text;




public class Convert : InfraObject
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;

        global = new Convert();

        global.Init();


        return global;
    }





    public ReadOnlySpanChar ReadOnlySpanChar(CharSpan charSpan)
    {
        RangeInfra infra;

        infra = RangeInfra.This;




        ReadOnlySpanChar u;


        u = new ReadOnlySpanChar();





        int start;

        start = charSpan.Range.Start;



        int count;


        count = infra.Count(charSpan.Range);



        char[] a;

        a = charSpan.Array;



        string s;


        s = charSpan.String;




        bool b;

        b = false;



        if (!b & !this.Null(a))
        {
            u = new ReadOnlySpanChar(a, start, count);


            b = true;
        }



        if (!b & !this.Null(s))
        {
            u = s.AsSpan(start, count);


            b = true;
        }




        return u;
    }




    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}