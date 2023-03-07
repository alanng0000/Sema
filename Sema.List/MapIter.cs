namespace Sema.List;





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





    public object Valu
    {
        get
        {
            return this.Pair().Valu;
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
            
            
        a = (Pair)this.ListIter.Valu;



        return a;
    }
}