namespace System.View;




public class Rect : ComposeObject
{
    public override bool Init()
    {
        base.Init();





        this.PosField = new Field();


        this.PosField.Object = this;


        this.PosField.Init();







        this.UpField = new Field();


        this.UpField.Object = this;


        this.UpField.Init();





        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.PosField == field)
        {
            this.ChangePos(change);
        }





        if (this.UpField == field)
        {
            this.ChangeUp(change);
        }




        return true;
    }






    public virtual Field PosField { get; set; }




    public virtual Pos Pos
    {
        get
        {
            return (Pos)this.PosField.Get();
        }

        set
        {
            this.PosField.Set(value);
        }
    }




    protected virtual bool ChangePos(Change change)
    {
        this.Trigger(this.PosField);



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