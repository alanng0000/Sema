namespace Sema;




public class IntCompare : Compare
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





        Int leftO;


        leftO = (Int)left;





        Int rightO;


        rightO = (Int)right;





        int t;


        t = leftO.Valu.CompareTo(rightO.Valu);




        int ret;


        ret = t;


        return ret;
    }
}