namespace System.Text;




public class Lines : InfraObject
{
    private ListLine Data { get; set; }






    public override bool Init()
    {
        base.Init();



        this.Data = new ListLine(InitialCapacity);



        return true;
    }
    




    public bool Add(Line item)
    {
        this.Data.Add(item);


        return true;
    }

    



    public bool Insert(int index, Line item)
    {
        this.Data.Insert(index, item);


        return true;
    }





    public bool Remove(int index)
    {
        InfraRange range;

        range = new InfraRange();

        range.Start = index;

        range.End = index + 1;
        


        this.RemoveRange(range);


        return true;
    }





    public bool RemoveRange(InfraRange range)
    {
        int count;

        count = this.CountRange(range);



        this.Data.RemoveRange(range.Start, count);



        return true;
    }





    private int CountRange(InfraRange range)
    {
        int count;

        count = range.End - range.Start;


        return count;
    }





    public int Count
    {
        get
        {
            return this.Data.Count;
        }
    }





    public Line Get(int index)
    {
        return this.Data[index];
    }


    



    public bool Set(int index, Line item)
    {
        this.Data[index] = item;


        return true;
    }






    public LineIter Iter()
    {
        LineIter iter;


        iter = new LineIter();


        iter.Enumerator = this.Data.GetEnumerator();


        iter.Init();



        return iter;
    }






    private static int InitialCapacity { get; } = 32;
}