namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();




        this.ModeField = new Field();


        this.ModeField.Object = this;


        this.ModeField.Init();
        



        base.Init();


        




        this.Value = null;





        this.Mode = ImageModeList.This.Actual;




        return true;
    }





    public virtual Field ValueField { get; set; }




    public virtual Stream Value
    {
        get
        {
            return (Stream)this.ValueField.GetObject();
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







    public virtual Field ModeField { get; set; }



    public virtual ImageMode Mode
    {
        get
        {
            return (ImageMode)this.ModeField.GetObject();
        }

        set
        {
            this.ModeField.SetObject(value);
        }
    }




    protected virtual bool ChangeMode(Change change)
    {
        this.Trigger(this.ModeField);



        return true;
    }








    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);



        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }


        if (this.ModeField == field)
        {
            this.ChangeMode(change);
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