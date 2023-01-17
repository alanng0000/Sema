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






    public Line Get(int index)
    {
        return this.List.Get(index);
    }




    public bool Set(int index, Line item)
    {
        return this.List.Set(index, item);
    }






    public bool Add(LineList item, InfraRange range)
    {
        return this.List.Add(item.List.Data, range);
    }





    public bool Insert(int index, LineList item, InfraRange range)
    {
        return this.List.Insert(index, item.List.Data, range);
    }




    public bool Remove(InfraRange range)
    {
        return this.List.Remove(range);
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