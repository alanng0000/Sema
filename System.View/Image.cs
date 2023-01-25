namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        base.Init();




        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();






        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();





        this.SourceField = new Field();


        this.SourceField.Object = this;


        this.SourceField.Init();


        

        



        this.Value = null;





        Rect dest;

        dest = new Rect();

        dest.Init();


        this.Dest = dest;




        Rect source;

        source = new Rect();

        source.Init();


        this.Source = source;






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







    public virtual Field SourceField { get; set; }




    public virtual Rect Source
    {
        get
        {
            return (Rect)this.SourceField.Get();
        }

        set
        {
            this.SourceField.Set(value);
        }
    }





    protected virtual bool ChangeSource(Change change)
    {
        this.Trigger(this.SourceField);



        return true;
    }







    protected override bool DrawThis(DrawDraw draw)
    {
        base.DrawThis(draw);



        
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



        DrawInfra infra;

        infra = DrawInfra.This;


        infra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.Clip();







        DrawRect destRect;


        destRect = new DrawRect();


        destRect.Init();



        Infra.This.DrawRect(this.Dest, ref destRect);





        DrawRect sourceRect;


        sourceRect = new DrawRect();


        sourceRect.Init();



        Infra.This.DrawRect(this.Source, ref sourceRect);
        





        draw.Image(image, destRect, sourceRect);







        draw.Pos = un;



        draw.Area = u;



        draw.Clip();





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


        if (this.SourceField == field)
        {
            this.ChangeSource(change);
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