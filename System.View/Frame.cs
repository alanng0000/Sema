namespace System.View;



public class Frame : ComposeObject
{
    public override bool Init()
    {
        base.Init();
        




        WinRectangle rect;
        


        rect = WinScreen.PrimaryScreen.Bounds;




        this.Size = Create.This.DrawSize(rect.Size);






        this.Form = new FrameForm();



        this.Form.Frame = this;


    
        this.Form.Init();








        this.ViewField = new Field();


        this.ViewField.Object = this;


        this.ViewField.Init();





        return true;
    }







    private FrameForm Form { get; set; }






    public virtual string Title { get; set; }





    public DrawSize Size
    {
        get; private set;
    }









    public virtual bool Execute()
    {




        return true;
    }






    public virtual bool Update()
    {
        



        return true;
    }







    public virtual Field ViewField { get; set; }





    public virtual View View
    {
        get
        {
            return (View)this.ViewField.Get();
        }

        set
        {
            this.ViewField.Set(value);
        }
    }





    protected virtual bool ChangeView(Change change)
    {
        this.Update();




        return true;
    }







    private bool Null(object o)
    {
        return o == null;
    }
}