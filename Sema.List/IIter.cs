namespace Sema.List;




public interface IIter
{
    object Key
    {
        get;

        set;
    }




    object Valu
    {
        get;

        set;
    }




    bool Next();
}