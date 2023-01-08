namespace System.View;




public class Text : View
{
    public override bool Init()
    {
        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();





        this.FontField = new Field();


        this.FontField.Object = this;


        this.FontField.Init();







        base.Init();


        




        this.Color.Alpha = byte.MaxValue;




        this.Value = "";





        Font font;


        font = new Font();


        font.Init();


        this.Font = font;





        return true;
    }





    public virtual Field ValueField { get; set; }




    public virtual string Value
    {
        get
        {
            return this.ValueField.GetString();
        }

        set
        {
            this.ValueField.SetString(value);
        }
    }





    protected virtual bool ChangeValue(Change change)
    {
        this.Trigger(this.ValueField);



        return true;
    }






    public virtual Field FontField { get; set; }




    public virtual Font Font
    {
        get
        {
            return (Font)this.FontField.Get();
        }

        set
        {
            this.FontField.Set(value);
        }
    }





    protected virtual bool ChangeFont(Change change)
    {
        this.Trigger(this.FontField);



        return true;
    }







    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);



        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }


        if (this.FontField == field)
        {
            this.ChangeFont(change);
        }



        return true;
    }






    protected override bool Draw(DrawDraw draw)
    {
        if (!this.Visible)
        {
            return true;
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