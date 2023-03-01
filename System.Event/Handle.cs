namespace System.Event;




public class Handle : InfraObject
{
    public Int Int { get; set; }




    public override bool Init()
    {
        base.Init();




        HandleIntInfra infra;

        infra = HandleIntInfra.This;


        ulong o;


        o = infra.NewValue();
        




        this.Int = new Int();


        this.Int.Init();


        this.Int.Value = o;




        return true;
    }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}