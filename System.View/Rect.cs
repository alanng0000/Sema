namespace System.View;




public class Rect : CompObject
{
    public override bool Init()
    {
        base.Init();





        this.PosField = new Field();


        this.PosField.Object = this;


        this.PosField.Init();







        this.SizeField = new Field();


        this.SizeField.Object = this;


        this.SizeField.Init();





        Pos pos;

        pos = new Pos();

        pos.Init();



        this.Pos = pos;




        Size size;

        size = new Size();

        size.Init();



        this.Size = size;
        





        return true;
    }





    public override bool Change(Field field, Change change)
    {
        if (this.PosField == field)
        {
            this.ChangePos(change);
        }





        if (this.SizeField == field)
        {
            this.ChangeSize(change);
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







    public virtual Field SizeField { get; set; }




    public virtual Size Size
    {
        get
        {
            return (Size)this.SizeField.Get();
        }

        set
        {
            this.SizeField.Set(value);
        }
    }




    protected virtual bool ChangeSize(Change change)
    {
        this.Trigger(this.SizeField);



        return true;
    }
}