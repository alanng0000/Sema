namespace Sema.View;




public class GridChild : CompObject
{
    public override bool Init()
    {
        base.Init();



        IntInfra infra;

        infra = IntInfra.This;



        this.Int = infra.New();





        this.ViewField = new Field();


        this.ViewField.Object = this;


        this.ViewField.Init();





        this.RangeField = new Field();


        this.RangeField.Object = this;


        this.RangeField.Init();





        GridRange range;


        range = new GridRange();


        range.Init();



        this.Range = range;





        return true;
    }





    public virtual Field ViewField { get; set; }



    public virtual View View
    {
        get
        {
            return (View)this.ViewField.Get();
        }
        set
        {
            this.ViewField.Set(value);
        }
    }



    protected virtual bool ChangeView(Change change)
    {
        this.Trigger(this.ViewField);



        return true;
    }




    public virtual Field RangeField { get; set; }



    public virtual GridRange Range
    {
        get
        {
            return (GridRange)this.RangeField.Get();
        }
        set
        {
            this.RangeField.Set(value);
        }
    }




    protected virtual bool ChangeRange(Change change)
    {
        this.Trigger(this.RangeField);



        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.ViewField == field)
        {
            this.ChangeView(change);
        }



        if (this.RangeField == field)
        {
            this.ChangeRange(change);
        }
        



        return true;
    }
}