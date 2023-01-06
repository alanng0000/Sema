namespace System.View;





public class Draw : View
{
    public override bool Init()
    {
        this.DrawControl = new DrawControl();



        this.DrawControl.Draw = this;



        this.DrawControl.Init();




        base.Init();





        this.Internal.Controls.Add(this.DrawControl);
        





        return true;
    }






    protected virtual bool Ops(WinGraphics graphics, WinRectangle clipRect)
    {
        return true;
    }






    public virtual WinGraphics CreateGraphics()
    {
        WinGraphics g;
        

        g = this.DrawControl.CreateGraphics();


        this.SetGraphicsDefault(g);



        WinGraphics ret;

        ret = g;


        return ret;
    }




    internal bool SetGraphicsDefault(WinGraphics g)
    {
        g.TextRenderingHint = WinTextRenderingHint.ClearTypeGridFit;


        g.PageUnit = WinGraphicsUnit.Pixel;


        return true;
    }




    protected override bool ChangeSize(Change change)
    {
        this.DrawControl.Size = this.WinCreate.Size(this.Size);




        base.ChangeSize(change);




        return true;
    }






    internal bool LocalOps(WinGraphics graphics, WinRectangle clipRect)
    {
        this.Ops(graphics, clipRect);


        return true;
    }




    private DrawControl DrawControl { get; set; }
}