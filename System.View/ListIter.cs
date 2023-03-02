namespace System.View;



public struct ListIter : InfraIIter
{
    internal MapIter Iter;



    public bool Init()
    {
        return true;
    }




    public bool Next()
    {
        return this.Iter.Next();
    }




    public object Key
    {
        get
        {
            return this.Iter.Key;
        }

        set
        {
        }
    }





    public object Value
    {
        get
        {
            
            return this.Iter.Value;
        }

        set
        {
        }
    }
}
