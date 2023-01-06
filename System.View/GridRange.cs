namespace System.View;




public class GridRange : ComposeObject
{
    public override bool Init()
    {
        base.Init();



        this.StartField = new Field();


        this.StartField.Object = this;


        this.StartField.Init();





        this.EndField = new Field();


        this.EndField.Object = this;


        this.EndField.Init();





        GridPos start;

        start = new GridPos();

        start.Init();


        this.Start = start;




        GridPos end;

        end = new GridPos();

        end.Init();


        this.End = end;





        return true;
    }




    public virtual Field StartField { get; set; }



    public virtual GridPos Start
    {
        get
        {
            return (GridPos)this.StartField.Get();
        }

        set
        {
            this.StartField.Set(value);
        }
    }



    protected virtual bool ChangeStart(Change change)
    {
        this.Trigger(this.StartField);



        return true;
    }




    public virtual Field EndField { get; set; }



    public virtual GridPos End
    {
        get
        {
            return (GridPos)this.EndField.Get();
        }

        set
        {
            this.EndField.Set(value);
        }
    }



    protected virtual bool ChangeEnd(Change change)
    {
        this.Trigger(this.EndField);



        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.StartField == field)
        {
            this.ChangeStart(change);
        }



        if (this.EndField == field)
        {
            this.ChangeEnd(change);
        }
        



        return true;
    }
}