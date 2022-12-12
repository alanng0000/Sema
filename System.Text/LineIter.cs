namespace System.Text;




public struct LineIter
{
    internal ListLineEnumerator Enumerator;



    public bool Init()
    {
        return true;
    }




    public bool Next()
    {
        return this.Enumerator.MoveNext();
    }



    public Line Value
    {
        get
        {
            return this.Enumerator.Current;
        }
    }
}