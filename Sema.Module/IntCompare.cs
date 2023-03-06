namespace System.Module;




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




        Int leftInt;



        leftInt = (Int)left;





        Int rightInt;



        rightInt = (Int)right;




        int u;


        u = leftInt.Value.CompareTo(rightInt.Value);



        return u;
    }
}