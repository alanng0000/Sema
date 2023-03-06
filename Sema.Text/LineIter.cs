namespace Sema.Text;





public struct LineIter
{
    internal GenericIter<Line> Iter;




    public bool Init()
    {
        return true;
    }





    public bool Next()
    {
        return this.Iter.Next();
    }




    public Line Value
    {
        get
        {
            return this.Iter.Value;
        }

        set
        {
        }
    }



    public int Key
    {
        get
        {
            return this.Iter.Key;
        }

        set
        {
        }
    }
}