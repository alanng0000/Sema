namespace System.Infra;



public class RangeInfra : Object
{
    public static RangeInfra This { get; } = CreateGlobal();




    private static RangeInfra CreateGlobal()
    {
        RangeInfra global;

        global = new RangeInfra();

        global.Init();


        return global;
    }







    public override bool Init()
    {
        base.Init();
        



        this.NullInt = -1;





        this.NullVar = new Range();



        this.NullVar.Init();



        this.NullVar.Start = this.NullInt;



        this.NullVar.End = this.NullInt;




        return true;
    }





    public Range Range(int start, int end)
    {
        Range range;

        range = new Range();

        range.Init();

        range.Start = start;

        range.End = end;


        Range ret;

        ret = range;


        return ret;
    }





    public int Count(Range range)
    {
        return range.End - range.Start;
    }





    public bool NullRange(Range range)
    {
        return range.Start == this.Null.Start;
    }






    public Range Null
    {
        get
        {
            return this.NullVar;
        }
    }





    private Range NullVar;
    




    private int NullInt { get; set; }
}