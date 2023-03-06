namespace System.Infra;




public class StringCompare : Compare
{
    public override int Execute(object left, object right)
    {
        if (left == null)
        {
            return 0;
        }



        if (right == null)
        {
            return 0;
        }




        string leftString;


        leftString = (string)left;





        string rightString;


        rightString = (string)right;





        int t;


        t = leftString.CompareTo(rightString);




        int ret;


        ret = t;


        return ret;
    }
}