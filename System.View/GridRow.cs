namespace System.View;




public class GridRow : CompObject
{
    public override bool Init()
    {
        base.Init();



        IntInfra infra;

        infra = IntInfra.This;



        this.Int = infra.New();





        this.HeightField = new Field();


        this.HeightField.Object = this;


        this.HeightField.Init();




        this.Height = 0;




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




    public override bool Change(Field field, Change change)
    {
        if (this.HeightField == field)
        {
            this.ChangeHeight(change);
        }



        return true;
    }
}