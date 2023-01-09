namespace System.Compose;




public class Event : InfraObject
{
    private Map Handles { get; set; }




    public override bool Init()
    {
        base.Init();
        



        IdCompare compare;
        
        
        compare = new IdCompare();


        compare.Init();





        this.Handles = new Map();


        this.Handles.Compare = compare;


        this.Handles.Init();



        return true;
    }

    




    public virtual bool AddHandle(EventHandle handle)
    {
        Pair pair;


        pair = new Pair();


        pair.Key = handle.Intent;


        pair.Value = handle;



        this.Handles.Add(pair);


        return true;
    }




    public virtual bool RemoveHandle(EventHandle handle)
    {
        EventHandleIntent intent;

        
        intent = handle.Intent;



        this.Handles.Remove(intent);



        return true;
    }





    public virtual bool Trigger(object arg)
    {
        MapIter iter;


        iter = this.Handles.Iter();


        while (iter.Next())
        {
            Pair pair;


            pair = (Pair)iter.Value;



            EventHandle handle;


            handle = (EventHandle)pair.Value;



            handle.Execute(arg);
        }



        return true;
    }
}