namespace System.Compose;




public class IdCompare : Compare
{
    public override int Execute(object left, object right)
    {
        if (this.Null(left))
        {
            return 0;
        }



        if (this.Null(right))
        {
            return 0;
        }




        ulong leftO;


        leftO = (ulong)left;





        ulong rightO;


        rightO = (ulong)right;





        int t;


        t = leftO.CompareTo(rightO);




        int ret;


        ret = t;


        return ret;
    }




    private bool Null(object o)
    {
        return o == null;
    }
}