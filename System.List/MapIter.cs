namespace System.List;





public struct MapIter : IIter
{
    private ListIter ListIter;





    internal bool Init(ListIter listIter)
    {
        this.ListIter = listIter;



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
            return this.ListIter.Value;
        }


        set
        {
        }
    }




    public object Key
    {
        get
        {
            Pair pair;
            
            
            pair = (Pair)this.Value;




            object key;


            key = pair.Key;




            object ret;


            ret = key;


            return ret;
        }

        set
        {
        }
    }
}