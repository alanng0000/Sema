namespace Sema.View;




public class GridCol : CompObject
{
    public override bool Init()
    {
        base.Init();



        IntInfra infra;

        infra = IntInfra.This;



        this.Int = infra.New();





        this.WidthField = new Field();


        this.WidthField.Object = this;


        this.WidthField.Init();




        this.Width = 0;
        



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





    public override bool Change(Field field, Change change)
    {
        if (this.WidthField == field)
        {
            this.ChangeWidth(change);
        }



        return true;
    }
}