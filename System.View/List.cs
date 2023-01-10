namespace System.View;



public class List : ComposeObject
{
    public override bool Init()
    {
        base.Init();




        IntentCompare compare;


        compare = new IntentCompare();


        compare.Init();




        this.ItemMap = new Map();


        this.ItemMap.Compare = compare;


        this.ItemMap.Init();




        this.EventHandle = new ListEventHandle();


        this.EventHandle.Init();


        this.EventHandle.List = this;




        return true;
    }





    protected virtual Map ItemMap { get; set; }




    protected virtual ListEventHandle EventHandle { get; set; }




    protected virtual bool Trigger(ListChange change)
    {
        this.Changed.Trigger(change);


        return true;
    }



    public virtual int Count
    {
        get
        {
            return this.ItemMap.Count;
        }
        set
        {
        }
    }




    public virtual bool ItemChange(ComposeObject o)
    {
        ListItem u;


        u = null;





        ComposeObject item;


        item = u.Object;




        object key;


        key = u.Key;

        


        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Item;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);


        return true;
    }




    public virtual bool Add(ComposeObject item)
    {
        if (this.Null(item))
        {
            return true;
        }






        Pair pair;


        pair = new Pair();


        pair.Init();


        pair.Key = item.Intent;


        pair.Value = item;





        this.ItemMap.Add(pair);







        item.Changed.Handle.AddHandle(this.EventHandle);





        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Add;
        change.Item = item;


        this.Trigger(change);




        return true;
    }






    public virtual bool Clear()
    {
        MapIter iter;


        iter = this.ItemMap.Iter();




        while (iter.Next())
        {
            Pair pair;
            
            pair = (Pair)iter.Value;



            ComposeObject item;

            item = (ComposeObject)pair.Value;



            item.Changed.Handle.RemoveHandle(this.EventHandle);
        }




        this.ItemMap.Clear();





        ListChange change;

        change = new ListChange();

        change.Init();
        
        change.List = this;
        
        change.Kind = ListChangeKinds.This.Clear;



        this.Trigger(change);


        return true;
    }


    


    public virtual ListIter Iter()
    {
        MapIter o;


        o = this.ItemMap.Iter();




        ListIter iter;


        iter = new ListIter();


        iter.Iter = o;


        iter.Init();




        ListIter ret;


        ret = iter;


        return ret;
    }






    public virtual bool Contain(Intent key)
    {
        return this.Valid(key);
    }







    public virtual bool Insert(Intent key, ComposeObject item)
    {
        if (!this.Valid(key))
        {
            return true;
        }




        if (this.Null(item))
        {
            return true;
        }





        Pair pair;


        pair = new Pair();


        pair.Init();


        pair.Key = item.Intent;


        pair.Value = item;






        this.ItemMap.Insert(key, pair);






        item.Changed.Handle.AddHandle(this.EventHandle);




        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Insert;
        change.Item = item;

        this.Trigger(change);




        return true;
    }





    public virtual bool Remove(ComposeObject item)
    {
        if (!this.Valid(item.Intent))
        {
            return true;
        }




        this.ItemMap.Remove(item.Intent);





        item.Changed.Handle.RemoveHandle(this.EventHandle);






        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Remove;
        change.Item = item;

        this.Trigger(change);


        return true;
    }




    public virtual bool Valid(Intent key)
    {
        return this.ItemMap.Contain(key);
    }





    public virtual ComposeObject Get(Intent key)
    {
        return (ComposeObject)this.ItemMap.Get(key);
    }








    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}