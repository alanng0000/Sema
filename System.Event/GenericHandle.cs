namespace System.Event;




public class GenericHandle<T> : InfraObject where T : struct
{
    public HandleIntent Intent { get; set; }





    public virtual bool Execute(T arg)
    {
        return true;
    }
}