namespace System.Event;




public class Handle : InfraObject
{
    public HandleIntent Intent { get; set; }




    public override bool Init()
    {
        base.Init();




        ulong o;


        o = HandleIntentInfra.This.NewValue();
        




        this.Intent = new HandleIntent();


        this.Intent.Init();


        this.Intent.Value = o;




        return true;
    }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}