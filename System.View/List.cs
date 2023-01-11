namespace System.View;



public class List : CompObject
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






        this.ListChange = new ListChange();


        this.ListChange.Init();


        this.ListChange.List = this;



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




    public virtual bool ItemChange(CompObject item)
    {
        this.TriggerList(ListChangeKindList.This.Item, item);



        return true;
    }





    public virtual bool Add(CompObject item)
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







        this.TriggerList(ListChangeKindList.This.Add, item);





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



            CompObject item;

            item = (CompObject)pair.Value;



            item.Changed.Handle.RemoveHandle(this.EventHandle);
        }




        this.ItemMap.Clear();






        this.TriggerList(ListChangeKindList.This.Clear, null);




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







    public virtual bool Insert(Intent key, CompObject item)
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





        this.TriggerList(ListChangeKindList.This.Insert, item);





        return true;
    }





    public virtual bool Remove(Intent intent)
    {
        CompObject item;


        item = this.Get(intent);
        



        if (this.Null(item))
        {
            return true;
        }




        this.ItemMap.Remove(item.Intent);





        item.Changed.Handle.RemoveHandle(this.EventHandle);





        this.TriggerList(ListChangeKindList.This.Remove, item);




        return true;
    }





    private bool TriggerList(ListChangeKind kind, CompObject item)
    {
        this.ListChange.Kind = kind;



        this.ListChange.Item = item;




        this.Trigger(this.ListChange);



        return true;
    }





    private ListChange ListChange { get; set; }






    public virtual bool Valid(Intent key)
    {
        return !this.Null(this.Get(key));
    }





    public virtual CompObject Get(Intent key)
    {
        return (CompObject)this.ItemMap.Get(key);
    }








    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}