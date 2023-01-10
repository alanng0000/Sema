namespace System.View;



public class Frame : ComposeObject
{
    public override bool Init()
    {
        base.Init();
        




        WinRectangle rect;
        


        rect = WinScreen.PrimaryScreen.Bounds;




        this.Size = DrawConvert.This.Size(rect.Size);






        this.Form = new FrameForm();



        this.Form.Frame = this;


    
        this.Form.Init();






        this.Pos = new DrawPos();


        this.Pos.Init();


        this.Pos.Left = 0;


        this.Pos.Up = 0;





        this.Area = new DrawRect();


        this.Area.Init();



        this.Area.Pos = this.Pos;



        this.Area.Size.Width = this.Size.Width;


        this.Area.Size.Height = this.Size.Height;







        this.ViewField = new Field();


        this.ViewField.Object = this;


        this.ViewField.Init();





        this.Draw = new DrawDraw();



        this.Draw.Init();




        return true;
    }







    private FrameForm Form { get; set; }






    public virtual string Title { get; set; }





    public DrawSize Size
    {
        get; private set;
    }





    internal DrawDraw Draw { get; set; }








    internal bool ExecuteDraw()
    {
        this.Draw.Pos = this.Pos;



        this.Draw.Area = this.Area;


        this.Draw.SetClip();


        



        View view;


        view = this.View;



        

        if (this.Null(view))
        {
            return true;
        }






        view.LocalExecuteDraw(this.Draw);





        return true;
    }






    private DrawPos Pos;




    private DrawRect Area;






    public virtual bool Execute()
    {
        WinCursor.Hide();




        WinApplication.AddMessageFilter(this.Form);


        WinApplication.Run(this.Form);



        return true;
    }






    public virtual bool Update()
    {
        this.Form.Invalidate();



        return true;
    }






    public virtual bool Close()
    {
        this.Form.Close();
        


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
        this.Trigger(this.ViewField);


        return true;
    }






    public override bool Change(Field field, Change change)
    {
        if (this.ViewField == field)
        {
            this.ChangeView(change);
        }



        return true;
    }







    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}