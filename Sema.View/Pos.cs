namespace Sema.View;




public class Pos : CompObject
{
    public override bool Init()
    {
        base.Init();





        this.LeftField = new Field();


        this.LeftField.Object = this;


        this.LeftField.Init();







        this.UpField = new Field();


        this.UpField.Object = this;


        this.UpField.Init();





        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.LeftField == field)
        {
            this.ChangeLeft(change);
        }





        if (this.UpField == field)
        {
            this.ChangeUp(change);
        }




        return true;
    }






    public virtual Field LeftField { get; set; }




    public virtual int Left
    {
        get
        {
            return this.LeftField.GetAxisInt();
        }

        set
        {
            this.LeftField.SetAxisInt(value);
        }
    }




    protected virtual bool ChangeLeft(Change change)
    {
        this.Trigger(this.LeftField);



        return true;
    }







    public virtual Field UpField { get; set; }




    public virtual int Up
    {
        get
        {
            return this.UpField.GetAxisInt();
        }

        set
        {
            this.UpField.SetAxisInt(value);
        }
    }




    protected virtual bool ChangeUp(Change change)
    {
        this.Trigger(this.UpField);



        return true;
    }
}