namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();






        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();





        this.SrcField = new Field();


        this.SrcField.Object = this;


        this.SrcField.Init();


        



        base.Init();


        



        this.Value = null;






        return true;
    }





    public virtual Field ValueField { get; set; }




    public virtual DrawImage Value
    {
        get
        {
            return (DrawImage)this.ValueField.GetObject();
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







    public virtual Field SrcField { get; set; }




    public virtual Rect Src
    {
        get
        {
            return (Rect)this.SrcField.Get();
        }

        set
        {
            this.SrcField.Set(value);
        }
    }





    protected virtual bool ChangeSrc(Change change)
    {
        this.Trigger(this.SrcField);



        return true;
    }







    protected override bool Draw(DrawDraw draw)
    {
        base.Draw(draw);



        
        this.DrawImage(draw);




        return true;
    }







    protected virtual bool DrawImage(DrawDraw draw)
    {
        if (this.Null(this.Value))
        {
            return true;
        }




        
        DrawImage image;


        image = this.Value;






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



        this.DrawRect(this.Dest, ref destRect);





        DrawRect srcRect;


        srcRect = new DrawRect();


        srcRect.Init();



        this.DrawRect(this.Src, ref srcRect);
        





        draw.Image(image, destRect, srcRect);







        draw.Pos = un;



        draw.Area = u;



        draw.SetClip();





        return true;
    }




    private bool DrawRect(Rect rect, ref DrawRect drawRect)
    {
        drawRect.Pos = new DrawPos();

        drawRect.Pos.Init();


        drawRect.Pos.Left = rect.Pos.Left;

        drawRect.Pos.Up = rect.Pos.Up;




        drawRect.Size = new DrawSize();

        drawRect.Size.Init();


        drawRect.Size.Width = rect.Size.Width;

        drawRect.Size.Height = rect.Size.Height;



        return true;
    }






    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);




        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }


        if (this.DestField == field)
        {
            this.ChangeDest(change);
        }


        if (this.SrcField == field)
        {
            this.ChangeSrc(change);
        }




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