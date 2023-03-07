namespace Sema.Mode;




public class NameCompare : Compare
{
    private StringCompare StringCompare { get; set; }



    public override bool Init()
    {
        base.Init();



        this.StringCompare = new StringCompare();


        this.StringCompare.Init();



        return true;
    }

    



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




        Name leftName;



        leftName = (Name)left;




        Name rightName;



        rightName = (Name)right;




        int u;


        u = this.StringCompare.Execute(leftName.Valu, rightName.Valu);


        return u;
    }
}