namespace System.Event;




public class HandleIntentCompare : Compare
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





        HandleIntent leftO;


        leftO = (HandleIntent)left;





        HandleIntent rightO;


        rightO = (HandleIntent)right;





        int t;


        t = leftO.Value.CompareTo(rightO.Value);




        int ret;


        ret = t;


        return ret;
    }
}