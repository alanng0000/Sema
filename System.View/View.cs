namespace System.View;




public class View : CompObject
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








    public virtual bool Draw(DrawDraw draw)
    {
        if (!this.Visible)
        {
            return true;
        }
        





        this.DrawThis(draw);




        this.DrawChild(draw);




        return true;
    }








    protected virtual bool DrawThis(DrawDraw draw)
    {
        DrawRect rect;

        rect = new DrawRect();

        rect.Init();

        rect.Pos.Left = this.Pos.Left;

        rect.Pos.Up = this.Pos.Up;

        rect.Size.Width = this.Size.Width;

        rect.Size.Height = this.Size.Height;



        Brush brush;

        brush = this.Back;



        draw.Rect(rect, brush);



        return true;
    }









    protected virtual bool DrawChild(DrawDraw draw)
    {
        if (this.Null(this.Child))
        {
            return true;
        }




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




        DrawPos pos;

        pos = new DrawPos();

        pos.Init();

        pos.Left = left;

        pos.Up = up;




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






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.SetClip();






        this.Child.Draw(draw);







        draw.Pos = un;



        draw.Area = u;



        draw.SetClip();




        return true;
    }

    






    protected DrawInfra DrawInfra { get; set; }








    protected bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}