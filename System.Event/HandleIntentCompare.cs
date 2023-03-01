namespace System.Event;




public class HandleIntCompare : Compare
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





        HandleInt leftO;


        leftO = (HandleInt)left;





        HandleInt rightO;


        rightO = (HandleInt)right;





        int t;


        t = leftO.Value.CompareTo(rightO.Value);




        int ret;


        ret = t;


        return ret;
    }
}