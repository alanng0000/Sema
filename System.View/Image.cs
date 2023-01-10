namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();






        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();





        this.SrcField = new Field();


        this.SrcField.Object = this;


        this.SrcField.Init();


        



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







    public virtual Field SrcField { get; set; }




    public virtual Rect Src
    {
        get
        {
            return (Rect)this.SrcField.Get();
        }

        set
        {
            this.SrcField.Set(value);
        }
    }





    protected virtual bool ChangeSrc(Change change)
    {
        this.Trigger(this.SrcField);



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
        if (this.Null(this.Value))
        {
            return true;
        }



        







        return true;
    }







    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);




        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }


        if (this.DestField == field)
        {
            this.ChangeDest(change);
        }


        if (this.SrcField == field)
        {
            this.ChangeSrc(change);
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