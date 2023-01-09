namespace System.Compose;



public class Object : InfraObject
{
    public override bool Init()
    {
        base.Init();
        



        this.ObjectChanged = new EventEvent();


        this.ObjectChanged.Init();



        return true;
    }




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