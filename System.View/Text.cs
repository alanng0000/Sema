namespace System.View;




public class Text : View
{
    public override bool Init()
    {
        base.Init();




        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();





        this.ForeField = new Field();


        this.ForeField.Object = this;


        this.ForeField.Init();





        this.FontField = new Field();


        this.FontField.Object = this;


        this.FontField.Init();






        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();




        


        TextValue value;

        value = new TextValue();

        value.Init();

        value.Span.String = "";

        value.Span.Range.Start = 0;

        value.Span.Range.End = 0;



        this.Value = value;




        Color color;

        color = new Color();

        color.Init();

        color.Value = Constant.This.BlackColor;



        this.Fore = color;





        this.InitFont();




        Rect dest;

        dest = new Rect();

        dest.Init();


        this.Dest = dest;





        return true;
    }





    private bool InitFont()
    {
        FontStyle fontStyle;

        fontStyle = new FontStyle();

        fontStyle.Init();




        Font font;


        font = new Font();


        font.Family = "Segoe UI Variable Display";


        font.Size = 16;


        font.Style = fontStyle;


        font.Init();



        this.Font = font;


        
        return true;
    }







    public virtual Field ValueField { get; set; }




    public virtual TextValue Value
    {
        get
        {
            return (TextValue)this.ValueField.GetObject();
        }

        set
        {
            this.ValueField.SetObject(value);
        }
    }





    protected virtual bool ChangeValue(Change change)
    {
        this.Trigger(this.ValueField);



        return true;
    }







    public virtual Field ForeField { get; set; }




    public virtual Color Fore
    {
        get
        {
            return (Color)this.ForeField.GetObject();
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



        if (this.ValueField == field)
        {
            this.ChangeValue(change);
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






    protected override bool Draw(DrawDraw draw)
    {
        base.Draw(draw);

        


        this.DrawText(draw);





        return true;
    }






    protected virtual bool DrawText(DrawDraw draw)
    {
        TextValue value;


        value = this.Value;



        CharSpan charSpan;

        charSpan = value.Span;



        Font font;

        font = this.Font;




        DrawColor drawColor;


        drawColor = this.Fore.Value;




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








        DrawRect destRect;


        destRect = new DrawRect();


        destRect.Init();



        Infra.This.DrawRect(this.Dest, ref destRect);





        draw.Text(charSpan, font, drawColor, destRect);







        draw.Pos = un;



        draw.Area = u;



        draw.SetClip();



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