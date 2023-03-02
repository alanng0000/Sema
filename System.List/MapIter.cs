namespace System.List;





public struct MapIter : IIter
{
    internal ListIter ListIter;





    public bool Init()
    {
        return true;
    }





    public bool Next()
    {
        return this.ListIter.Next();
    }





    public object Value
    {
        get
        {
            return this.Pair().Value;
        }


        set
        {
        }
    }




    public object Key
    {
        get
        {
            return this.Pair().Key;
        }

        set
        {
        }
    }




    private Pair Pair()
    {
        Pair a;
            
            
        a = (Pair)this.ListIter.Value;



        return a;
    }
}