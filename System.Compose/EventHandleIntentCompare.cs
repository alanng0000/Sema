namespace System.Compose;




public class EventHandleIntentCompare : Compare
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




        EventHandleIntent leftO;


        leftO = (EventHandleIntent)left;





        EventHandleIntent rightO;


        rightO = (EventHandleIntent)right;





        int t;


        t = leftO.Value.CompareTo(rightO.Value);




        int ret;


        ret = t;


        return ret;
    }
}