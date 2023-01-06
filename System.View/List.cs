namespace System.View;



public class List : ComposeObject
{
    public override bool Init()
    {
        base.Init();




        this.ObjectList = new InfraList();


        this.ObjectList.Init();




        this.EventHandle = new ListEventHandle();


        this.EventHandle.Init();


        this.EventHandle.List = this;



        return true;
    }




    protected virtual InfraList ObjectList { get; set; }




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
            return this.ObjectList.Count;
        }
        set
        {
        }
    }



    public virtual bool ItemChange(ComposeObject o)
    {
        ListItem u;


        u = (ListItem)o;





        ComposeObject item;


        item = u.Object;




        object key;


        key = u.Key;

        


        ListChange change;
        change = new ListChange();
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





        ListItem o;


        o = new ListItem();


        o.Init();


        o.Object = item;





        object key;


        key = this.ObjectList.Add(o);




        o.Key = key;





        o.Changed.AddHandle(this.EventHandle);





        ListChange change;
        change = new ListChange();
        change.List = this;
        change.Kind = ListChangeKinds.This.Add;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);



        return true;
    }






    public virtual bool Clear()
    {
        InfraListIter iter;


        iter = this.ObjectList.Iter();




        while (iter.Next())
        {
            ListItem o;
            
            o = (ListItem)iter.Value;


            o.Changed.RemoveHandle(this.EventHandle);
        }




        this.ObjectList.Clear();





        ListChange change;

        change = new ListChange();
        
        change.List = this;
        
        change.Kind = ListChangeKinds.This.Clear;



        this.Trigger(change);


        return true;
    }


    


    public virtual ListIter Iter()
    {
        InfraListIter o;


        o = this.ObjectList.Iter();




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







    public virtual bool Insert(object key, ComposeObject item)
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


        o.Key = key;




        this.ObjectList.Insert(key, o);




        o.Changed.AddHandle(this.EventHandle);




        ListChange change;
        change = new ListChange();
        change.List = this;
        change.Kind = ListChangeKinds.This.Insert;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);


        return true;
    }





    public virtual bool Remove(object key)
    {
        if (!this.Valid(key))
        {
            return true;
        }



        ListItem o;


        o = (ListItem)this.ObjectList.Get(key);

        

        this.ObjectList.Remove(key);



        o.Changed.RemoveHandle(this.EventHandle);





        ComposeObject item;

        item = o.Object;





        ListChange change;
        change = new ListChange();
        change.List = this;
        change.Kind = ListChangeKinds.This.Remove;
        change.Key = key;
        change.Item = item;

        this.Trigger(change);


        return true;
    }




    public virtual bool Valid(object key)
    {
        return this.ObjectList.Contain(key);
    }





    public virtual ComposeObject Get(object key)
    {
        if (!this.Valid(key))
        {
            return null;
        }




        ListItem o;


        o = (ListItem)this.ObjectList.Get(key);




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


        oa = (ListItem)this.ObjectList.Get(key);





        oa.Changed.RemoveHandle(this.EventHandle);






        ListItem ob;


        ob = new ListItem();


        ob.Init();


        ob.Key = key;


        ob.Object = value;





        this.ObjectList.Set(key, ob);




        ob.Changed.AddHandle(this.EventHandle);






        ListChange change;
        change = new ListChange();
        change.List = this;
        change.Kind = ListChangeKinds.This.Set;
        change.Key = key;
        change.Item = value;


        this.Trigger(change);

        
        return true;
    }







    private bool Null(object o)
    {
        return o == null;
    }
}