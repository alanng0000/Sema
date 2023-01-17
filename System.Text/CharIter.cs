namespace System.Text;





public struct CharIter
{
    internal GenericIter<char> Iter;




    public bool Init()
    {
        return true;
    }





    public bool Next()
    {
        return this.Iter.Next();
    }




    public char Value
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