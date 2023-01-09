namespace System.View;




public class View : ComposeObject
{
    public override bool Init()
    {
        base.Init();





        this.DrawInfra = new DrawInfra();



        this.DrawInfra.Init();






        this.PosField = new Field();


        this.PosField.Object = this;


        this.PosField.Init();






        this.SizeField = new Field();


        this.SizeField.Object = this;


        this.SizeField.Init();






        this.BackField = new Field();


        this.BackField.Object = this;


        this.BackField.Init();





        this.VisibleField = new Field();


        this.VisibleField.Object = this;


        this.VisibleField.Init();





        this.ChildField = new Field();


        this.ChildField.Object = this;


        this.ChildField.Init();







        Pos pos;


        pos = new Pos();


        pos.Init();


        pos.Left = 0;


        pos.Up = 0;



        this.Pos = pos;






        Size size;


        size = new Size();


        size.Init();


        size.Width = 0;


        size.Height = 0;




        this.Size = size;





        
        ColorBrush brush;


        brush = new ColorBrush();


        brush.Color = Constant.This.WhiteColor;


        brush.Init();
        



        this.Back = brush;





        this.Visible = true;




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







    public virtual Field BackField { get; set; }




    public virtual Brush Back
    {
        get
        {
            return (Brush)this.BackField.GetObject();
        }

        set
        {
            this.BackField.SetObject(value);
        }
    }





    protected virtual bool ChangeBack(Change change)
    {
        this.Trigger(this.BackField);



        return true;
    }





    public virtual Field VisibleField { get; set; }




    public virtual bool Visible
    {
        get
        {
            return this.VisibleField.GetBool();
        }

        set
        {
            this.VisibleField.SetBool(value);
        }
    }





    protected virtual bool ChangeVisible(Change change)
    {
        this.Trigger(this.VisibleField);



        return true;
    }






    public virtual Field ChildField { get; set; }




    public virtual View Child
    {
        get
        {
            return (View)this.ChildField.Get();
        }

        set
        {
            this.ChildField.Set(value);
        }
    }





    protected virtual bool ChangeChild(Change change)
    {
        this.Trigger(this.ChildField);



        return true;
    }









    public override bool Change(Field field, Change change)
    {
        if (this.SizeField == field)
        {
            this.ChangeSize(change);
        }



        if (this.PosField == field)
        {
            this.ChangePos(change);
        }



        if (this.BackField == field)
        {
            this.ChangeBack(change);
        }



        if (this.VisibleField == field)
        {
            this.ChangeVisible(change);
        }



        if (this.ChildField == field)
        {
            this.ChangeChild(change);
        }



        return true;
    }





    protected virtual bool Draw(DrawDraw draw)
    {
        return true;
    }







    public virtual bool ExecuteDraw(DrawDraw draw)
    {
        this.Draw(draw);




        int left;
        
        left = this.Pos.Left;



        int up;

        up = this.Pos.Up;



        left = left + draw.Pos.Left;


        up = up + draw.Pos.Up;




        int width;

        width = this.Size.Width;



        int height;

        height = this.Size.Height;




        DrawRect rect;

        rect = new DrawRect();

        rect.Init();

        rect.Pos.Left = left;

        rect.Pos.Up = up;

        rect.Size.Width = width;

        rect.Size.Height = height;



        DrawRect u;

        u = draw.Area;



        this.DrawInfra.BoundArea(u, ref rect);




        DrawPos o;

        o = new DrawPos();

        o.Init();

        o.Left = left;

        o.Up = up;





        DrawPos un;

        un = draw.Pos;




        draw.Pos = o;




        draw.Area = rect;



        draw.SetClip();




        this.ExecuteChildDraw(draw);





        draw.Pos = un;
        


        draw.Area = u;


        draw.SetClip();





        return true;
    }





    protected virtual bool ExecuteChildDraw(DrawDraw draw)
    {
        if (!this.Null(this.Child))
        {
            this.Child.ExecuteDraw(draw);
        }



        return true;
    }

    





    internal bool LocalExecuteDraw(DrawDraw draw)
    {
        this.ExecuteDraw(draw);



        return true;
    }






    protected DrawInfra DrawInfra { get; set; }








    private bool Null(object o)
    {
        return o == null;
    }
}