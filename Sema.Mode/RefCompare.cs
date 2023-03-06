namespace Sema.Mode;




public class RefCompare : Compare
{
    public override bool Init()
    {
        base.Init();




        this.IntCompare = new IntCompare();


        this.IntCompare.Init();




        this.VerCompare = new VerCompare();


        this.VerCompare.Init();





        return true;
    }





    private IntCompare IntCompare { get; set; }




    private VerCompare VerCompare { get; set; }






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






        Ref leftRef;



        leftRef = (Ref)left;





        Ref rightRef;



        rightRef = (Ref)right;





        int u;



        u = this.IntCompare.Execute(leftRef.Int, rightRef.Int);



        if (!(u == 0))
        {
            return u;
        }



        

        u = this.VerCompare.Execute(leftRef.Ver, rightRef.Ver);





        return u;
    }
}