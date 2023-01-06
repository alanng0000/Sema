namespace System.View;




public class FontStyle : ComposeObject
{
    public override bool Init()
    {
        base.Init();




        this.BoldField = new Field();


        this.BoldField.Object = this;


        this.BoldField.Init();





        this.ItalicField = new Field();


        this.ItalicField.Object = this;


        this.ItalicField.Init();





        this.UnderlineField = new Field();


        this.UnderlineField.Object = this;


        this.UnderlineField.Init();





        this.StrikeoutField = new Field();


        this.StrikeoutField.Object = this;


        this.StrikeoutField.Init();





        this.Bold = false;


        this.Italic = false;


        this.Underline = false;


        this.Strikeout = false;



        return true;
    }




    public virtual Field BoldField { get; set; }



    public virtual bool Bold
    {
        get
        {
            return this.BoldField.GetBool();
        }

        set
        {
            this.BoldField.SetBool(value);
        }
    }




    protected virtual bool ChangeBold(Change change)
    {
        this.Trigger(this.BoldField);



        return true;
    }





    public virtual Field ItalicField { get; set; }



    public virtual bool Italic
    {
        get
        {
            return this.ItalicField.GetBool();
        }

        set
        {
            this.ItalicField.SetBool(value);
        }
    }




    protected virtual bool ChangeItalic(Change change)
    {
        this.Trigger(this.ItalicField);



        return true;
    }





    public virtual Field UnderlineField { get; set; }



    public virtual bool Underline
    {
        get
        {
            return this.UnderlineField.GetBool();
        }

        set
        {
            this.UnderlineField.SetBool(value);
        }
    }




    protected virtual bool ChangeUnderline(Change change)
    {
        this.Trigger(this.UnderlineField);



        return true;
    }




    public virtual Field StrikeoutField { get; set; }



    public virtual bool Strikeout
    {
        get
        {
            return this.StrikeoutField.GetBool();
        }

        set
        {
            this.StrikeoutField.SetBool(value);
        }
    }




    protected virtual bool ChangeStrikeout(Change change)
    {
        this.Trigger(this.StrikeoutField);



        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.BoldField == field)
        {
            this.ChangeBold(change);
        }


        if (this.ItalicField == field)
        {
            this.ChangeItalic(change);
        }


        if (this.UnderlineField == field)
        {
            this.ChangeUnderline(change);
        }


        if (this.StrikeoutField == field)
        {
            this.ChangeStrikeout(change);
        }



        return true;
    }
}