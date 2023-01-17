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




    public bool Add(Line[] item, InfraRange range)
    {
        return this.List.Add(item, range);
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