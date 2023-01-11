namespace System.Compose;




public class IntentCompare : Compare
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





        Intent leftO;


        leftO = (Intent)left;





        Intent rightO;


        rightO = (Intent)right;





        int t;


        t = leftO.Value.CompareTo(rightO.Value);




        int ret;


        ret = t;


        return ret;
    }
}