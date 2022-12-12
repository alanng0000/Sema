namespace System.List;




public interface IIter
{
    object Key
    {
        get;

        set;
    }




    object Value
    {
        get;

        set;
    }




    bool Next();
}