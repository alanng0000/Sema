namespace System.View;



public class List : ComposeObject
{
    public override bool Init()
    {
        base.Init();




        this.ItemList = new InfraList();


        this.ItemList.Init();




        this.EventHandle = new ListEventHandle();


        this.EventHandle.Init();


        this.EventHandle.List = this;



        return true;
    }




    protected virtual InfraList ItemList { get; set; }




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
            return this.ItemList.Count;
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




    public virtual object Add(ComposeObject item)
    {
        if (this.Null(item))
        {
            return true;
        }





        ListItem o;


        o = new ListItem();


        o.Init();


        o.Object = item;





        object key;


        key = this.ItemList.Add(o);




        o.Key = key;





        item.Changed.Handle.AddHandle(this.EventHandle);





        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Add;
        change.Key = key;
        change.Item = item;


        this.Trigger(change);




        return key;
    }






    public virtual bool Clear()
    {
        InfraListIter iter;


        iter = this.ItemList.Iter();




        while (iter.Next())
        {
            ListItem o;
            
            o = (ListItem)iter.Value;



            ComposeObject item;

            item = o.Object;



            item.Changed.Handle.RemoveHandle(this.EventHandle);
        }




        this.ItemList.Clear();





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
        InfraListIter o;


        o = this.ItemList.Iter();




        ListIter iter;


        iter = new ListIter();


        iter.Iter = o;


        iter.Init();




        ListIter ret;


        ret = iter;


        return ret;
    }






    public virtual bool Contain(object key)
    {
        return this.Valid(key);
    }







    public virtual object Insert(object key, ComposeObject item)
    {
        if (!this.Valid(key))
        {
            return true;
        }



        if (this.Null(item))
        {
            return true;
        }





        ListItem o;


        o = new ListItem();


        o.Init();


        o.Object = item;





        object u;


        u = this.ItemList.Insert(key, o);





        o.Key = u;





        item.Changed.Handle.AddHandle(this.EventHandle);




        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Insert;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);




        return u;
    }





    public virtual bool Remove(object key)
    {
        if (!this.Valid(key))
        {
            return true;
        }



        ListItem o;


        o = (ListItem)this.ItemList.Get(key);

        

        this.ItemList.Remove(key);





        ComposeObject item;

        item = o.Object;




        item.Changed.Handle.RemoveHandle(this.EventHandle);






        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Remove;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);


        return true;
    }




    public virtual bool Valid(object key)
    {
        return this.ItemList.Contain(key);
    }





    public virtual ComposeObject Get(object key)
    {
        if (!this.Valid(key))
        {
            return null;
        }




        ListItem o;


        o = (ListItem)this.ItemList.Get(key);




        ComposeObject item;


        item = o.Object;




        ComposeObject ret;


        ret = item;


        return ret;
    }







    public virtual bool Set(object key, ComposeObject value)
    {
        if (!this.Valid(key))
        {
            return true;
        }




        ListItem oa;


        oa = (ListItem)this.ItemList.Get(key);





        oa.Object.Changed.Handle.RemoveHandle(this.EventHandle);







        oa.Object = value;







        oa.Object.Changed.Handle.AddHandle(this.EventHandle);






        ListChange change;
        change = new ListChange();
        change.Init();
        change.List = this;
        change.Kind = ListChangeKinds.This.Set;
        change.Key = key;
        change.Item = value;


        this.Trigger(change);

        
        return true;
    }







    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}