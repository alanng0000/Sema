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





        this.Area = new DrawRect();


        this.Area.Init();



        this.Area.Pos.Left = 0;


        this.Area.Pos.Up = 0;


        this.Area.Size.Width = this.Size.Width;


        this.Area.Size.Height = this.Size.Height;







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













    private bool SetGraphicsDefault()
    {
        this.Graphics.TextRenderingHint = WinTextRenderingHint.ClearTypeGridFit;


        this.Graphics.PageUnit = WinGraphicsUnit.Pixel;



        return true;
    }







    internal bool DrawGraphics(WinGraphics g)
    {
        this.Graphics = g;



        this.SetGraphicsDefault();





        this.Draw();








        return true;
    }






    private bool Draw()
    {
        if (this.Null(this.View))
        {
            return true;
        }




        DrawDraw draw;


        draw = this.View.LocalViewDraw;



        draw.Graphics = this.Graphics;



        draw.Area = this.Area;




        this.View.LocalDraw(draw);




        return true;
    }






    private DrawRect Area;





    private WinGraphics Graphics { get; set; }






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