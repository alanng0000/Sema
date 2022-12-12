namespace System.Infra;



public class RangeInfra : Object
{
    public override bool Init()
    {
        base.Init();
        



        this.NullInt = -1;





        this.NullVar = new Range();



        this.NullVar.Start = this.NullInt;



        this.NullVar.End = this.NullInt;




        return true;
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