namespace System.View;




public class Color : ComposeObject
{
    public override bool Init()
    {
        base.Init();





        this.AlphaField = new Field();


        this.AlphaField.Object = this;


        this.AlphaField.Init();




        this.RedField = new Field();


        this.RedField.Object = this;


        this.RedField.Init();



        this.GreenField = new Field();


        this.GreenField.Object = this;


        this.GreenField.Init();


    
        this.BlueField = new Field();


        this.BlueField.Object = this;


        this.BlueField.Init();





        this.Alpha = 0;


        this.Red = 0;


        this.Green = 0;


        this.Blue = 0;



        return true;
    }





    public virtual Field AlphaField { get; set; }



    public virtual int Alpha
    {
        get
        {
            return this.AlphaField.GetInt();
        }

        set
        {
            if (!this.ValidComponent(value))
            {
                return;
            }


            this.AlphaField.SetInt(value);
        }
    }




    protected virtual bool ChangeAlpha(Change change)
    {
        this.Trigger(this.AlphaField);



        return true;
    }




    public virtual Field RedField { get; set; }



    public virtual int Red
    {
        get
        {
            return this.RedField.GetInt();
        }

        set
        {
            if (!this.ValidComponent(value))
            {
                return;
            }

            this.RedField.SetInt(value);
        }
    }




    protected virtual bool ChangeRed(Change change)
    {
        this.Trigger(this.RedField);



        return true;
    }




    public virtual Field GreenField { get; set; }



    public virtual int Green
    {
        get
        {
            return this.GreenField.GetInt();
        }

        set
        {
            if (!this.ValidComponent(value))
            {
                return;
            }

            this.GreenField.SetInt(value);
        }
    }




    protected virtual bool ChangeGreen(Change change)
    {
        this.Trigger(this.GreenField);



        return true;
    }




    public virtual Field BlueField { get; set; }



    public virtual int Blue
    {
        get
        {
            return this.BlueField.GetInt();
        }

        set
        {
            if (!this.ValidComponent(value))
            {
                return;
            }

            this.BlueField.SetInt(value);
        }
    }




    protected virtual bool ChangeBlue(Change change)
    {
        this.Trigger(this.BlueField);



        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.AlphaField == field)
        {
            this.ChangeAlpha(change);
        }


        if (this.RedField == field)
        {
            this.ChangeRed(change);
        }


        if (this.GreenField == field)
        {
            this.ChangeGreen(change);
        }


        if (this.BlueField == field)
        {
            this.ChangeBlue(change);
        }



        return true;
    }





    private bool ValidComponent(int value)
    {
        return 0 <= value & value <= byte.MaxValue;
    }
}