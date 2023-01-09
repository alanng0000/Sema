namespace System.Compose;




public class EventHandle : InfraObject
{
    public EventHandleIntent Intent { get; set; }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}