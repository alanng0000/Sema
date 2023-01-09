namespace System.Compose;




public class GenericEvent<T> : InfraObject where T : struct
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




    public virtual bool AddHandle(GenericEventHandle<T> handle)
    {
        Pair pair;


        pair = new Pair();


        pair.Key = handle.LocalId;


        pair.Value = handle;



        this.Handles.Add(pair);


        return true;
    }




    public virtual bool RemoveHandle(GenericEventHandle<T> handle)
    {
        ulong id;

        
        id = handle.LocalId;



        this.Handles.Remove(id);



        return true;
    }





    public virtual bool Trigger(T arg)
    {
        MapIter iter;


        iter = this.Handles.Iter();


        while (iter.Next())
        {
            Pair pair;


            pair = (Pair)iter.Value;



            GenericEventHandle<T> handle;


            handle = (GenericEventHandle<T>)pair.Value;



            handle.Execute(arg);
        }



        return true;
    }
}