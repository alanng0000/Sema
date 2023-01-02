namespace System.Infra;




public class Compare : Object
{
    public virtual int Execute(object left, object right)
    {
        return 0;
    }





    protected bool Null(object o)
    {
        return o == null;
    }
}