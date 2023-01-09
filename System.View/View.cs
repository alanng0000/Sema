namespace System.View;




public class View : ComposeObject
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














    private bool Null(object o)
    {
        return o == null;
    }
}