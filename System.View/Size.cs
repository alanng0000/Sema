namespace System.View;




public class Size : CompObject
{
    public override bool Init()
    {
        base.Init();





        this.WidthField = new Field();


        this.WidthField.Object = this;


        this.WidthField.Init();





        this.HeightField = new Field();


        this.HeightField.Object = this;


        this.HeightField.Init();




        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.WidthField == field)
        {
            this.ChangeWidth(change);
        }




        if (this.HeightField == field)
        {
            this.ChangeHeight(change);
        }




        return true;
    }







    public virtual Field WidthField { get; set; }







    public virtual int Width
    {
        get
        {
            return this.WidthField.GetInt();
        }

        set
        {
            this.WidthField.SetInt(value);
        }
    }




    protected virtual bool ChangeWidth(Change change)
    {
        this.Trigger(this.WidthField);



        return true;
    }








    public virtual Field HeightField { get; set; }







    public virtual int Height
    {
        get
        {
            return this.HeightField.GetInt();
        }

        set
        {
            this.HeightField.SetInt(value);
        }
    }




    protected virtual bool ChangeHeight(Change change)
    {
        this.Trigger(this.HeightField);



        return true;
    }
}