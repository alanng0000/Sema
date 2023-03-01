namespace System.Event;




public class Handle : InfraObject
{
    public HandleInt Int { get; set; }




    public override bool Init()
    {
        base.Init();




        ulong o;


        o = HandleIntInfra.This.NewValue();
        




        this.Int = new HandleInt();


        this.Int.Init();


        this.Int.Value = o;




        return true;
    }





    public virtual bool Execute(object arg)
    {
        return true;
    }
}