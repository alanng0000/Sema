namespace System.Event;




public class GenericEvent<T> : InfraObject where T : struct
{
    public HandleMap Handle { get; set; }







    public virtual bool Trigger(T arg)
    {
        MapIter iter;


        iter = this.Handle.Iter();


        while (iter.Next())
        {
            Pair pair;


            pair = (Pair)iter.Value;



            GenericHandle<T> handle;


            handle = (GenericHandle<T>)pair.Value;



            handle.Execute(arg);
        }



        return true;
    }
}