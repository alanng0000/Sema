namespace System.Event;




public class Handle : InfraObject
{
    public HandleIntent Intent { get; set; }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}