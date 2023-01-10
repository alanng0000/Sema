namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();

        



        base.Init();


        



        this.Value = null;






        return true;
    }





    public virtual Field ValueField { get; set; }




    public virtual DrawImage Value
    {
        get
        {
            return (DrawImage)this.ValueField.GetObject();
        }

        set
        {
            this.ValueField.SetObject(value);
        }
    }





    protected virtual bool ChangeValue(Change change)
    {
        this.Trigger(this.ValueField);



        return true;
    }







    public virtual Field DestField { get; set; }




    public virtual Rect Dest
    {
        get
        {
            return (Rect)this.DestField.Get();
        }

        set
        {
            this.DestField.Set(value);
        }
    }





    protected virtual bool ChangeDest(Change change)
    {
        this.Trigger(this.DestField);



        return true;
    }







    protected override bool Draw(DrawDraw draw)
    {
        base.Draw(draw);



        
        this.DrawImage(draw);




        return true;
    }







    protected virtual bool DrawImage(DrawDraw draw)
    {
        return true;
    }







    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);



        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }




        return true;
    }




    public override View Child
    {
        get
        {
            return null;
        }

        set
        {
        }
    }
}