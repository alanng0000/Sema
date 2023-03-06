namespace System.Infra;




public class Compare : Object
{
    public virtual int Execute(object left, object right)
    {
        return 0;
    }





    protected bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}