namespace Sema.View;




public class GridPos : CompObject
{
    public override bool Init()
    {
        base.Init();





        this.RowField = new Field();


        this.RowField.Object = this;


        this.RowField.Init();





        this.ColField = new Field();


        this.ColField.Object = this;


        this.ColField.Init();





        this.Row = 0;




        this.Col = 0;





        return true;
    }

    



    public virtual Field RowField { get; set; }




    public virtual int Row
    {
        get
        {
            return this.RowField.GetInt();
        }

        set
        {
            this.RowField.SetInt(value);
        }
    }




    protected virtual bool ChangeRow(Change change)
    {
        this.Trigger(this.RowField);



        return true;
    }




    public virtual Field ColField { get; set; }




    public virtual int Col
    {
        get
        {
            return this.ColField.GetInt();
        }

        set
        {
            this.ColField.SetInt(value);
        }
    }




    protected virtual bool ChangeCol(Change change)
    {
        this.Trigger(this.ColField);



        return true;
    }






    public override bool Change(Field field, Change change)
    {
        if (this.RowField == field)
        {
            this.ChangeRow(change);
        }



        if (this.ColField == field)
        {
            this.ChangeCol(change);
        }
        



        return true;
    }
}