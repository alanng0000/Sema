namespace System.Compose;



public class Object : InfraObject
{
    public override bool Init()
    {
        base.Init();
        



        this.ObjectChanged = new Event();


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

        change.Object = this;

        change.Field = field;


        this.Changed.Trigger(change);


        return true;
    }





    private Event ObjectChanged { get; set; }





    public Event Changed
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