namespace System.Compose;



public class Object : InfraObject
{
    public override bool Init()
    {
        base.Init();
        



        this.ObjectChanged = new EventEvent();


        this.ObjectChanged.Init();







        ulong o;


        o = IntentInfra.This.NewValue();
        




        this.Intent = new Intent();


        this.Intent.Init();


        this.Intent.Value = o;






        this.TriggerArg = new Change();


        this.TriggerArg.Init();




        return true;
    }






    public Intent Intent { get; set; }






    public virtual bool Change(Field field, Change change)
    {
        return true;
    }




    protected virtual bool Trigger(Field field)
    {
        this.TriggerArg.Object = this;


        this.TriggerArg.Field = field;



        this.Changed.Trigger(this.TriggerArg);
        


        return true;
    }





    private Change TriggerArg { get; set; }





    private EventEvent ObjectChanged { get; set; }





    public EventEvent Changed
    {
        get
        {
            return this.ObjectChanged;
        }

        set
        {
        }
    }   
}