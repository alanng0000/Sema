namespace Sema.Mode;




public class VerCompare : Compare
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




        Ver leftVer;



        leftVer = (Ver)left;





        Ver rightVer;



        rightVer = (Ver)right;




        int u;


        u = leftVer.Value.CompareTo(rightVer.Value);



        return u;
    }
}