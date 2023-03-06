namespace Sema.Text;




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







    public bool Insert(InfraRange range)
    {
        return this.List.Insert(range);
    }




    public bool Remove(InfraRange range)
    {
        return this.List.Remove(range);
    }




    public bool Set(int index, Line[] item, InfraRange range)
    {
        return this.List.Set(index, item, range);
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