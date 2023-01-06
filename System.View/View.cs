namespace System.View;




public class View : ComposeObject
{
    public override bool Init()
    {
        base.Init();





        this.ViewDraw = new DrawDraw();



        this.ViewDraw.Init();






        this.PosField = new Field();


        this.PosField.Object = this;


        this.PosField.Init();






        this.SizeField = new Field();


        this.SizeField.Object = this;


        this.SizeField.Init();






        this.ColorField = new Field();


        this.ColorField.Object = this;


        this.ColorField.Init();





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





        Color color;

        color = new Color();

        color.Init();



        this.Color = color;





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







    public virtual Field ColorField { get; set; }




    public virtual Color Color
    {
        get
        {
            return (Color)this.ColorField.Get();
        }

        set
        {
            this.ColorField.Set(value);
        }
    }





    protected virtual bool ChangeColor(Change change)
    {
        this.Trigger(this.ColorField);



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



        if (this.ColorField == field)
        {
            this.ChangeColor(change);
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
        if (!this.Visible)
        {
            return true;
        }





        DrawColor color;


        color = Create.This.DrawColor(this.Color);





        DrawColorBrush brush;



        brush = new DrawColorBrush();



        brush.Color = color;



        brush.Init();





        DrawRect rect;


        rect = new DrawRect();


        rect.Init();



        rect.Pos.Left = this.Pos.Left;


        rect.Pos.Up = this.Pos.Up;


        rect.Size.Width = this.Size.Width;


        rect.Size.Height = this.Size.Height;





        draw.Rect(brush, rect);






        this.DrawChild();







        return true;
    }






    protected virtual bool DrawChild()
    {
        if (this.Null(this.Child))
        {
            return true;
        }





        DrawRect area;


        area = new DrawRect();


        area.Init();



        area.Pos.Left = this.ViewDraw.Area.Pos.Left + this.Pos.Left;


        area.Pos.Up = this.ViewDraw.Area.Pos.Up + this.Pos.Up;



        area.Size.Width = this.Size.Width;


        area.Size.Height = this.Size.Height;






        this.BoundArea(this.ViewDraw.Area, ref area);






        DrawDraw draw;



        draw = this.Child.ViewDraw;




        draw.Graphics = this.ViewDraw.Graphics;



        draw.Area = area;





        this.Child.Draw(draw);






        return true;
    }






    private bool BoundArea(DrawRect bound, ref DrawRect area)
    {
        int left;

        left = area.Pos.Left;



        int up;

        up = area.Pos.Up;




        int width;

        width = area.Size.Width;



        int height;

        height = area.Size.Height;




        int right;

        right = left + width;



        int down;

        down = up + height;





        int boundRight;

        boundRight = bound.Pos.Left + bound.Size.Width;



        int boundDown;

        boundDown = bound.Pos.Up + bound.Size.Height;





        if (left < bound.Pos.Left)
        {
            left = bound.Pos.Left;
        }



        if (up < bound.Pos.Up)
        {
            up = bound.Pos.Up;
        }





        if (boundRight < right)
        {
            right = boundRight;
        }



        if (boundDown < down)
        {
            down = boundDown;
        }






        int w;


        w = IntOp.This.Sub(right, left);





        int h;


        h = IntOp.This.Sub(down, up);





        area.Pos.Left = left;


        area.Pos.Up = up;


        area.Size.Width = w;


        area.Size.Height = h;




        return true;
    }








    internal bool LocalDraw(DrawDraw draw)
    {
        return this.Draw(draw);
    }








    private DrawDraw ViewDraw { get; set; }






    internal DrawDraw LocalViewDraw
    { 
        get
        {
            return this.ViewDraw;
        }
    }







    private bool Null(object o)
    {
        return o == null;
    }
}