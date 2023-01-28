namespace System.Text;




public class LineList : InfraObject
{
    private GenericList<Line> List;




    public override bool Init()
    {
        base.Init();



        this.List = new GenericList<Line>();

        this.List.Init();



        return true;
    }




    public int Count
    {
        get
        {
            return this.List.Count;
        }
    }




    public Line[] Data
    {
        get
        {
            return this.List.Data;
        }
    }





    public Line Get(int index)
    {
        return this.List.Get(index);
    }




    public bool Set(int index, Line item)
    {
        return this.List.Set(index, item);
    }






    public bool Insert(int index, Line[] item, InfraRange range)
    {
        return this.List.Insert(index, item, range);
    }




    public bool Remove(InfraRange range)
    {
        return this.List.Remove(range);
    }




    public bool Replace(int index, Line[] item, InfraRange range)
    {
        return this.List.Replace(index, item, range);
    }





    public bool SetCount(int value)
    {
        this.List.SetCount(value);



        return true;
    }





    public LineIter Iter()
    {
        LineIter iter;

        iter = new LineIter();

        iter.Iter = this.List.Iter();

        iter.Init();


        return iter;
    }
}