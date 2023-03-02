namespace System.Event;




public class Handle : InfraObject
{
    public virtual bool Execute(object arg)
    {
        return true;
    }
}