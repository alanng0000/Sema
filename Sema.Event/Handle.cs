namespace Sema.Event;




public class Handle : InfraObject
{
    public override bool Init()
    {
        base.Init();




        IntInfra infra;

        infra = IntInfra.This;



        this.Int = infra.New();




        return true;
    }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}