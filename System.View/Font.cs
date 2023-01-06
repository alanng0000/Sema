namespace System.View;




public class Font : ComposeObject
{
    public override bool Init()
    {
        base.Init();





        this.FamilyField = new Field();


        this.FamilyField.Object = this;


        this.FamilyField.Init();





        this.SizeField = new Field();


        this.SizeField.Object = this;


        this.SizeField.Init();





        this.StyleField = new Field();


        this.StyleField.Object = this;


        this.StyleField.Init();




        this.Family = "Segoe UI Variable Display";



        this.Size = 13;



        FontStyle style;

        style = new FontStyle();

        style.Init();



        this.Style = style;




        return true;
    }





    public virtual Field FamilyField { get; set; }



    public virtual string Family
    {
        get
        {
            return this.FamilyField.GetString();
        }

        set
        {
            this.FamilyField.SetString(value);
        }
    }




    protected virtual bool ChangeFamily(Change change)
    {
        this.Trigger(this.FamilyField);



        return true;
    }




    public virtual Field SizeField { get; set; }



    public virtual float Size
    {
        get
        {
            return this.SizeField.GetFloat();
        }

        set
        {
            this.SizeField.SetFloat(value);
        }
    }




    protected virtual bool ChangeSize(Change change)
    {
        this.Trigger(this.SizeField);



        return true;
    }




    public virtual Field StyleField { get; set; }



    public virtual FontStyle Style
    {
        get
        {
            return (FontStyle)this.StyleField.Get();
        }

        set
        {
            this.StyleField.Set(value);
        }
    }




    protected virtual bool ChangeStyle(Change change)
    {
        this.Trigger(this.StyleField);



        return true;
    }




    public override bool Change(Field field, Change change)
    {
        if (this.FamilyField == field)
        {
            this.ChangeFamily(change);
        }


        if (this.SizeField == field)
        {
            this.ChangeSize(change);
        }


        if (this.StyleField == field)
        {
            this.ChangeStyle(change);
        }



        return true;
    }
}