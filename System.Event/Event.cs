namespace System.Compose;




public class Event : InfraObject
{
    private Map Handle { get; set; }




    public override bool Init()
    {
        base.Init();
        









        this.Handle = new Map();


        this.Handle.Compare = compare;


        this.Handle.Init();



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