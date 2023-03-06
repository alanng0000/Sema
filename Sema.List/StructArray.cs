namespace Sema.List;




public class StructArray<TItem> : List where TItem : struct
{
    private TItem[] Value { get; set; }




    public override bool Init()
    {
        this.Value = new TItem[this.Count];



        return true;
    }





    public override int Count
    {
        get; set;
    }






    public override object Add(object item)
    {
        return null;
    }






    public override object Insert(object key, object item)
    {
        return null;
    }







    public override bool Remove(object key)
    {
        return false;
    }







    public override bool Clear()
    {
        return false;
    }







    public override bool Contain(object key)
    {
        int? u;


        u = this.Index(key);



        if (!u.HasValue)
        {
            return false;
        }




        int index;


        index = u.Value;



        return this.Contain(index);
    }






    public virtual bool Contain(int index)
    {
        if (!this.CheckIndex(index))
        {
            return false;
        }



        return true;
    }






    public override object Get(object key)
    {
        int? u;


        u = this.Index(key);



        if (!u.HasValue)
        {
            return null;
        }




        int index;


        index = u.Value;



        return this.Get(index);
    }






    public virtual TItem Get(int index)
    {
        if (!this.CheckIndex(index))
        {
            return default(TItem);
        }



        return this.Value[index];
    }






    public override bool Set(object key, object value)
    {
        int? u;


        u = this.Index(key);



        if (!u.HasValue)
        {
            return false;
        }




        int index;


        index = u.Value;



        return this.Set(index, value);
    }






    public virtual bool Set(int index, TItem value)
    {
        if (!this.CheckIndex(index))
        {
            return false;
        }



        this.Value[index] = value;




        return true;
    }









    public new StructArrayIter<TItem> Iter()
    {
        StructArrayIter<TItem> iter;



        iter = new StructArrayIter<TItem>();



        iter.Array = this;



        iter.Init();





        StructArrayIter<TItem> ret;


        ret = iter;


        return ret;
    }








    public override IIter IIter()
    {
        return this.Iter();
    }










    private int? Index(object key)
    {
        if (!(key is int))
        {
            return null;
        }



        int t;

        t = (int)key;



        int ret;

        ret = t;

        return ret;
    }






    private bool CheckIndex(int index)
    {
        return !(index < 0) & (index < this.Count);
    }
}