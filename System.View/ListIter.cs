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
            Pair pair;


            pair = (Pair)this.Iter.Value;




            ComposeObject item;
            

            item = (ComposeObject)pair.Value;




            ComposeObject ret;


            ret = item;


            return ret;
        }

        set
        {
        }
    }
}
