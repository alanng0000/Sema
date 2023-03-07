namespace Sema.View;




public class Text : View
{
    public override bool Init()
    {
        base.Init();




        this.ValuField = new Field();


        this.ValuField.Object = this;


        this.ValuField.Init();





        this.ForeField = new Field();


        this.ForeField.Object = this;


        this.ForeField.Init();





        this.FontField = new Field();


        this.FontField.Object = this;


        this.FontField.Init();






        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();




        


        TextValu valu;

        valu = new TextValu();

        valu.Init();

        valu.Span.String = "";

        valu.Span.Range.Start = 0;

        valu.Span.Range.End = 0;



        this.Valu = valu;





        DrawConstant drawConstant;

        drawConstant = DrawConstant.This;



        ColorBrush brush;

        brush = new ColorBrush();

        brush.Init();

        brush.Color = drawConstant.BlackColor;




        this.Fore = brush;





        Constant constant;

        constant = Constant.This;



        this.Font = constant.DefaultFont;





        Rect dest;

        dest = new Rect();

        dest.Init();


        this.Dest = dest;





        return true;
    }






    public virtual Field ValuField { get; set; }




    public virtual TextValu Valu
    {
        get
        {
            return (TextValu)this.ValuField.GetObject();
        }

        set
        {
            this.ValuField.SetObject(value);
        }
    }





    protected virtual bool ChangeValu(Change change)
    {
        this.Trigger(this.ValuField);



        return true;
    }







    public virtual Field ForeField { get; set; }




    public virtual Brush Fore
    {
        get
        {
            return (Brush)this.ForeField.GetObject();
        }

        set
        {
            this.ForeField.SetObject(value);
        }
    }





    protected virtual bool ChangeFore(Change change)
    {
        this.Trigger(this.ForeField);



        return true;
    }






    public virtual Field FontField { get; set; }




    public virtual Font Font
    {
        get
        {
            return (Font)this.FontField.GetObject();
        }

        set
        {
            this.FontField.SetObject(value);
        }
    }





    protected virtual bool ChangeFont(Change change)
    {
        this.Trigger(this.FontField);



        return true;
    }






    public virtual Field DestField { get; set; }




    public virtual Rect Dest
    {
        get
        {
            return (Rect)this.DestField.Get();
        }

        set
        {
            this.DestField.Set(value);
        }
    }





    protected virtual bool ChangeDest(Change change)
    {
        this.Trigger(this.DestField);



        return true;
    }






    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);



        if (this.ValuField == field)
        {
            this.ChangeValu(change);
        }


        if (this.ForeField == field)
        {
            this.ChangeFore(change);
        }


        if (this.FontField == field)
        {
            this.ChangeFont(change);
        }


        if (this.DestField == field)
        {
            this.ChangeDest(change);
        }



        return true;
    }






    protected override bool DrawThis(DrawDraw draw)
    {
        base.DrawThis(draw);

        


        this.DrawText(draw);





        return true;
    }






    protected virtual bool DrawText(DrawDraw draw)
    {
        TextValu valu;


        valu = this.Valu;



        CharSpan charSpan;

        charSpan = valu.Span;



        Font font;

        font = this.Font;




        Brush brush;


        brush = this.Fore;




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



        DrawInfra drawInfra;

        drawInfra = DrawInfra.This;


        drawInfra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.Clip();





        Infra infra;

        infra = Infra.This;




        DrawRect destRect;


        destRect = new DrawRect();


        destRect.Init();



        infra.DrawRect(this.Dest, ref destRect);





        draw.Text(charSpan, destRect, font, brush);







        draw.Pos = un;



        draw.Area = u;



        draw.Clip();



        return true;
    }







    public override View Child
    {
        get
        {
            return null;
        }

        set
        {
        }
    }
}