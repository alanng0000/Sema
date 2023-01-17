namespace System.Text;






public class CharList : GenericList<char>
{
    public new CharIter Iter()
    {
        CharIter iter;

        iter = new CharIter();

        iter.Iter = base.Iter();

        iter.Init();


        return iter;
    }
}