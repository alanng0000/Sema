namespace System.View;



public struct ListIter : InfraIIter
{
    internal InfraListIter Iter;



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
            ListItem o;


            o = (ListItem)this.Iter.Value;




            ComposeObject item;
            

            item = o.Object;




            ComposeObject ret;


            ret = item;


            return ret;
        }

        set
        {
        }
    }
}
