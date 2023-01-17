namespace System.Text;




public class LineList : GenericList<Line>
{
    public new LineIter Iter()
    {
        LineIter iter;

        iter = new LineIter();

        iter.Iter = base.Iter();

        iter.Init();


        return iter;
    }
}