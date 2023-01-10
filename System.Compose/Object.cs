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





        return true;
    }






    public Intent Intent { get; set; }






    public virtual bool Change(Field field, Change change)
    {
        return true;
    }




    protected virtual bool Trigger(Field field)
    {
        Change change;

        change = new Change();

        change.Init();

        change.Object = this;

        change.Field = field;


        this.Changed.Trigger(change);


        return true;
    }





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